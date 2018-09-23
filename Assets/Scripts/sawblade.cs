using UnityEngine;

public class sawblade : MonoBehaviour {
	public bool IsMoving;
	
	public Vector2[] Points;
	public float speed;
    public bool LoopMoves;

	Vector2 initialPosition;
	// Use this for initialization
	void Start () {
		initialPosition = new Vector2(transform.position.x, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		Spin();
	}

	void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		foreach (Vector2 Point in Points)
		{
			transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), Point, speed * Time.deltaTime);
		}	
		if (LoopMoves)
		{
			while (true)
			{
				transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), initialPosition, speed * Time.deltaTime);
				foreach (Vector2 Point in Points)
		        {		
					transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), Point, speed * Time.deltaTime);
		        }	

			}
			
		}
	}

	void Spin()
	{
		transform.Rotate(0, 0, -20 * transform.localScale.x);
	}
}

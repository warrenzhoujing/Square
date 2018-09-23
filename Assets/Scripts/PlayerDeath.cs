using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    public LayerMask WhatIsBad;
    public Vector3 RespawnPosition;

	void Start()
	{
        RespawnPosition = transform.position;
	}

	void Update()
	{
        CheckDeath();
	}

	void CheckDeath()
    {
        if (transform.position.y < -20)
        {
            transform.position = RespawnPosition;
        }
        if (Physics2D.OverlapBox(transform.position, new Vector2(0.4f, 0.4f), 0, WhatIsBad))
        {
            transform.position = RespawnPosition;
        }
    }
}

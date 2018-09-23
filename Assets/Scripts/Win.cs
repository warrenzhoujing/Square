using UnityEngine;

public class Win : MonoBehaviour {

    public LayerMask WhatIsGoal;
    public GameObject LevelComplete;
    public GameObject Goal;
    public BoxCollider2D GoalBC2D;

	void Start()
	{
        Goal = GameObject.Find("Goal");
        GoalBC2D = Goal.GetComponent<BoxCollider2D>();
	}

	void Update()
	{
        if (Physics2D.OverlapBox(transform.position, new Vector2(0.4f, 0.4f), 0, WhatIsGoal))
        {
            GoalBC2D.enabled = false;
            LevelComplete.SetActive(true);
        }
	}
}

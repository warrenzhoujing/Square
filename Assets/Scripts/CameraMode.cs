using UnityEngine;
using UnityEditor;

public class CameraMode : MonoBehaviour {

    [Tooltip("Modes: FollowPlayer, Stationary, ScrollX, ScrollY")]
    public string mode;

    public GameObject Square;
	void Start () {
        Square = GameObject.Find("Square");
	}
	
	void Update () {
        if (mode == "FollowPlayer")
        {
            transform.position = new Vector3(Square.transform.position.x, Square.transform.position.y, -10);
        }
        else if (mode == "ScrollX")
        {
            transform.position = new Vector3(Square.transform.position.x, transform.position.y, -10);
        }
        else if (mode == "ScrollY")
        {
            transform.position = new Vector3(transform.position.x, Square.transform.position.y, -10);
        }
        else if (mode == "Stationary")
        {
            
        }
        else
        {
            Debug.LogError(mode + " mode does not exist");
            mode = "Stationary";
        }
	}
}

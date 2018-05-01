using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour {

    public GameObject cube;
    public Transform player;
    public Vector3 hector;
    TouchPhase touchPhase = TouchPhase.Began; //teeheehee

    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            hector = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 0));
            player.position = new Vector3(hector.x,-3.78f,0);
        }
    }
}

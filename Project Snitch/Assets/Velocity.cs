using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour {
    public Rigidbody2D lechuga;
    public int maxvel;
	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (lechuga.velocity.y < maxvel)
        {
            Debug.Log("Lechuga asesina");
            lechuga.velocity = new Vector2(lechuga.velocity.x, maxvel);
        }
	}
}

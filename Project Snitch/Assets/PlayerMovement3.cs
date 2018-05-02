using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3 : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject cube;
    public Transform player;
    public int maxvel;
    public Vector3 hector;
    public Vector3 whereto;

    public bool direccion = true;
    public bool pelon = true;

    public int cuenta;

    void FixedUpdate()
    {
        if (rb.velocity.x > maxvel)
        {
            rb.velocity = new Vector2(maxvel, rb.velocity.y);
        }
        if (rb.velocity.x < -maxvel)
        {
            rb.velocity = new Vector2(-maxvel, rb.velocity.y) ;
        }
        cuenta = Input.touchCount;
        if (cuenta > 0)
        {
            Touch touch = (Input.GetTouch(0));
            if (pelon == true)
            {
                hector = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 10));
                pelon = false;
            }
            whereto = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 10));
            if (whereto.x > hector.x + 1)
            {
                whereto = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 10));
                direccion = true;
                pelon = true;
            }
            else if (whereto.x < hector.x - 1)
            {
                whereto = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 10));
                direccion = false;
                pelon = true;
            }
            if (direccion == false && (cube.transform.position.x > new Vector3(-2.4f, 0, 0).x && cuenta < 2))
            {
                Debug.Log("izquierda");
                rb.AddForce(new Vector2(-30f,0));
                //player.transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (direccion == true && (cube.transform.position.x < new Vector3(2.4f, 0, 0).x && cuenta < 2))
            {
                Debug.Log("derecha");
                rb.AddForce(new Vector2(30f, 0));
                //player.transform.localScale = new Vector3(1, 1, 1);
            }
        }

    }
}

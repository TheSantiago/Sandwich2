using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour {
    public Rigidbody2D lechuga;
    public int maxvel;
    public GameObject obgetolechuga;
    public GameObject plato;
    public bool womov=true;
	void FixedUpdate ()
    {
        if (womov == true)
        {
		if (lechuga.velocity.y < maxvel)
        {
            lechuga.velocity = new Vector2(lechuga.velocity.x, maxvel);
        }
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("Lechuga loca");
            Destroy(lechuga);
            womov = false;
            obgetolechuga.transform.position = new Vector3(collision.transform.position.x, obgetolechuga.transform.position.y, 0);
            collision.collider.enabled = false;
            obgetolechuga.transform.SetParent(collision.transform);
        }
        if (collision.gameObject.tag == "Comida")
        {
            Debug.Log("Lechuga loca");
            Destroy(lechuga);
            womov = false;
            obgetolechuga.transform.position = new Vector3(collision.transform.position.x, obgetolechuga.transform.position.y, 0);
            obgetolechuga.transform.SetParent(collision.transform);
            collision.gameObject.tag = "Ground";
        }
    }
}

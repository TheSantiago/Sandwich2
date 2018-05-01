using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject cube;
    public Transform player;
    public Vector3 hector;
    public Vector3 whereto;

    public bool direccion = true;
    public bool notouch = true;
    public bool pelon = true;

    public int cuenta;

    void FixedUpdate()
    {
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
            if (whereto.x < hector.x - 1)
            {
                whereto = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0, 10));
                direccion = false;
                pelon = true;
            }
            if (direccion == false && (cube.transform.position.x > new Vector3(-2.4f, 0, 0).x && cuenta < 2))
            {
                Debug.Log("izquierda");
                player.Translate(Vector3.left * Time.deltaTime * 3f);
            }
            else if (direccion == true && (cube.transform.position.x < new Vector3(2.4f, 0, 0).x && cuenta < 2))
            {
                Debug.Log("derecha");
                player.Translate(Vector3.right * Time.deltaTime * 3f);
            }
        }
    }

}

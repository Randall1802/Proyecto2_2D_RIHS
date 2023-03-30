using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrao : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D mi;
    // Start is called before the first frame update
    void Start()
    {
        mi=GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0, 0);
        }*/
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontal, 0) * Time.deltaTime * velocidad;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    int fullnumber;
    float floatnumber;

    public float speed; 

    public Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + floatnumber, transform.position.y, transform.position.z);
            transform.Translate(1 * Time.deltatime * speed, 0, 0);


            Debug.Log("D Pressed)");
        }
        if (input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x + floatnumber, transform.position.y, transform.position.z);
            transform.Translate(-1 * Time.deltatime * speed, 0, 0);


            Debug.Log("A Pressed)");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    int fullnumber;
    float floatnumber;
    public float speed; 
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            rigidbody.aAddForce(1 * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);

            //transform.position = new Vector3(transform.position.x + floatnumber, transform.position.y, transform.position.z);
            //transform.Translate(1 * Time.deltatime * speed, 0, 0);


            Debug.Log("D Pressed)");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.aAddForce(-1 * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);

            //transform.position = new Vector3(transform.position.x + floatnumber, transform.position.y, transform.position.z);
            //transform.Translate(-1 * Time.deltatime * speed, 0, 0);


            Debug.Log("A Pressed)");
        }
    }
}

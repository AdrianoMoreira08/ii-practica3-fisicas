using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej7 : MonoBehaviour
{
    public float speed = 1f;

    Transform sphere_tf;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
        sphere_tf = GameObject.Find("Sphere").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        direction = (sphere_tf.position - transform.position).normalized;
        transform.LookAt(sphere_tf.position, Vector3.up);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(direction * Input.GetAxis("Vertical") * speed * Time.deltaTime,
                                Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(direction * Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                                Space.World);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            sphere_tf.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            sphere_tf.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
        
    }
}

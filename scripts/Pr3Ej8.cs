using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej8 : MonoBehaviour
{
    public float sphere_speed = 2.5f;
    public float cube_speed = 1f;

    Transform sphere_tf;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        sphere_speed = 2.5f;
        cube_speed = 1f;
        sphere_tf = GameObject.Find("Sphere").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        direction = (sphere_tf.position - transform.position).normalized;
        transform.LookAt(sphere_tf.position, transform.up);
        transform.Translate(direction * cube_speed * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            sphere_tf.Translate(Vector3.forward * Input.GetAxis("Vertical") * sphere_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            sphere_tf.Translate(Vector3.right * Input.GetAxis("Horizontal") * sphere_speed * Time.deltaTime);
        }
        
    }
}

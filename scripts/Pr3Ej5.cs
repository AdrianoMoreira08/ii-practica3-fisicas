using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej5 : MonoBehaviour
{
    public float speed = 1f;

    Transform sphere_tf;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        sphere_tf = GameObject.Find("Sphere").transform; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            sphere_tf.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            sphere_tf.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
        
    }
}

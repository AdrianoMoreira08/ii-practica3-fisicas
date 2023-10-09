using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej12 : MonoBehaviour
{
    public float force = 0.1f;
    Transform sphere_tf;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        sphere_tf = GameObject.Find("Sphere").transform;
    }

    // Update is called once per frame
    void Update()
    {
        direction = sphere_tf.position - transform.position;
        GetComponent<Rigidbody>().AddForce(
            Vector3.forward * Input.GetAxis("Vertical2") * force, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddForce(
            Vector3.right * Input.GetAxis("Horizontal2") * force, ForceMode.Impulse);
        GetComponent<Rigidbody>().AddForce(
            direction * (Input.GetKey(KeyCode.H) ? 1 : 0));
    }
}

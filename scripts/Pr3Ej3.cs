using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1f, 0f, 0f);
    public float speed = 1.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        // moveDirection = new Vector3(1f, 0f, 0f);
        // speed = 1.1f;
        transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}

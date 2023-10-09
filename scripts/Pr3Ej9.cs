using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision object_name) {
        Debug.Log("Collision with " + object_name.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

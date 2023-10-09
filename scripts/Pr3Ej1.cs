using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pr3Ej1: MonoBehaviour
{
    public float velocity;
    float vertical_velocity;
    float horizontal_velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 2;
    }

    // Update is called once per frame
    void Update()
    {
        vertical_velocity = Input.GetAxis("Vertical") * velocity;
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("UpArrow: " + vertical_velocity);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("DownArrow: " + vertical_velocity);
        }

        horizontal_velocity = Input.GetAxis("Horizontal") * velocity;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("LeftArrow: " + horizontal_velocity);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("RightArrow: " + horizontal_velocity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 3f;//[SerializeField]
    public Transform baliza;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z >= baliza.position.z) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            transform.Rotate(new Vector3(0,90,0));
        }
    }
}

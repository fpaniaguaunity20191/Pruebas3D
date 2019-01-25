using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public GameObject drone;
    private Drone droneScript;
    
    private void Start() {
        droneScript = drone.GetComponent<Drone>();
    }

    private void OnTriggerEnter(Collider other) {
        droneScript.enabled = true;
    }

    private void OnTriggerExit(Collider other) {
        droneScript.enabled = false;
    }
}

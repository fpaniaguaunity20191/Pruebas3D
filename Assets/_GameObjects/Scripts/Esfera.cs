using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public GameObject drone;
    public Renderer renderer;
    private Drone droneScript;
    
    private void Start() {
        droneScript = drone.GetComponent<Drone>();
    }

    private void OnTriggerEnter(Collider other) {
        droneScript.enabled = true;
        renderer.material.SetColor("_Color", new Color(0f, 1f, 0f));
    }

    private void OnTriggerExit(Collider other) {
        droneScript.enabled = false;
        renderer.material.SetColor("_Color", new Color(1f, 0f, 0f));
    }
}

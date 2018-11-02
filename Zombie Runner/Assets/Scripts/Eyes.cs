using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {
    private Camera eyes;
    private float FOV;
	// Use this for initialization
	void Start () {
        eyes = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        OnButtonPress();
	}
    void OnButtonPress()
    {
        if (Input.GetButtonDown("Zoom")){
            eyes.fieldOfView /= 1.5f;
        }
        if (Input.GetButtonUp("Zoom"))
        {
            eyes.fieldOfView *= 1.5f;
        }
    }
}

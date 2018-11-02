using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dayscale : MonoBehaviour {
    [SerializeField] float timeScale = 60f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, timeScale * Time.deltaTime/360);
        transform.LookAt(Vector3.zero);
	}
}

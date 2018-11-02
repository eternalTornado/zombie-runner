using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAreaDetector : MonoBehaviour {
    [SerializeField] float timeInClearArea = 0f;
    
    bool calledHeli = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timeInClearArea += Time.deltaTime;
        //if (timeInClearArea > 5f)
            //Debug.Log("Found clear area");
	}
    void OnTriggerStay(Collider collider)
    {
        timeInClearArea = 0f;
    }
}

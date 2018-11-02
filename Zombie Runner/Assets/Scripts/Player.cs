using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] Transform spawns;
    [SerializeField] bool randomSpawn = true;
    //[SerializeField] AudioClip callHeli;
    Transform[] spawnPoints;

    Helicopter helicopter;
	// Use this for initialization
	void Start () {
        helicopter = FindObjectOfType<Helicopter>();
        spawnPoints = spawns.GetComponentsInChildren<Transform>(); 
        if (randomSpawn)
        {
            //Debug.Log(spawnPoints.Length);
            transform.position = spawnPoints[Random.Range(1, spawnPoints.Length)].position;
            randomSpawn = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        OnButtonPress();
	}
    void OnButtonPress()
    {
        if (Input.GetButtonDown("CallHeli"))
        {
            Transform currentPos = transform;
            helicopter.GetCalled(currentPos);
        }
    }
}

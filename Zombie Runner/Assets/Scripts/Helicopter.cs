using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    [SerializeField] AudioClip radio;
    //[SerializeField] Transform target;
    AudioSource[] audioSource;
	// Use this for initialization
	void Start () {
        audioSource = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        OnPressButton();
	}
    void OnPressButton()
    {
        if (Input.GetButtonDown("CallHeli"))
        {
            audioSource[1].clip = radio;
            audioSource[1].Play();
        }
    }
    public void GetCalled(Transform target)
    {
        StartCoroutine(Move(target));
    }
    IEnumerator Move(Transform target)
    {
        yield return StartCoroutine(GetToHeight(target));
        yield return StartCoroutine(GetToPos(target));
        yield return StartCoroutine(GetDown(target));
    }
    IEnumerator GetToHeight(Transform target)
    {
        Debug.Log("Get to height started");
        while(transform.position.y < 150f)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(transform.position.x, 150f, transform.position.z),
                10f * Time.deltaTime);
            yield return null;
        }

    }
    IEnumerator GetToPos(Transform target)
    {
        Debug.Log("Get to Pos started");
        Vector3 targetWithHeight = new Vector3(target.transform.position.x, 150f, target.transform.position.z);
        while(transform.position != targetWithHeight)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetWithHeight, 10f * Time.deltaTime);
            yield return null;
        }
        //yield return StartCoroutine(GetDown(target));

    }
    IEnumerator GetDown(Transform target)
    {
        Debug.Log("Get Down started");
        while(transform.position.y != target.transform.position.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 5f * Time.deltaTime);
            yield return null;
        }
        //yield return new WaitForSeconds(1f);
    }
}

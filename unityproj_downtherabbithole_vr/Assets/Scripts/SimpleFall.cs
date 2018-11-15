using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFall : MonoBehaviour {

    [Range(-3.0f, 3.0f)]
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Vector3.up * Time.deltaTime, Space.World);

    }
}

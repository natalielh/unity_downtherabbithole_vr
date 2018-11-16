using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour {

    [Range(-40.0f, 40.0f)]
    public float degrees_per_second;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Rotate the object around its local Y axis at speed degrees per second
        transform.Rotate(degrees_per_second * Vector3.up * Time.deltaTime);

    }
}

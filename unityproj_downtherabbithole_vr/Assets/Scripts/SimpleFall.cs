using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFall : MonoBehaviour {

    //NOTE: "ideal" VR fall speed is -0.15
    [Range(-3.0f, 0.0f)]
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Vector3.up * Time.deltaTime, Space.World);

    }
}

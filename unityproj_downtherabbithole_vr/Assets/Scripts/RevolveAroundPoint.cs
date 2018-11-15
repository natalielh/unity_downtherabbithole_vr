using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAroundPoint : MonoBehaviour {

    [Range(-3.0f, 3.0f)]
    public float speed;

    public Vector3 point;

    // Use this for initialization
    void Start () {

        point = new Vector3(0,0,0);

	}
	
	// Update is called once per frame
	void Update () {
		


	}
}

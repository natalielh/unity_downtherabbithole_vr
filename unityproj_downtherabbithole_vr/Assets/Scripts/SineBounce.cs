using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineBounce : MonoBehaviour {

    //adjust this to change speed
    //1.0f
    [Range(0.0f, 5.0f)]
    public float speed;

    //adjust this to change how high it goes
    //0.05f
    [Range(0.0f, 0.1f)]
    public float height;

    //public float origY;

    // Use this for initialization
    void Start () {
        //origY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        ////get the objects current position and put it in a variable so we can access it later with less code
        //Vector3 pos = new Vector3();
        //pos = transform.position;

        ////calculate what the new Y position will be
        //float newY = height * Mathf.Sin(Time.time * speed);

        ////set the object's Y to the new calculated Y
        //transform.position = new Vector3(pos.x, newY, pos.z);

        ////this is working, but origY may need to change due to object being picked up
        //float newY = height * Mathf.Sin(Time.time * speed);
        //transform.position = new Vector3(transform.position.x, origY + newY, transform.position.z);

        transform.Translate(Vector3.up * height * Mathf.Sin(Time.time * speed));

    }
}

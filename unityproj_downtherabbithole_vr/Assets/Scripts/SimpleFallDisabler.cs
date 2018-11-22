﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFallDisabler : MonoBehaviour {

    public GameObject player_transform_input;

    private bool passed = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!passed && player_transform_input.transform.position.y <= this.transform.position.y)
        {

            player_transform_input.GetComponent<SimpleFall>().enabled = false;

            // set flag to true
            passed = true;
        }

    }
}

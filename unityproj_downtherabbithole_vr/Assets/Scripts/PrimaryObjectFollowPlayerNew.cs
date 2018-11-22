using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryObjectFollowPlayerNew : MonoBehaviour {

    public GameObject player_transform_input;
    //public GameObject new_parent_after_event;

    // flag indicating whether or not the event has happened
    private bool passed = false;

    public readonly float seconds = 5.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(!passed && player_transform_input.transform.position.y <= this.transform.position.y){
        
            this.transform.parent = player_transform_input.transform;

            Invoke("ChangeParentToNull", seconds);

            passed = true;
        }

	}

    void ChangeParentToNull(){
        this.transform.parent = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryObjectFollowPlayerNew : MonoBehaviour {

    public GameObject player_transform_input;
    //public GameObject new_parent_after_event;

    // flag indicating whether or not the event has happened
    private bool passed = false;

    // number of seconds that the object will follow player
    [Range(0.0f, 60.0f)]
    public float seconds = 10.0f;

    Transform parent_original_transform;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(!passed && player_transform_input.transform.position.y <= this.transform.position.y){

            // save the original parent transform so we can revert later
            parent_original_transform = this.transform.parent;
            this.transform.parent = player_transform_input.transform;

            Invoke("ChangeParentToOriginal", seconds);

            // set flag to true
            passed = true;
        }

	}

    void ChangeParentToOriginal(){
        //revert
        this.transform.parent = parent_original_transform;
    }
}

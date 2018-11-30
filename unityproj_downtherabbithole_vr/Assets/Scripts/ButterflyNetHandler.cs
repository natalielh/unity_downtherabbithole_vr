using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyNetHandler : MonoBehaviour {

    // recorded number of caught butterflies
    public int caught_butterflies = 0;
    // please assign the 'net collider' to collider_catching; this collider is what detects if the net is catching a butterfly
    public Collider collider_catching;
    // where the center of 'caught' butterflies will be placed; take in the transform data (THIS WILL BE THE PARENT)
    public GameObject center_placement;
    // prefab for caught butterflies that are still and do not have a collider
    public GameObject prefab_caught_butterfly;
    // max distance away from the center_placement point the 'caught' butterfly will be instantiated in the net area
    [Range(0.01f, 0.5f)]
    public float max_spawn_radius;

	// Use this for initialization
	void Start () {
        // upon loading game, # of caught butterflies is ALWAYS reset back to 0
        caught_butterflies = 0;
	}

    private void OnTriggerEnter(Collider other)
    {
        // if the other collider this butterfly net is colliding with is an actual butterfly collider
        if(other.gameObject.tag.Equals("Butterfly")){
            // increase the caught butterfly counters by 1
            caught_butterflies++;

            PlaceOneCaughtInNet();

            other.gameObject.SetActive(false);
        }
    }

    private void PlaceOneCaughtInNet(){
        // create new clone gameobject and instantitate
        GameObject clone_butterfly;

        // create transform coordinates to be set
        Vector3 new_local_coordinates = new Vector3();
        new_local_coordinates = (max_spawn_radius * Random.insideUnitSphere);

        //Transform new_local_transform = new Transform;
        //new_local_transform.position = new_local_coordinates;

        // Instantiate(Object original, Vector3 position, Quaternion rotation);
        clone_butterfly = Instantiate(prefab_caught_butterfly);

        // move this object so it's a child of the butterfly net object (SET PARENT)
        clone_butterfly.transform.parent = center_placement.transform;
        // set new local transform
        clone_butterfly.transform.localPosition = new_local_coordinates;
    }


}

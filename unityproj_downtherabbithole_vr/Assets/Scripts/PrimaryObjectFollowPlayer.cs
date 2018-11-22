using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryObjectFollowPlayer : MonoBehaviour {

    public GameObject player_transform_input;
    //public GameObject[] primary_objects;
    public List<GameObject> primary_objects;

    public int objects_met = 0;

    public float seconds;

    //private bool is_coroutine_executing = false;
    //private readonly float detection_threshold = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < primary_objects.Count; i++){

            if(player_transform_input.transform.position.y <= primary_objects[i].transform.position.y)
            {

            }
        }

	}

    //void CheckForObject(int array_index){
    //    if (player_transform_input.transform.position.y <= primary_objects[array_index].transform.position.y)
    //    {

    //    }
    //}

    void ChangeParent(GameObject game_object, GameObject target_parent) {

        game_object.transform.parent = target_parent.transform;

    }

    //IEnumerator ExecuteAfterTime(float time) {

    //    if (is_coroutine_executing)
    //        yield break;

    //    is_coroutine_executing = true;

    //    yield return new WaitForSeconds(time);

    //    // Code to execute after the delay


    //    is_coroutine_executing = false;
    //}



}

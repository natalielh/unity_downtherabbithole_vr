using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterTime : MonoBehaviour {


	public float delayBeforeLoading= 10f;

	public string sceneName;
	public float timeElapsed;





	// Update is called once per frame
	public void Update () {
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= delayBeforeLoading) {
		
			SceneManager.LoadScene (sceneName);
		}
	}
}

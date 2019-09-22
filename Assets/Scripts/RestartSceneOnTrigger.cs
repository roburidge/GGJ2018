using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{    
		string currentSceneName = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene (currentSceneName);
		Debug.Log ("FPSController has entered Collider");     
	}
}
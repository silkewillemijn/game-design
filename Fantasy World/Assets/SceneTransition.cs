using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
	public string nextLevel;
	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene(nextLevel); // Change Scene
	}



}
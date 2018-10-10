using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transitions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToHistory()
	{
		SceneManager.LoadScene ("History1940_1970_Website/HistoryProjectGP5");
	}
	public void GoToEnglish()
	{
		SceneManager.LoadScene ("EnglishReview/EnglishReviewProject");
	}

}

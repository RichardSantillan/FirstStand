using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void BeginGame() {
		SceneManager.LoadScene("main");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

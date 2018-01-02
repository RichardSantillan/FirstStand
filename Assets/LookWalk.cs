using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWalk : MonoBehaviour {

	public Transform vrCamera;
	public float toggleAngle = 15.0f;
	public float speed = .75f;
	public bool moveForward;
	private CharacterController cc;

	// Use this for initialization
	void Start () {
		vrCamera = Camera.main.transform;
		GameObject.FindGameObjectWithTag ("Player").transform.position = new Vector3(0,.6f,0);

		cc = vrCamera.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
			//Debug.Log ("Walking");
			moveForward = true;
		} else {
			moveForward = false;
		}

		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			Debug.Log ("Walking");
			GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().SimpleMove (forward * speed);
		}
	}
}

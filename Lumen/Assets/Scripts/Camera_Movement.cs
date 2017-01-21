using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

	public GameObject otherGameObject;

//	private float runSpeed;
	private Player_Movement script;
	private Camera mainCam;
	private Vector3 playerView;

	//This runs once on game start
	void Awake ()
	{
		script = otherGameObject.GetComponent<Player_Movement>();
		mainCam = Camera.main;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		playerView = new Vector3 (script.transform.position.x, script.transform.position.y, -10.0f);
		mainCam.transform.position = playerView;
		//Vector3 position = this.transform.position;
		//print (script.transform.position.x);
		//print (position.x);
		//print (mainCam.transform.position.x);
		//position = new Vector3 (script.transform.position.x, script.transform.position.y, script.transform.position.z);
//		if (Input.GetKey ("w")) {
//			transform.position += Vector3.up * script.speed * runSpeed * Time.deltaTime;
//		}
//		if (Input.GetKey("a")) {
//			transform.position += Vector3.left * script.speed * runSpeed * Time.deltaTime;
//		}
//		if (Input.GetKey ("s")) {
//			transform.position += Vector3.down * script.speed * runSpeed * Time.deltaTime;
//		}
//		if (Input.GetKey ("d")) {
//			transform.position += Vector3.right * script.speed * runSpeed * Time.deltaTime;
//		}
//		if (Input.GetKey (KeyCode.LeftShift)) {
//			runSpeed = script.runSpeedMultiplier;
//		} else {
//			runSpeed = 1;
//		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour {

	public GameObject otherGameObject;

	private float runSpeed;
	private Player_Movement script;

	//This runs once on game start
	void Awake ()
	{
		script = otherGameObject.GetComponent<Player_Movement>();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		if (Input.GetKey ("w")) {
			transform.position += Vector3.up * script.speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey("a")) {
			transform.position += Vector3.left * script.speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			transform.position += Vector3.down * script.speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			transform.position += Vector3.right * script.speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			runSpeed = script.runSpeedMultiplier;
		} else {
			runSpeed = 1;
		}
	}
}

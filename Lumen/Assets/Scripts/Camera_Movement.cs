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
	}
}

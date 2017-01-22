using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicLight2D;

public class Flashlight : MonoBehaviour {

	public GameObject otherGameObject;

	private DynamicLight2D.DynamicLight light;
	private bool lightOn;
	private Player_Movement script;
	private Vector3 playerView;
	// Use this for initialization
	void Start () {
		light = GameObject.Find("2DLight").GetComponent<DynamicLight> () as DynamicLight;
		script = otherGameObject.GetComponent<Player_Movement>();
	}
	
	// Update is called once per frame
	void Update () {

		playerView = new Vector3 (script.transform.position.x, script.transform.position.y + 5.0f, 0.0f);
		this.transform.position = playerView;

		if (Input.GetKeyDown (KeyCode.Space)) {
			print ("Space!");
			if (light) {
				lightOn = !lightOn;
				light.GetComponent<Renderer>().gameObject.SetActive(lightOn);
				print ("Light on!");
			}
		}

		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10f);
		float angle = AngleBetweenPoints (transform.position, mouseWorldPosition);
		transform.rotation = Quaternion.Euler (new Vector3 (0f, 0f, angle + 90.0f));
	}

	float AngleBetweenPoints (Vector2 a, Vector2 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}

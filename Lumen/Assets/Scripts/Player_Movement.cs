using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DynamicLight2D;


public class Player_Movement : MonoBehaviour {
	public float speed;
	public float runSpeedMultiplier;
	private float runSpeed;
//	private DynamicLight2D.DynamicLight light;
//	private bool lightOn;
	// Use this for initialization
	void Start () {
//		light = GameObject.Find("2DLight").GetComponent<DynamicLight> () as DynamicLight;
	}

	// Update is called once per frame
	void Update () {
		Vector3 position = this.transform.position;
		if (Input.GetKey ("w")) {
			transform.position += Vector3.up * speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey("a")) {
			transform.position += Vector3.left * speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			transform.position += Vector3.down * speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			transform.position += Vector3.right * speed * runSpeed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftShift)) {
			runSpeed = runSpeedMultiplier;
		} else {
			runSpeed = 1;
		}
//		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10f);
//		float angle = AngleBetweenPoints (transform.position, mouseWorldPosition);
//		transform.rotation = Quaternion.Euler (new Vector3 (0f, 0f, angle));
	}
//	float AngleBetweenPoints (Vector2 a, Vector2 b) {
//		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
//	}
}
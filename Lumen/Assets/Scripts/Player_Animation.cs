using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10f);
		float angle = AngleBetweenPoints (transform.position, mouseWorldPosition);

		if (angle > -22.5 && angle < 22.5) {
			anim.SetBool ("is_up", false);
			anim.SetBool ("is_right", false);
			anim.SetBool ("is_down", false);
			anim.SetBool ("is_left", true);
		} else if (angle > 22.5 && angle < 67.5) {
			anim.SetBool ("is_up", false);
			anim.SetBool ("is_right", false);
			anim.SetBool ("is_down", true);
			anim.SetBool ("is_left", true);
		} else if (angle > 67.5 && angle < 112.5) {
			anim.SetBool ("is_up", false);
			anim.SetBool ("is_right", false);
			anim.SetBool ("is_down", true);
			anim.SetBool ("is_left", false);
		} else if (angle > 112.5 && angle < 157.5) {
			anim.SetBool ("is_up", false);
			anim.SetBool ("is_right", true);
			anim.SetBool ("is_down", true);
			anim.SetBool ("is_left", false);
		} else if (angle > 157.5 && angle < 180 || angle < -157.5 && angle > -180) {
			anim.SetBool ("is_up", false);
			anim.SetBool ("is_right", true);
			anim.SetBool ("is_down", false);
			anim.SetBool ("is_left", true);
		} else if (angle > -157.5 && angle < -112.5) {
			anim.SetBool ("is_up", true);
			anim.SetBool ("is_right", true);
			anim.SetBool ("is_down", false);
			anim.SetBool ("is_left", false);
		} else if (angle > -112.5 && angle < -67.5) {
			anim.SetBool ("is_up", true);
			anim.SetBool ("is_right", false);
			anim.SetBool ("is_down", false);
			anim.SetBool ("is_left", false);
		} else if (angle > -67.5 && angle < -22.5) {
			anim.SetBool ("is_up", true);
			anim.SetBool ("is_right", false);
			anim.SetBool ("is_down", false);
			anim.SetBool ("is_left", true);
		}

	}

	float AngleBetweenPoints (Vector2 a, Vector2 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}

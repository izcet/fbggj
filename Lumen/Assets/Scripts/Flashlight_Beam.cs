using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Beam : MonoBehaviour {

	private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition + Vector3.forward * 10f);
//		float angle = AngleBetweenPoints (transform.position, mouseWorldPosition);
//		print (angle);
//		if (angle > -112.5 && angle < -67.5)
//			sprite.sortingOrder = 1;
//		else
//			sprite.sortingOrder = 2;
	}

//	float AngleBetweenPoints (Vector2 a, Vector2 b) {
//		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
//	}
}

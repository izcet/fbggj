using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			print ("Left Timer");
		}
	}

	public SphereCollider myCollider;
	// Use this for initialization
	void Start () {
		myCollider = transform.GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		myCollider.radius -= 0.05f;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A)) {
			transform.Translate(-Vector3.right * Time.deltaTime * speed);
		}

		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right * Time.deltaTime * speed);
		}

		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.up * Time.deltaTime * speed);
		}

		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(-Vector3.up * Time.deltaTime * speed);
		}
	}
}

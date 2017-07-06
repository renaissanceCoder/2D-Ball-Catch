using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public float speed = 5f;
	public GameManager manager;
	public int basicScore = 1;
	public int specialScore = 5;
	Vector3 screenHeight;
	float currentScreenHeight;
	float scoreMultiplierRatio = 4;
	float maxScoreMultiplier;

	// Use this for initialization
	void Start () {
		screenHeight = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));		
        currentScreenHeight = screenHeight.y;            
        maxScoreMultiplier = currentScreenHeight / scoreMultiplierRatio;
        manager = (GameManager) FindObjectOfType(typeof(GameManager));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-Vector3.up * Time.deltaTime * speed);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "catcher") {
			if(transform.position.y > maxScoreMultiplier) {
				manager.IncreaseScore(basicScore);
			} else {
				manager.IncreaseScore(specialScore);
			}			

			Destroy(this.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject spawnee;
	public bool stopSpawning;
	public float spawnTime;
	public float spawnDelay;
	int screenWidth;
	int screenHeight;
	Vector3 screenToWorldPos;

	public Text scoreRef;
	int score;


	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnBall", spawnTime, spawnDelay);
	}
	
	public void SpawnBall() {
		Instantiate(spawnee, RandomPosition(), transform.rotation);
	}

	Vector3 RandomPosition() {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		screenToWorldPos = Camera.main.ScreenToWorldPoint(
			new Vector3(Random.Range(0, screenWidth), screenHeight, 1));
		return screenToWorldPos;
	}

	public void IncreaseScore(int reward) {
		score += reward;
		scoreRef.text = "Score " + score.ToString();
	}
}
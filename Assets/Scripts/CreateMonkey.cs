using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonkey : MonoBehaviour {

	// Create 1 empty object on left and 1 empty object on right
	// Attach CreateMonkey script on each
	// Change startTime to 2 for the one on the right
	public GameObject Monkey;
	public int startTime = 3;
	public float waitTime = 2f;
	private float InstantiationTimer;

	void Start () {

		InstantiationTimer = waitTime;
	}

	void Update () {

		CreatePrefab();
	}

	void CreatePrefab() {

		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0 && Time.time > startTime)
		{
			GameObject monkeyCopy = Instantiate(Monkey, transform.position, Quaternion.identity) as GameObject;
			monkeyCopy.SetActive (true);
			InstantiationTimer = waitTime;
		}
	}
}

﻿using UnityEngine;

public class CameraController : MonoBehaviour {

	public PlayerController player;

	private Vector3 lastPlayerPosition;
	private float distFromPlayer;

	void Start () {
		player = FindObjectOfType<PlayerController>();
		lastPlayerPosition = player.transform.position;
	}

	void Update () {
		distFromPlayer = player.transform.position.x - lastPlayerPosition.x;

		transform.position = new Vector3(transform.position.x + distFromPlayer, transform.position.y, transform.position.z);

		lastPlayerPosition = player.transform.position;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform Player;
	private Vector3 cameraOffset;

	private void Start()
	{
		cameraOffset = GetComponent<Transform>().position - Player.position;
	}

	private void Update()
	{
		GetComponent<Transform>().position = Player.position + cameraOffset;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;

	public void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void FixedUpdate()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		rb.AddForce(x * 5, 0, z * 5);

		if (rb.transform.position.y < 0.6 && Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce(0, 3, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.X)) {
			rb.velocity = new Vector3(0, rb.velocity.y, 0);
		}
	}
}
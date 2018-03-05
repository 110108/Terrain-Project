using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {

	public GameObject player;
	public Rigidbody rb;

	private Vector3 offset;
	private float tilt=2.0f;

	// Use this for initialization
	void Start () {
		offset=transform.position-player.transform.position;
		rb=player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		if (player != null) {
			transform.position = player.transform.position + offset;
			rb.rotation = Quaternion.Euler (rb.velocity.y * -tilt,-(rb.velocity.x * -tilt)/2 , rb.velocity.x * -tilt);
			transform.rotation = rb.rotation;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_view_toggle : MonoBehaviour {

	public GameObject v1;
	public GameObject v3;
	public Vector3 start;

	// Use this for initialization
	void Start () {
		start = (0.0f , 0.0f , 0.0f);
		v1.transform = start;
		v3.transform = start;
		v3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

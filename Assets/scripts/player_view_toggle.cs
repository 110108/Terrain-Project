using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_view_toggle : MonoBehaviour {

	public GameObject v1;
	public GameObject v3;
	public Vector3 start;

	private int gamestate;

	// Use this for initialization
	void Start () {
		start = new Vector3( 81.0f , 1.2f ,55.0f );
		v1.transform.position = start;
		v3.transform.position = start;
		v3.SetActive(false);
		gamestate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (gamestate == 0 || gamestate == 1) {
			if (Input.GetKeyDown (KeyCode.R))
			{
				if (gamestate == 0) {
					v3.SetActive (true);
					v1.SetActive (false);
					gamestate = 1;
				}
				if (gamestate == 1) {
					v1.SetActive (true);
					v3.SetActive (false);
					gamestate = 0;
				}
			}
		} 
	}
}

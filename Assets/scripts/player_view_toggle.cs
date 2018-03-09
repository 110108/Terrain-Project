using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_view_toggle : MonoBehaviour {
	public GameObject firstPersonCamera;
	public GameObject overheadCamera;

	public void ShowOverheadView() {
		firstPersonCamera.SetActive(false);
		overheadCamera.SetActive(true);
	}

	public void ShowFirstPersonView() {
		firstPersonCamera.SetActive(true);
		overheadCamera.SetActive(false);
	}

	public GameObject v1;
	public GameObject v3;
	public Vector3 start;

	private int gamestate;

	// Use this for initialization
	void Start () {
		start = new Vector3( 81.0f , 2.0f ,55.0f );
		v1.transform.position = start;
		v3.transform.position = start;
		v3.SetActive(false);
		gamestate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (gamestate == 0 || gamestate == 1) {
			if (Input.GetKeyDown (KeyCode.T))
			{
				if (gamestate == 0) {
					ShowOverheadView();
					gamestate = 1;
				}
				if (gamestate == 1) {
					ShowFirstPersonView();
					gamestate = 0;
				}
			}
		} 
	}
}

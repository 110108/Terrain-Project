using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_view_toggle : MonoBehaviour {
	public GameObject firstPersonCamera;
	public GameObject overheadCamera;

	public void ShowOverheadView() {
		overheadCamera.SetActive(true);
		firstPersonCamera.SetActive(false);
	}

	public void ShowFirstPersonView() {
		firstPersonCamera.SetActive(true);
		overheadCamera.SetActive(false);
	}

	public GameObject v1;
	public GameObject v3;
	public Vector3 start;

	private bool threep;

	// Use this for initialization
	void Start () {
		start = new Vector3( 81.0f , 2.0f ,55.0f );
		v1.transform.position = start;
		v3.transform.position = start;
		v3.SetActive(false);
		threep = false;
	}

	// Update is called once per frame
	void Update () {
		if (threep==false) {
				v3.transform.position=v1.transform.position;
			}
		if (threep==true) {
				v1.transform.position=v3.transform.position;
			}
			if (Input.GetKeyDown(KeyCode.T))
			{
			v3.SetActive (!v3.activeSelf);
			v1.SetActive (!v1.activeSelf);
			threep = !threep;
			}
		}
}


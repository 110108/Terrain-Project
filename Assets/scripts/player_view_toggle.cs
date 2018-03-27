using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_view_toggle : MonoBehaviour {

	public GameObject v1;
	public GameObject v3;
	public GameObject parent;
	public Vector3 start;

	private bool threep;

	// Use this for initialization
	void Start () {
		v1.transform.localPosition = start;
		v3.transform.localPosition = start;
		v3.SetActive(false);
		threep = false;
	}

	void OnTriggerEnter (Collider other){
		if(other.gameObject.CompareTag("pickup")){
			other.gameObject.SetActive(false);
//			count++;
//			SetCountText();
		}
	}

	// Update is called once per frame
	void Update () {
		if (threep==false) {
			parent.transform.position=v1.transform.position;
			v1.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);	
		}
		if (threep==true) {
			parent.transform.position=v3.transform.position;
			v3.transform.localPosition = new Vector3 (0.0f, 0.0f, 0.0f);
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
		v3.SetActive (!v3.activeSelf);
		v1.SetActive (!v1.activeSelf);
		threep = !threep;
		}
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remover : MonoBehaviour {
	void OnTriggerEnter (Collider other){
		if(other.gameObject.CompareTag("pickup")){
			other.gameObject.SetActive(false);
		}
	}
}

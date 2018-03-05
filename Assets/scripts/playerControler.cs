using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControler : MonoBehaviour {
	
	public float speed;
	public float jumpforce;
	public bool isGrounded;
	public Text countText;
	public Rigidbody rb;
	
	private int count;
	private float tilt=1.0f;
	private Vector3 reset;
	
	void Start ()
	{
		rb=GetComponent<Rigidbody>();
		//count=0;
		reset=transform.position;
		//SetCountText();
	}
//	
//	void OnTriggerEnter (Collider other){
//		if(other.gameObject.CompareTag("pickup")){
//            		other.gameObject.SetActive(false);
//			count++;
//			SetCountText();
//		}
//	}
//	
//	void SetCountText(){
//		countText.text="Count: "+count.ToString ();
//		if(count>=20){
//			//win
//		}
//	}
	
	void FixedUpdate () 
	{
		//debug.DrawRay
		
		isGrounded=Physics.Raycast(transform.position,Vector3.down,0.5f);
		if(Input.GetKey(KeyCode.Space)&&isGrounded==true){
			rb.AddForce(0,jumpforce,0);
		}
		
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");
		Vector3 movement=new Vector3 (moveHorizontal,0.0f,moveVertical);
		rb.AddForce(movement*speed);
		
		rb.rotation = Quaternion.Euler (rb.velocity.y,-(rb.velocity.x * -tilt)/2 , rb.velocity.x * -tilt);

	}
}

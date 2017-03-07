using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFOScript : MonoBehaviour {

	public Transform myTransform;
	public Text ScoreText;
	private float speed = 10f;
	private float forceValue = 10f;
	private Rigidbody2D myRigid;
	private int score = 0;

	// Use this for initialization
	void Start () {
		myTransform = this.GetComponent<Transform>();
		myRigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKey(KeyCode.W))
//			myTransform.position = myTransform.position + Vector3.up*speed*Time.deltaTime;
//		if (Input.GetKey(KeyCode.S))
//			myTransform.position = myTransform.position + Vector3.down*speed*Time.deltaTime;
//		if (Input.GetKey(KeyCode.D))
//			myTransform.position = myTransform.position + Vector3.right*speed*Time.deltaTime;
//		if (Input.GetKey(KeyCode.A))
//			myTransform.position = myTransform.position + Vector3.left*speed*Time.deltaTime;
		if (Input.GetKey(KeyCode.W))
			myRigid.AddForce( Vector2.up*forceValue);
		if (Input.GetKey(KeyCode.S))
			myRigid.AddForce( Vector2.down*forceValue);
		if (Input.GetKey(KeyCode.D))
			myRigid.AddForce( Vector2.right*forceValue);
		if (Input.GetKey(KeyCode.A))
			myRigid.AddForce( Vector2.left*forceValue);
	
	}

	void OnTriggerEnter2D (Collider2D other){
		other.gameObject.SetActive(false);
		score += 1;
		ScoreText.text = "Score: " + score.ToString(); 
	}
}

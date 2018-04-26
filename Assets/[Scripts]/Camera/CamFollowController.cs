using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowController : MonoBehaviour {

	private Vector2 mousePos;
	private float yPos;
	public float speed = 2;
	public float maxHeight;
	public float minHeight;

	void Start () {
		yPos = transform.position.y;
		mousePos.y = Input.mousePosition.y;
	}
	
	void Update () {

		transform.position = new Vector3 (transform.position.x, yPos, transform.position.z);

		//mousePos.x = Input.mousePosition.x;

		if (Input.mousePosition.y < mousePos.y){
			yPos-=speed;
			mousePos.y = Input.mousePosition.y;
		} else if (Input.mousePosition.y > mousePos.y){
			yPos+=speed;
			mousePos.y = Input.mousePosition.y;
		}

		if (yPos > maxHeight){
			yPos = maxHeight;
		}
		if (yPos < minHeight){
			yPos = minHeight;
		}
		/*
		if (transform.position.y > maxHeight){
			transform.position = new Vector3 (transform.position.x, maxHeight, transform.position.z);
		}
		if (transform.position.y <minHeight){
			transform.position = new Vector3 (transform.position.x, minHeight, transform.position.z);
		}*/
	}
}

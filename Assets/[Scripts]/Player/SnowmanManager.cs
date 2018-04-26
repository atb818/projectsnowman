using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanManager : MonoBehaviour {

	public GameObject snowman;


	void Start () {
		GameObject clone;
		clone = Instantiate(snowman, transform.position, transform.rotation) as GameObject;
		clone.SendMessage("FollowMe", this.gameObject);
	}
	
	void Update () {
		
	}
}

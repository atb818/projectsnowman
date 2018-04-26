using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanFollow : MonoBehaviour {

	public GameObject target;
	Transform tTrans;

	void Start () {
		
	}
	
	void Update () {
		if (target != null){
			transform.position = new Vector3 (tTrans.position.x, tTrans.position.y, tTrans.position.z);
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, tTrans.eulerAngles.y, transform.eulerAngles.z);
		}
	}

	void FollowMe (GameObject t){
		target = t;
		tTrans = target.GetComponent<Transform>();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOverTime : MonoBehaviour {

	public int lifespan;

	void Start () {
		Destroy(gameObject, lifespan);
	}
	
	void Update () {
		
	}
}

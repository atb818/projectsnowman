using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballHit : MonoBehaviour {

	ParticleSystem p_system;
	public GameObject sb_particle;

	void Start () {
		StartCoroutine("ColliderDelay");
		p_system = sb_particle.GetComponent<ParticleSystem>();

	}
	
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		Debug.Log("Snowball Hit");
        ParticleSystem clone;
        clone = Instantiate(p_system, transform.position, transform.rotation) as ParticleSystem;
        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
		Destroy(this.gameObject,1);
	}

	IEnumerator ColliderDelay(){
		GetComponent<Collider>().enabled = false;
		yield return new WaitForSeconds(.5f);
		GetComponent<Collider>().enabled = true;
	}

}

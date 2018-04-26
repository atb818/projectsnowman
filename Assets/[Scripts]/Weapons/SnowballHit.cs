using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballHit : MonoBehaviour {

	ParticleSystem p_system;
	public GameObject sb_particle;

	void Start () {
		p_system = sb_particle.GetComponent<ParticleSystem>();
	}
	
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
        ParticleSystem clone;
        clone = Instantiate(p_system, transform.position, transform.rotation) as ParticleSystem;
		Destroy(this.gameObject);
	}

}

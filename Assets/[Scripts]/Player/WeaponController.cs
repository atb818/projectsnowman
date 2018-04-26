using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

	Rigidbody projectile;
	public GameObject snowball;
	public GameObject carrot;

	Transform spawn;
	public Transform sb_spawn;
	public Transform car_spawn;

	int speed;
	public int snowballSpeed;
	public int carrotSpeed;
	int newXAng;

	public GameObject myCam;

	bool canZoom = false;
	public GameObject tppCam;
	public GameObject fppCam;


	void Start () {
		projectile = snowball.GetComponent<Rigidbody>();
		speed = snowballSpeed;
		spawn = sb_spawn;
		newXAng = 0;
	}
	
	void Update () {
		WeaponManager();
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			Shoot();
		}
		if (canZoom){
			if (Input.GetKey(KeyCode.Mouse1)){
				tppCam.GetComponent<Camera>().enabled = false;
				fppCam.GetComponent<Camera>().enabled = true;
			}
			if (Input.GetKeyUp(KeyCode.Mouse1)){
				tppCam.GetComponent<Camera>().enabled = true;
				fppCam.GetComponent<Camera>().enabled = false;
			}
		}
	}

	void Shoot () {
            Rigidbody clone;
            clone = Instantiate(projectile, spawn.transform.position, Quaternion.Euler(myCam.transform.eulerAngles.x + newXAng, myCam.transform.eulerAngles.y, myCam.transform.eulerAngles.z)) as Rigidbody;
            //clone.velocity = transform.TransformDirection(Vector3.forward * speed);
            clone.AddForce(transform.forward * speed);
            Debug.Log("pew");
	}

	void WeaponManager () {
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			canZoom = false;
			spawn = sb_spawn;
			projectile = snowball.GetComponent<Rigidbody>();
			speed = snowballSpeed;
			newXAng = 0;
		}
		if (Input.GetKeyDown(KeyCode.Alpha2)){
			canZoom = true;
			spawn = car_spawn;
			projectile = carrot.GetComponent<Rigidbody>();
			speed = carrotSpeed;
			newXAng = 90;
		}
	}
}

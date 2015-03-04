using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	

	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "Enemy")
			Destroy(other.gameObject);
		Debug.Log ("Hit " + other.gameObject.name);
		gameObject.SetActive (false);

	}
}

using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	

	void OnCollisionEnter(Collision other){

		Debug.Log ("Hit " + other.gameObject.name);
		if(other.gameObject.tag == "Enemy")
			Destroy(other.gameObject);

		gameObject.SetActive (false);

	}
}

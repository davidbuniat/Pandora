using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	

	void OnCollisionEnter(Collision other){

		Debug.Log ("Hit " + other.gameObject.name);
		gameObject.SetActive (false);

	}
}

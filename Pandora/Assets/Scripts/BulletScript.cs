using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	

	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "Enemy")
			Destroy(other.gameObject);
		Debug.Log ("Hit " + other.gameObject.name);
		Debug.Log(other.transform.tag);
		if(other.transform.CompareTag("Enemy")){
			Destroy(other.gameObject);
		}
		gameObject.SetActive (false);

	}
}

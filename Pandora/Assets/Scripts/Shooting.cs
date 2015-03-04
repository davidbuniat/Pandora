using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Shooting : MonoBehaviour {
	
	GameObject spawn;
	public GameObject bulletPrefab;
	// Use this for initialization
	private List <GameObject> bullets = new List<GameObject>();
	public float force = 10f; 
	
	public float timeBetweenBullets = 0.1f;
	
	float GunEffectsTimer;
	ParticleSystem gunParticles;
	Light gunLight;
	float effectsDisplayTime = 0.2f;
	
	
	void Awake () {
		
		gunParticles = GetComponent<ParticleSystem> ();
		gunLight = GetComponent<Light> ();
		
		for (int i = 0; i < 20; i++) {
			
			GameObject localBullet = (GameObject)Instantiate(bulletPrefab);
			localBullet.SetActive(false);
			bullets.Add(localBullet);
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GunEffectsTimer += Time.deltaTime;
		
		if (Input.GetMouseButtonDown (0) && GunEffectsTimer >= timeBetweenBullets && Time.timeScale != 0)
			ShootingEffects ();
		if(GunEffectsTimer >= timeBetweenBullets * effectsDisplayTime) DisableEffects ();
		
		if(Input.GetMouseButtonDown(0)) StartCoroutine(shoot()); 
		
		Debug.DrawRay (transform.position, transform.forward * force);
	}
	
	private IEnumerator shoot () { 
		
		// pel = Instantiate(, transform.position, transform.rotation()); pel.rigidbody.AddForce(transform­.forwar­d * 8000)
		for (int i= 0; i < bullets.Count; i++) {
			
			
			
			if (!bullets[i].activeInHierarchy){
				GameObject bullet = bullets[i];
				bullet.transform.position = transform.position;
				bullet.transform.rotation = transform.rotation;
				Rigidbody r_body = bullet.GetComponent<Rigidbody>();
				r_body.velocity = Vector3.zero;
				bullet.SetActive(true);
				r_body.AddForce(transform.forward * force);
				StartCoroutine(destroyBullet(bullet, 5f));
				break;
			}
			
			yield return null;
		}
		
	}
	
	private IEnumerator destroyBullet(GameObject bullet, float time)
	{
		while (time > float.Epsilon) {
			time -= Time.deltaTime;
			yield return null;
		}
		bullet.SetActive (false);
	}
	
	
	public void DisableEffects ()
	{
		gunLight.enabled = false;
	}
	
	
	private void ShootingEffects()
	{
		GunEffectsTimer = 0f;
		gunLight.enabled = true;
		gunParticles.Play();
		
	}
	
}

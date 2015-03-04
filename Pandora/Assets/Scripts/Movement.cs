using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

	public float speed = 10f; // default 10

	private Rigidbody r_body;
	[SerializeField]
	private float verticalInput, horizontalInput;

	void Awake()
	{
		r_body = gameObject.GetComponent<Rigidbody>();
	}


	// Update is called once per frame
	void Update () {
		verticalInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");
	}

	void FixedUpdate()
	{
		Vector3 velocity = r_body.velocity;
		velocity.z = verticalInput * speed;
		velocity.x = horizontalInput * speed;
		r_body.velocity = velocity;
	}
}

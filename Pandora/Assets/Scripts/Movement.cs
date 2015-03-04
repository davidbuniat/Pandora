using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

	public float speed = 5f; // default 5

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
		velocity.x = verticalInput * speed;
		velocity.z = horizontalInput * speed * -1;
		r_body.velocity = velocity;
	}
}

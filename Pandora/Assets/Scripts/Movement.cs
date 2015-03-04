using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

	public float speed = 10f; // default 10
	
	private Rigidbody r_body;
	private Animator animator;


	[SerializeField]
	private float verticalInput, horizontalInput;

	void Awake()
	{
		r_body = gameObject.GetComponent<Rigidbody>();
		animator = gameObject.GetComponent<Animator>();
	}


	// Update is called once per frame
	void Update () {

		/* Get Input */
		verticalInput = Input.GetAxis("Vertical");
		horizontalInput = Input.GetAxis("Horizontal");

		/* Update animator parameter */
		animator.SetFloat("velocity", verticalInput);
	}

	void FixedUpdate()
	{
		/* Rotate on spot */
		Quaternion rotate = Quaternion.Euler(new Vector3(0f, horizontalInput, 0f));
		r_body.rotation *= rotate;

		/* Moving forward */
		// DODGY orientation forces me to use transform.right !!
		r_body.AddForce(transform.right * speed);
		float velocity = verticalInput * speed;
		r_body.velocity = velocity * transform.right;
	}
}

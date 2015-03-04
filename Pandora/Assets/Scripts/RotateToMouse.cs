using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class RotateToMouse : MonoBehaviour {
	

	public GameObject cube;

	[SerializeField]
	private float xRotation, yRotation;

	private Camera m_Cam;
	[SerializeField]
	private Vector3 targetPosition;

	private Quaternion rotation;

	void Awake () {

		rotation = transform.localRotation;

		if(Camera.main != null)
			m_Cam = Camera.main;
		else
			Debug.LogError("No main camera found");
	}
	
	// Update is called once per frame
	void Update () {
		LookRotation();
	}

	public void LookRotation()
	{

		Ray ray = m_Cam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.NameToLayer("Environment")))
		{
			//transform.localRotation.SetFromToRotation(transform.position, hit.point);

			//float targetRotation = Vector3.Angle(transform.position, hit.point);
			//transform.localRotation = targetRotation;
			transform.LookAt(hit.point);


			//Vector
		}
	}
}

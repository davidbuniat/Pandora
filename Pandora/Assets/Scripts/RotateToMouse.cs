using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class RotateToMouse : MonoBehaviour {

	private Camera m_Cam;
	private Quaternion rotation;


	void Awake () {
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
			transform.LookAt(hit.point);
			Debug.DrawLine(transform.position, hit.point, Color.red);
		}
	}
}

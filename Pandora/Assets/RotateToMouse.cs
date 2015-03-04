using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour {

	public Vector3 targetPosition;
	private Camera m_Cam;

	void Awake () {

		if(Camera.main != null)
			m_Cam = Camera.main;
		else
			Debug.LogError("No main camera found");
	}
	
	// Update is called once per frame
	void Update () {
	
		targetPosition = m_Cam.ScreenToWorldPoint(Input.mousePosition);

	}
}

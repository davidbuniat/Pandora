using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	private Transform m_Cam;


	void Awake()
	{
		if(Camera.main != null)
		{
			m_Cam = Camera.main.transform;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class cameracontroller : MonoBehaviour {
	public GameObject playerpos;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - playerpos.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerpos.transform.position + offset;

	}
}

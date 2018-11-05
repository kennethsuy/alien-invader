using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {
	public float ySpeed = 2f;
	public float xSpeed = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


		if (pos.x < 4.9) {
			if (Input.GetKey (KeyCode.D)) {
				pos.x += xSpeed * Time.deltaTime;
			}
		}
		if (pos.x > -4.9) {
			if (Input.GetKey (KeyCode.A)) {
				pos.x -= xSpeed * Time.deltaTime;
			}
		}
		if (pos.y < 4.9) {
			if (Input.GetKey (KeyCode.W)) {
				pos.y += ySpeed * Time.deltaTime;  
			}
		}
		if (pos.y > -4.9) {
			if (Input.GetKey (KeyCode.S)) {
				pos.y -= ySpeed * Time.deltaTime;
			}
		}

		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (Application.loadedLevel);
		}
		transform.position = pos;    
		transform.rotation=Quaternion.LookRotation(Vector3.forward, mousePosition-transform.position);

	}
}

using UnityEngine;
using System.Collections;

public class bulletmovement : MonoBehaviour {
	public float speed = 3f;
	// Use this for initialization
	void Start () {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.rotation=Quaternion.LookRotation(Vector3.forward, mousePosition-transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, speed * Time.deltaTime, 0);
		pos = pos + transform.rotation * velocity;
		transform.position = pos;
		if (pos.x > 5 || pos.x < -5 || pos.y > 5 || pos.y < -5) {
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D shotbadguy){
		if (shotbadguy.gameObject.tag == "badguy") {
			Destroy (this.gameObject);
		}
	}
}

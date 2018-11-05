using UnityEngine;
using System.Collections;

public class baddiemovement : MonoBehaviour {
	private GameObject objectToTrack;
	public float speed = 3f;

	// Use this for initialization
	void Start () {
		objectToTrack = GameObject.Find("playerchar");
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerposition = objectToTrack.transform.position;
		transform.rotation=Quaternion.LookRotation(Vector3.forward, playerposition-transform.position);

		Vector3 pos = transform.position;
		Vector3 velocity = new Vector3 (0, speed * Time.deltaTime, 0);
		pos = pos + transform.rotation * velocity;
		transform.position = pos;

	}
}

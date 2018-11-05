using UnityEngine;
using System.Collections;

public class playershoot : MonoBehaviour {
	public GameObject objectToSpawn;
	public AudioClip hitsound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource ourAudio = GetComponent<AudioSource>();
		Vector3 pos = transform.position;
		if (Input.GetMouseButtonDown(0)) {
			ourAudio.PlayOneShot(hitsound);
			GameObject newObj = Instantiate(objectToSpawn) as GameObject;
			Vector3 newPosition;
			newPosition.x = pos.x;
			newPosition.y = pos.y;
			newPosition.z = 0;
			newObj.transform.position = newPosition;

		}
	}
}

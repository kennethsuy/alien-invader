using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public int baddie1p = 10;
	public totalscore addhere;
	public AudioClip hitsound;
	public GameObject newEnemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D shotbadguy){
		AudioSource ourAudio = GetComponent<AudioSource>();
		if (shotbadguy.gameObject.tag == "mybullet") {
			addhere.addpoints (baddie1p);
			ourAudio.PlayOneShot(hitsound);
			this.transform.position=new Vector3 (200,200, 0);
			Destroy (this.gameObject, hitsound.length);
			GameObject newObj = Instantiate(newEnemy) as GameObject;
			newObj.GetComponent<score>().addhere = addhere;
			float speedforce = Random.Range(-0.4f,0.4f);
			newObj.GetComponent<baddiemovement>().speed = 2+speedforce+addhere.GetComponent<totalscore>().inittime/20;
			Vector3 newPosition;
			float randdist = Random.Range(-30.0f,30.0f);
			float whichside = Random.Range(0.0f,4.0f);

			if((whichside)<1.00f){//Far Left
				newPosition.x = -30.0f;
				newPosition.y = randdist;
				newPosition.z = 0;
				newObj.transform.position = newPosition;
			}
			else if((whichside)<2.00f){//Far Right
				newPosition.x = 30.0f;
				newPosition.y = randdist;
				newPosition.z = 0;
				newObj.transform.position = newPosition;
			}
			else if((whichside)<3.00f){//Far Bottom
				newPosition.x = randdist;
				newPosition.y = -30.0f;
				newPosition.z = 0;
				newObj.transform.position = newPosition;
			}
			else if((whichside)<4.00f){//Far Top
				newPosition.x = randdist;
				newPosition.y = 30.0f;
				newPosition.z = 0;
				newObj.transform.position = newPosition;
			}
		}
	}
}

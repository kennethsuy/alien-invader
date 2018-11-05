using UnityEngine;
using System.Collections;


public class playerdamage : MonoBehaviour {
	public float invln = 0;
	public totalscore health;
	public AudioClip hitsound;
	private Animator anim;

	//public Animation anim = null;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(invln);
		if (invln > 0) {
			invln -= Time.deltaTime;


		}
		if (invln < 0.0f) {
			anim.SetInteger("state",0);
		}
	}
	void OnTriggerEnter2D(Collider2D mychar){
		AudioSource ourAudio = GetComponent<AudioSource>();

		if (mychar.gameObject.tag == "badguy"&&invln<=0) {
			health.takedamage ();
			ourAudio.PlayOneShot(hitsound);
			invln = 2;
			anim.SetInteger("state",1);
		}
	}
}

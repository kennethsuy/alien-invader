using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class totalscore : MonoBehaviour {
	static public int total;
	public Text texttotal;
	public Text healthtotal;
	public int myhealth=3;
	public Text timer;
	public float inittime;
	static public float snap;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		inittime=Time.time-snap;
		timer.text = ("Time: "+inittime.ToString("0.0"));
		if (total >= 1500) {
			Application.LoadLevel ("winscene");
		}
	}

	public void addpoints(int points){
		total += points;
		texttotal.text = ("Score: " + total);
	}
	public void takedamage(){
		if (myhealth == 3) {
			myhealth = 2;
			healthtotal.text = ("Life:   <3 <3");
		} else if (myhealth == 2) {
			myhealth = 1;
			healthtotal.text = ("Life:   <3");
		} else if (myhealth == 1) {
			Application.LoadLevel ("endscene");
		}
	}
	void onGUI(){
		GUILayout.Label (total.ToString());
		GUILayout.Label (healthtotal.ToString());
	}
}

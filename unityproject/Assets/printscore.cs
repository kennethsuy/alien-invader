using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class printscore : MonoBehaviour {
	public Text finalscore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		finalscore.text = ("Final Score: " + totalscore.total);
	}
	void onGUI(){
		GUILayout.Label (finalscore.ToString ());
	}
}

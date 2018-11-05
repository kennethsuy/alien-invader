using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollzoom : MonoBehaviour {
	public Camera maincamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var d = Input.GetAxis("Mouse ScrollWheel");
		if (d > 0f){
			if((maincamera.orthographicSize)>1.0f){
			
		    	maincamera.orthographicSize = maincamera.orthographicSize - 0.05f;
			}

		}
		else if (d < 0f){
			if((maincamera.orthographicSize)<3.0f){
		    	maincamera.orthographicSize = maincamera.orthographicSize + 0.05f;
		    }
		}
	}
}

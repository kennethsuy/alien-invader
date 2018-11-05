using UnityEngine;
using System.Collections;

public class menuscene : MonoBehaviour {

	public void startButtonPressed() {
		totalscore.total = 0;
		totalscore.snap= Time.time;
		Application.LoadLevel("playscene");
	}
}

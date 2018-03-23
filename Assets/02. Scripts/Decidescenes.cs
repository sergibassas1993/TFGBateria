using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Decidescenes : MonoBehaviour {
	float decidescene;
	float decidesceneVR;
	public Toggle vr;
	public Toggle vrDR;
	// Use this for initialization
	void Start () {
		decidescene = PlayerPrefs.GetFloat("decidescene");
		decidesceneVR = PlayerPrefs.GetFloat("decidesceneVR");

		if (decidescene == 1) {

			vr.isOn = true;
		} else {
			vr.isOn = false;
		}

		if (decidesceneVR == 1) {

			vrDR.isOn = true;
		} else {
			vrDR.isOn = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

	

	
	}


	public void decidirescene () {


		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		if (vr.isOn) {
			PlayerPrefs.SetFloat("decidescene",1);
		} else {
			PlayerPrefs.SetFloat("decidescene",0);
		}
		if (vrDR.isOn) {
			PlayerPrefs.SetFloat("decidesceneVR",1);
		} else {
			PlayerPrefs.SetFloat("decidesceneVR",0);
		}
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text tempstext;
	public float temps = 0.0f;
	public int index;
	public int indexfill;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		temps = temps - Time.deltaTime;
		tempstext.text = "" + temps.ToString("f0");


		//GameObject gc = GameObject.FindGameObjectWithTag ("GameController");
		//gc.GetComponent<GameController> ().PlayBattery (index, indexfill);


	}
}

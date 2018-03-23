using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstrumentPlay : MonoBehaviour {
	public int index;
	public int indexfill;


	// Use this for initialization
	void Start () {
		
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{


		GameObject gc = GameObject.FindGameObjectWithTag ("GameController");
		GameObject lx = GameObject.FindGameObjectWithTag ("GameObject");

	
		if (lx.GetComponent<LoadXml> ().instrument1r != 100 || lx.GetComponent<LoadXml> ().instrument2n != 100  ) {

			if (lx.GetComponent<LoadXml> ().instrument1r == index || lx.GetComponent<LoadXml> ().instrument2n == index) {
				gc.GetComponent<GameController> ().PlayBattery (index, indexfill);
				gc.GetComponent<GameController> ().puntuacio = gc.GetComponent<GameController> ().puntuacio + 1;
			}
		}


	}

}

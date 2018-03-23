using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Animator[] animations;
	public int puntuacio = 0;
	public AudioSource[] sounds;
	public GameObject[] instruments;
	public Text puntText;
	// Use this for initialization
	void Start () {
		puntuacio = 0;
		puntText.text = "Puntuació:";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Q))
		{
			PlayBattery (1,1);
		}

		if (Input.GetKeyDown(KeyCode.A))
		{
			PlayBattery (1,0);
		}

		if (Input.GetKeyDown(KeyCode.Z))
		{
			PlayBattery (1,2);
		}

		if (Input.GetKeyDown(KeyCode.W))
		{
			PlayBattery (3,0);
		}

		if (Input.GetKeyDown(KeyCode.C))
		{
			PlayBattery (2,0);
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			PlayBattery (4,0);
		}

		if (Input.GetKeyDown(KeyCode.F))
		{
			PlayBattery (4,1);
		}

		if (Input.GetKeyDown(KeyCode.V))
		{
			PlayBattery (4,2);
		}

		if (Input.GetKeyDown(KeyCode.X))
		{
			PlayBattery (5,0);
		}

		if (Input.GetKeyDown(KeyCode.S))
		{
			PlayBattery (6,0);
		}

		if (Input.GetKeyDown(KeyCode.D))
		{
			PlayBattery (7,0);
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			PlayBattery (0,0);
		}

		puntText.text = "Puntuació:" + puntuacio;
	}

	public void PlayBattery (int index, int indexfill){

		if (indexfill == 0) {
			animations [index].SetTrigger ("playanimation");

		}
		if (indexfill == 1) {
			animations [index].SetTrigger ("playanimation1");
		
		}

		if (indexfill == 2) {
			animations [index].SetTrigger ("playanimation2");

		}
		sounds[index].Play();

	}

	public void LightInstrument (int index){


		instruments [index].GetComponent<shaderGlow> ().lightOn ();
	
		instruments [index].GetComponent<shaderGlow> ().glowIntensity = 1.0f;
	
	}

	public void LightOff (){

		int i = 0;
			//instruments [index].GetComponent<shaderGlow> ().lightOff ();
		for (i=0; i < instruments.Length;i++)
		{
			
			instruments [i].GetComponent<shaderGlow> ().glowIntensity = -1.0f;

		}
	}
}


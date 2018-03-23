using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class LoadXml : MonoBehaviour {

	private List<Nota> Notes;
	private TextAsset textXml;
	public string fileName;
	private XmlDocument xmlDoc;
	private string path;
	public float temps = 0.0f;

	public int instrument1r = 100;
	public int instrument2n = 100;
	// Use this for initialization

	struct Nota {
		public int instrument1;
		public int instrument2;
		public float durabilitat;
		public float temps;
		public bool onoff;


	};


	void Awake () {
		fileName = "items.xml";
		Notes = new List<Nota> ();
	} 


	void Start () {

		loadXMLFromAsset ();
		readXml ();
		temps = 62.0f;



	}


	void Update () {
		temps = temps - Time.deltaTime;

		foreach (Nota nota in Notes) {
			

			//insturument1r = nota.instrument1;
			if (nota.temps > temps && nota.temps - nota.durabilitat < temps) {
				
				instrument1r = nota.instrument1;
				instrument2n = nota.instrument2;

				GameObject gc = GameObject.FindGameObjectWithTag ("GameController");
				gc.GetComponent<GameController> ().LightInstrument (nota.instrument1);
				gc.GetComponent<GameController> ().LightInstrument (nota.instrument2);
			
			
					
			}
		

			if ( nota.temps - nota.durabilitat > temps) {
				
					

				if (instrument2n != 100 && instrument1r !=100) {
					
					instrument1r = 100;
					instrument2n = 100;
			
				} 
			
		}
		
	

		
		}

		if (instrument1r == 100 && instrument2n == 100) {
			

			GameObject gc2 = GameObject.FindGameObjectWithTag ("GameController");
			gc2.GetComponent<GameController> ().LightOff ();


		}

	}



	private void loadXMLFromAsset()
	{
		xmlDoc = new XmlDocument ();

		if(System.IO.File.Exists(getPath())){

			xmlDoc.LoadXml(System.IO.File.ReadAllText(getPath()));
			print ("hola");
		}

		else
		{

		}


	}


	private void readXml ()
	{

		foreach (XmlElement node in xmlDoc.SelectNodes("Notes/Nota")) {

			Nota tempNota = new Nota ();


			tempNota.instrument1 = int.Parse(node.SelectSingleNode("instrument1").InnerText);

			tempNota.instrument2 = int.Parse(node.SelectSingleNode("instrument2").InnerText);

			tempNota.durabilitat = float.Parse(node.SelectSingleNode("durabilitat").InnerText);

			tempNota.temps = float.Parse(node.SelectSingleNode("temps").InnerText);

			tempNota.onoff = bool.Parse(node.SelectSingleNode("onoff").InnerText);
			print ("hola4");

			Notes.Add (tempNota);



		}

	}

	private string getPath()
	{

		#if UNITY_EDITOR
		return Application.dataPath +"/Resources/"+fileName;
		#endif
	}			
	// Update is called once per frame

}

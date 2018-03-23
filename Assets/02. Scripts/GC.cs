using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Xml;
using System.IO;

public class GC : MonoBehaviour {
	public Text temps;
	public float time = 60.0f;
	public TextAsset GameAsset;
	public shaderGlow[] instruments;
	static string entry1 = "";
	static string entry2 = "";
	static string timeforuser = "";
	static string duration = "";

	List<Dictionary<string,int>> notes = new List<Dictionary<string,int>>();
	Dictionary<string,int> obj;
	// Use this for initialization
	void Start () {
		time = 60.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		//time -= Time.deltaTime;
//		temps.text = "" + time.ToString ("f0");
		GetLevel();
		if (Input.GetKeyDown ("space")) {
			
		}
	}

	public void GetLevel()
	{
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(GameAsset.text); // load the file.
		XmlNodeList notesList = xmlDoc.GetElementsByTagName("note"); // array of the level nodes.

		foreach (XmlNode notainfo in notesList)
		{
			XmlNodeList notacontent = notainfo.ChildNodes;
			obj = new Dictionary<string,int>(); // Create a object(Dictionary) to colect the both nodes inside the level node and then put into levels[] array.

			foreach (XmlNode notaItens in notacontent) // levels itens nodes.
			{

				if(notaItens.Name == "object")
				{
					switch(notaItens.Attributes["name"].Value)
					{
					case "Entry1": obj.Add("Entry1",int.Parse(notaItens.InnerText));break; // put this in the dictionary.
					case "Entry2":obj.Add("Entry2",int.Parse(notaItens.InnerText)); break; // put this in the dictionary.
					case "Time":obj.Add("Time",int.Parse(notaItens.InnerText)); break; // put this in the dictionary.
					case "Duration": obj.Add("Duration",int.Parse(notaItens.InnerText));break; // put this in the dictionary.
					}
				}
			}
			notes.Add (obj); // add whole obj dictionary in the levels[].
		}
		Debug.Log (notes);
	}

	/*
	void Playandcheck () {
		lightoff ();
	
		instrument = Random.Range(0,6); 
		instruments [instrument].GetComponent<shaderGlow> ().lightOn();
	

	}

	void lightoff () {
		for (int i = 0; i > instruments.Length; i++) {
			instruments [i].GetComponent<shaderGlow> ().lightOff ();
		}
	}
	*/
}

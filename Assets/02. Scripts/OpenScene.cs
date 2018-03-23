using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenScene : MonoBehaviour {
	string escena;

	public void tancar(){
		Debug.Log ("boto tancar");
		Application.Quit();
	}

	public void obrir(string escena)
	{
		SceneManager.LoadScene (escena, LoadSceneMode.Single);
	}

	public void obreescena(string escena){
		if (PlayerPrefs.GetFloat ("decidesceneVR") == 0) {
			escena = "DrummerheroP";
			Debug.Log ((PlayerPrefs.GetFloat ("decidesceneDR")));
		}

		if (PlayerPrefs.GetFloat ("decidesceneVR") == 1) {
			escena = "DrummerheroPVR";
			Debug.Log ((PlayerPrefs.GetFloat ("decidesceneDR")));
			Debug.Log (escena);
		}


		SceneManager.LoadScene (escena, LoadSceneMode.Single);
	
	}

	public void openscene(string escena)
	{

		if (PlayerPrefs.GetFloat ("decidescene") == 0) {
			escena = "Playfree";
			Debug.Log (escena);

		} 
		if (PlayerPrefs.GetFloat ("decidescene") == 1) {
			escena = "PlayfreeVR";
			Debug.Log (escena);
		}

		SceneManager.LoadScene (escena, LoadSceneMode.Single);
}
	public void obrirsetting()
	{

	
		SceneManager.LoadScene ("Setting", LoadSceneMode.Single);
	}

}

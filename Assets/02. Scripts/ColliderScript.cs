using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {

	public int index;
	public int indexfill;
	ushort time = 2000;
	public float[] velocitatcontrolador1 = new float[100];
	public float[] velocitatcontrolador2 = new float[100];
	float mveloc1;
	float mveloc2;
	// Use this for initialization
	void Start () {
		mveloc1 = 0;
		mveloc2 = 0;

		//get the velocity
	
	}
	
	// Update is called once per frame
	void Update () {
		/*
		for (int i = 0; i < velocitatcontrolador1.Length; i++) {
	//		SteamVR_Controller.Device device = SteamVR_Controller.Input (3);
			Vector3 vel = device.velocity;
			velocitatcontrolador1 [i] = vel.magnitude;  
			Debug.Log (vel.magnitude);
			if (i == 100) {
				i = 0;
			}
		}

		for (int i = 0; i < velocitatcontrolador2.Length; i++) {
	//		SteamVR_Controller.Device device = SteamVR_Controller.Input (4);
//			Vector3 vel1 = device.velocity;
			velocitatcontrolador2 [i] = vel1.magnitude;  
			Debug.Log (vel1);
			if (i == 100) {
				i = 0;
			}

		}
		*/

		//Vector3 vel = (controller.pos - lastPos) / Time.deltaTime;
		//lastPos = controller.pos;
	}

	public float mitjanavelocitat  (float[] array) {
		float sumavelocitats = 0;
		float mitjanatotal = 0;

		for(int i=0; i < array.Length; i++)
		{

			sumavelocitats = sumavelocitats + array[i];
		}

		mitjanatotal = sumavelocitats / 100;

		return mitjanatotal;
	}

	void OnTriggerEnter(Collider other)
	{
		
		Debug.Log (index);
		GameObject gc = GameObject.FindGameObjectWithTag ("GameController");
		gc.GetComponent<GameController> ().PlayBattery (index, indexfill);
	
		if (other.tag == "controldret") {
		//	SteamVR_Controller.Input (4).TriggerHapticPulse (time);
			mveloc1 = mitjanavelocitat (velocitatcontrolador2);

		}
		if (other.tag == "controlesq") {
			//SteamVR_Controller.Input (3).TriggerHapticPulse (time);
			mveloc2 = mitjanavelocitat (velocitatcontrolador1);

		}
	}
//		SteamVR_Controller.Input(0).TriggerHapticPulse(100000);
	

}



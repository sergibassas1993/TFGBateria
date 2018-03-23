using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nota  {

	public int intsrument1;
	public int instrument2;
	public float durabilitat;
	public float temps;
	public bool onoff;


	public Nota(int instrument1, int instrument2, float durabilitat, float temps, bool onoff)
	{
		instrument1 = instrument1;
		instrument2 = instrument2;
		durabilitat = durabilitat;
		temps = temps;
		onoff = onoff;
	}

}

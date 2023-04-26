using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timyyyyyyyyyyyyyy: MonoBehaviour {
	public AudioSource gdeta;
	public AudioClip tuta;

	public void tad(){
		gdeta.PlayOneShot (tuta);
	}

	public void kad(){
		gdeta.Stop ();
	}
}

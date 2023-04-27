using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nepieciešams, lai strādātu ar UI elementiem
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {



	private string teksts;

	public GameObject ievadesLauks;

	public GameObject tekstaAttelosana;

	private string[] varianti = {"Sveiki ", "Labdien ", 
		"Prieks Tevi redzēt ", "Uzredzēšanos "};

	int nejausais;

	public void NolasitTekstu(){
		teksts = ievadesLauks.GetComponent<Text>().text;
		nejausais = Random.Range (0, varianti.Length);
		tekstaAttelosana.GetComponent<Text>().text = 
			varianti[nejausais]+teksts.ToUpper()+"!";
	}		
}

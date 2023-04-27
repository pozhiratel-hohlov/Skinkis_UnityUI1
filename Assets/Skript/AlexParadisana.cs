using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlexParadisana : MonoBehaviour
{
	public GameObject A1;
	public GameObject A2;
	public GameObject A3;
	public GameObject A4;
	public GameObject A5;
	public GameObject A6;
	public GameObject A7;
	public GameObject levo;
	public GameObject prava;
	public GameObject kurRadit;
	public Sprite[] atteluMasivs;
	public GameObject slaideris1;
	public GameObject slaideris2;
	public GameObject slaideris3;



	public void PaKreisi()
	{
		A1.transform.localScale = new Vector2(1, 1);
	}

	public void PaLabi()
	{
		A1.transform.localScale = new Vector2(-1, 1);
	}
	public void izkritosais(int indekss)
	{

		if (indekss == 0)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[0];
		else if (indekss == 1)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[1];
		else if (indekss == 2)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[2];
		else if (indekss == 3)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[3];
		else if (indekss == 4)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[4];
		else if (indekss == 5)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[5];
		else if (indekss == 6)
			kurRadit.GetComponent<Image>().sprite = atteluMasivs[6];
	}
	public void mainitLielumu()
	{
		float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
		kurRadit.transform.localScale = new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba);
	}
	public void mainitRotaciju()
	{
		float pasreizejaVertiba = slaideris2.GetComponent<Slider>().value;
		kurRadit.transform.localRotation = Quaternion.Euler(0, 0, pasreizejaVertiba * 360);
	}
	public void mainitPlatumu()
	{
		float pasreizejaVertiba = slaideris3.GetComponent<Slider>().value;
		kurRadit.GetComponent<RectTransform>().sizeDelta = new Vector2(pasreizejaVertiba, kurRadit.GetComponent<RectTransform>().sizeDelta.y);
	}

}
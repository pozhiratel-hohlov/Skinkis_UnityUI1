using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject S1;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject S5;
    public GameObject S6;
    public GameObject S7;
    public GameObject paKreisi;
    public GameObject paLabi;
    public GameObject kurRadit;
    public Sprite[] koRadit;
    public GameObject slaideris1;
    public GameObject slaideris2;



    public void PaKreisiBins()
    {
        S1.transform.localScale = new Vector2(1, 1);
    }

    public void PaLabiBins()
    {
        S1.transform.localScale = new Vector2(-1, 1);
    }
    public void izkritosais(int indekss)
    {

        if (indekss == 0)
            kurRadit.GetComponent<Image>().sprite = koRadit[0];
        else if (indekss == 1)
            kurRadit.GetComponent<Image>().sprite = koRadit[1];
        else if (indekss == 2)
            kurRadit.GetComponent<Image>().sprite = koRadit[2];
        else if (indekss == 3)
            kurRadit.GetComponent<Image>().sprite = koRadit[3];
        else if (indekss == 4)
            kurRadit.GetComponent<Image>().sprite = koRadit[4];
        else if (indekss == 5)
            kurRadit.GetComponent<Image>().sprite = koRadit[5];
        else if (indekss == 6)
            kurRadit.GetComponent<Image>().sprite = koRadit[6];
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
}
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtteluParadisana : MonoBehaviour {

	public GameObject bins;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;
	public GameObject paKreisi;
	public GameObject paLabi;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject IzmeraSlaideris;

    public void BinaAttels(bool vertiba){

        bins.SetActive(vertiba);
		paKreisi.GetComponent<Toggle> ().interactable = vertiba;
		paLabi.GetComponent<Toggle> ().interactable = vertiba;
    }
    public void LacisAttels(bool vertiba)
    {

        lacitis.SetActive(vertiba);
    }
    public void TantesAttels(bool vertiba)
    {

        tante.SetActive(vertiba);
    }
    public void MasinasAttels(bool vertiba)
    {

        masina.SetActive(vertiba);
    }

	public void PaKreisiBins(){
		bins.transform.localScale = new Vector2 (1, 1);
	}
	public void PaLabiBins(){
		bins.transform.localScale = new Vector2 (-1, 1);
	}
    public void izkritosais(int indekss)
    {
        if(indekss == 0)
        
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

      else if(indekss ==1) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

            else if (indekss == 2) mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        }

    public void mainitLielumu()
    {

        float pasreizejaisIzmers = IzmeraSlaideris.GetComponent < Slider >().value;
        mainigaisAttels.transform.localScale = new Vector2(1f* pasreizejaisIzmers, 1f* pasreizejaisIzmers);

    }

    }

﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtteluParadisana : MonoBehaviour {

	public GameObject bins;
    public GameObject lacitis;
    public GameObject tante;
    public GameObject masina;

    public void BinaAttels(bool vertiba){

        bins.SetActive(vertiba);
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
}

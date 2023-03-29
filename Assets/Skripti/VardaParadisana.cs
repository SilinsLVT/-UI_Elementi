using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	// int kadrs = 0;
	// Use this for initialization
	  //void Start () {
		// Debug.Log ("Startéta programma!");
	// }
	
	// Update is called once per frame
	 // void Update () {
		 // kadrs++;
		 // Debug.Log ("Kadrs "+kadrs);
	// }


//Mainigais, kurá iegalbás tekstu no input field
	private string teksts;
	private string [] varianti = {"Sveiks", "Jauku dienu", "Nav prieks", "Uzredzesanos"};


	// Uzglabas nogeneréto random skaitli
	int nejausais;
	//Lauks, no kura ievada tekstu
	public GameObject ievadesLauks;
	//Text, kurá attélos tekstu
	public GameObject tekstaAttelosana;

	public void UzglabatTekstu(){

		nejausais = Random.Range (0, varianti.Length);
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosana.GetComponent<Text>().text  = varianti[nejausais]+teksts.ToUpper()+"!";
	}
}
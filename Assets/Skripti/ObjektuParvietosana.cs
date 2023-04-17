using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importet lai varetu darboties ar pointer interfeicu
using UnityEngine.EventSystems;
public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

	public Canvas kanva;
	private RectTransform transformacijasLogs;

	// Use this for initialization
	void Start()
	{

		transformacijasLogs = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData notikums)
	{

		Debug.Log("Izdarits kreisais klikskis uz velkama objekta!");

	}

	public void OnBeginDrag(PointerEventData notikums)
	{
		Debug.Log("Uzsakta objekta vilksana!");
	}

	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek objekta vilksana!");
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums)
	{
		Debug.Log("Veikta objekta vilksana");
	}
}

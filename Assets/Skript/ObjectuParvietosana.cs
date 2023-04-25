using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectuParvietosana : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformacijasLogs;
    public Canvas kanva;

    void Start()
    {
        transformacijasLogs = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Kreisais klikslis uz velkama objekta");
    }

    public void OnBeinDrag(PointerEventData notikums)
    {
        Debug.Log("Uzsakta objekta vilksana");
    }

    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Notiek objecta vilksana");
        transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
    }
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Objekta vilksana partraukta");
    }
}

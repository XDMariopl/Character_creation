using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_drop : MonoBehaviour, IDragHandler {
    private RectTransform transformKomponet;
    public Canvas canvas;

    void Start()
    {
        transformKomponet = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transformKomponet.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public TMP_Text text;
    public LayoutElement layoutElement;
    public Collider Collider;

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
    }

    private void OnMouseDown()
    {
        GlobalInformation.CardChoosen = this;
        layoutElement.ignoreLayout = true;
        transform.position += transform.up * 1f;
        Collider.enabled = false;
    }
}

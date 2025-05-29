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
    public GameObject CardElement;

    public GameObject Buttons;

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        CardElement.transform.localPosition = new Vector3(0f, 0.3f, 0f); 
    }

    private void OnMouseExit()
    {
        CardElement.transform.localPosition = new Vector3(0f, 0f, 0f);
    }

    private void OnMouseDown()
    {
        if (GlobalInformation.CardChoosen != null)
        {
            GlobalInformation.CardChoosen.layoutElement.ignoreLayout = false;
            GlobalInformation.CardChoosen.Collider.enabled = true;
            GlobalInformation.CardChoosen.transform.localPosition = new Vector3(0f, 0f, -0.08f);
            GlobalInformation.CardChoosen.transform.localScale = new Vector3(1f, 1f, 1f);
            GlobalInformation.CardChoosen.Buttons.SetActive(false);
        }
        GlobalInformation.CardChoosen = this;
        layoutElement.ignoreLayout = true;
        transform.localPosition = new Vector3(0, 3f, 0f);
        transform.localScale = new Vector3(2f, 2f, 2f);
        Collider.enabled = false;
        Buttons.SetActive(true);
    }

    public void BackButttonAction()
    {
        layoutElement.ignoreLayout = false;
        Collider.enabled = true;
        transform.localPosition = new Vector3(0f, 0f, 0f);
        transform.localScale = new Vector3(1f, 1f, 1f);
        Buttons.SetActive(false);
        GlobalInformation.CardChoosen = null;
    }
    public void PlayButttonAction()
    {

    }

}

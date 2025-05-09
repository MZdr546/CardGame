using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    [SerializeField]
    public List<CardVariant> Cards = new List<CardVariant>();
}

[System.Serializable]
public class CardVariant
{
    public string Name;
    public Image Image;
}

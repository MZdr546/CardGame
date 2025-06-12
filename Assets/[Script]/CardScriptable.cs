using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObject/Card")]
public class CardScriptable : ScriptableObject
{
    public string Name;
    public Image Image;
}

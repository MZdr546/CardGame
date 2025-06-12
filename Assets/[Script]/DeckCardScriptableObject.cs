using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DeckCardScriptable", menuName = "ScriptableObject/Deck")]
public class DeckCardScriptableObject : ScriptableObject
{
    
    public List<CardScriptable> Cards = new List<CardScriptable>();
    [SerializeField]
    public List<CardDeck> DeckCards = new List<CardDeck>();


    [ContextMenu("Shoot")]
    public void Shoot()
    {
        DeckCards.Clear();
        for(int i = 0; i < Cards.Count; i++)
        {
            CardDeck pop = new CardDeck();
            pop.Card = Cards[i];
            pop.ID = i.ToString();
            DeckCards.Add(pop);
        }
    }


}

[System.Serializable]
public class CardDeck
{
    public string ID;
    public CardScriptable Card = new CardScriptable();
}

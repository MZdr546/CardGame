using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCard : MonoBehaviour
{
    public Canvas cards;

    public DeckCardScriptableObject cardDeck;
    public GameObject card;

    [Header("Lists")]

    [SerializeField]
    List<CardScriptable> cardVariants = new List<CardScriptable>();
    [SerializeField]
    List<CardScriptable> deck = new List<CardScriptable>();

    bool isInList = false;

    private void OnMouseDown()
    {

        if (deck.Count < 5)
        {

            Debug.Log("PopPop");

            isInList = false;

            GameObject pop = Instantiate(card, cards.transform);


            pop.GetComponent<Card>().text.text = cardDeck.DeckCards[GetRandomCard()].Card.Name;

            //pop.GetComponent<Card>().text.text = cardDeck.Cards[i].Name;
            //cardDeck.Cards[Random.RandomRange(0, cardDeck.Cards.Count)]
        }

    }

    public int GetRandomCard()
    {
        while (true)
        {
            int o = Random.RandomRange(0, cardDeck.DeckCards.Count);

            if (cardVariants.Count != 0)
            {
                for (int j = 0; j < cardVariants.Count; j++)
                {
                    if (o == int.Parse(cardVariants[j].Name))
                    {
                        isInList = true;
                    }

                }
            }

            if (deck.Count != 0)
            {
                for (int j = 0; j < deck.Count; j++)
                {
                    if (o == int.Parse(deck[j].Name))
                    {
                        isInList = true;
                    }

                }
            }

            if (!isInList)
            {
                
                CardScriptable cardVariant = new CardScriptable();
                cardVariant.Name = o.ToString();
                CardDeck cardDeck = new CardDeck();
                cardDeck.ID = o.ToString();
                cardDeck.Card = cardVariant;
                
                cardVariants.Add(cardVariant);
                deck.Add(cardVariant);

                return o;
            }
        }
    }


}

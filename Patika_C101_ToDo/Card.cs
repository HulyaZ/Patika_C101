using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_ToDo
{
    public class Card
    {
        private string cardTitle;
        private string cardTopic;
        private int cardID;
        public int cardResponsibleMember;

        public string CardTitle
        {
            get => cardTitle;
            set => cardTitle = value;
        }

        public string CardTopic
        {
            get => cardTopic;
            set => cardTopic = value;
        }

        public int CardID
        {
            get => cardID;
            set => cardID = value;
        }

        public enum BoardState
        {
            TODO,
            INPROGRESS,
            DONE
        }

        public BoardState boardState { get; set; }

        public enum CardSize
        {
            XS = 1,
            S,
            M,
            L,
            XL
        }
        public CardSize cardSize { get; set; }

        public static List<Card> cardList = new List<Card>();

        public Card(string cardTitle, string cardTopic, int id, int ownerID, CardSize size, BoardState state)
        {
            this.cardTitle = cardTitle;
            this.cardTopic = cardTopic;
            cardID = id;
            cardResponsibleMember = ownerID;
            cardSize = size;
            boardState = state; 
        }

        public Card(string cardTitle, string cardTopic, int id, CardSize size, BoardState state)
        {
            this.cardTitle = cardTitle;
            this.cardTopic = cardTopic;
            cardID = id;
            cardSize = size;
            boardState = state;
        }
        public Card(){ }


        public static void DefaultCards()
        {
            Card.cardList.Add(new Card("Sahne Tasarımı", "Sahne tasarımı, müşteri briefi", 1, 101, CardSize.S, BoardState.DONE));
            Card.cardList.Add(new Card("Sahne Tasarımı, üretim", "Sahne tasarımı üretimi", 2, 103, CardSize.L, BoardState.INPROGRESS));
            Card.cardList.Add(new Card("Sahne Tasarımı, kurulum", "Sahne kurulumu gerçekleştirilecek.", 3, CardSize.XL, BoardState.TODO));
        }


    }

}

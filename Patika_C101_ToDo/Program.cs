using System;

namespace Patika_C101_ToDo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Member.DefaultMembers();
            Card.DefaultCards();
            CardAddToBoardList();
            MainMenuOptions();
        }

        static void MainMenuOptions()
        {
            Console.WriteLine("*******TO DO*******");
            Console.WriteLine();
            Console.WriteLine("1. Board Listele.");
            Console.WriteLine("2. Board'a kart ekle.");
            Console.WriteLine("3. Board'dan kart sil.");
            Console.WriteLine("4. Kartı taşı.");
            MainMenuSelection();
        }

        static void MainMenuSelection()
        {
            int selection = InputValidation();

            switch (selection)
            {
                case 1:
                    printBoards();
                    break;
                case 2:
                    CardAdd();
                    break;
                case 3:
                    DeleteCard();
                    break;
                case 4:
                    MoveCard();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz:");
                    MainMenuSelection();
                    break;
            }
        }

        public static void printBoards()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************");

            for (int i = 0; i < Card.cardToDoList.Count; i++)
            {
                Card card = Card.cardToDoList[i];
                Console.WriteLine("Kart ID: " + card.CardID);
                Console.WriteLine("Başlık: " + card.CardTitle);
                Console.WriteLine("İçerik: " + card.CardTopic);

                Console.WriteLine("Atanan kişi: " + responsibleMemberName(card.CardOwner));
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("In Progress Line");
            Console.WriteLine("*******************");

            for (int i = 0; i < Card.cardInprogressList.Count; i++)
            {
                Card card = Card.cardInprogressList[i];
                Console.WriteLine("Kart ID: " + card.CardID);
                Console.WriteLine("Başlık: " + card.CardTitle);
                Console.WriteLine("İçerik: " + card.CardTopic);


                Console.WriteLine("Atanan kişi: " + responsibleMemberName(card.CardOwner));
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("Done Line");
            Console.WriteLine("*******************");

            for (int i = 0; i < Card.cardDoneList.Count; i++)
            {
                Card card = Card.cardDoneList[i];
                Console.WriteLine("Kart ID: " + card.CardID);
                Console.WriteLine("Başlık: " + card.CardTitle);
                Console.WriteLine("İçerik: " + card.CardTopic);

                Console.WriteLine("Atanan kişi: " + responsibleMemberName(card.CardOwner));
                Console.WriteLine("-");
            }

            loadingMainMenu();

        } // Main Menu Option 1 - Print Boards
        static void CardAdd() // Main Menu Option 2 - Add new card
        {
            Console.WriteLine("Kart başlığını giriniz: ");
            string cardTitleInput = CaseCorrection(Console.ReadLine());

            Console.WriteLine("Kart içeriğini giriniz: ");
            string cardTopicInput = CaseCorrection(Console.ReadLine());

            Console.WriteLine("Kart büyüklüğünü seçiniz: ");
            Console.WriteLine("XS(1),S(2),M(3),L(4),XL(5)");
            int cardSizeInput = InputValidation();

            int ownerID = cardOwner();

            Card.CardSize cardSizeP = (Card.CardSize)cardSizeInput;

            Card.cardList.Add(new Card(cardTitleInput, cardTopicInput, (Card.cardList.Count + 1), ownerID, cardSizeP, Card.BoardState.TODO));

            CardAddToBoardList();
            loadingMainMenu();
        }

        static void DeleteCard() // Main Menu Option 3 - Delete Card
        {
            Console.WriteLine("Lütfen silmek istediğiniz kartın id'sini giriniz.");
            int cardToDeleteID = InputValidation();
            if (Card.cardList.Exists(x => x.CardID == cardToDeleteID))
            {
                foreach (Card card in Card.cardList)
                {
                    if (card.CardID == cardToDeleteID)
                    {
                        Card.cardToDoList.Remove(card);
                        Card.cardInprogressList.Remove(card);
                        Card.cardDoneList.Remove(card);

                        Card.cardList.Remove(card);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bu id'de bir kart bulunamadı. İşleme devam etmek istiyor musunuz?");
                Console.WriteLine("Evet için 1, Hayır için 2'yi tuşlayınız.");
                int selection = InputValidation();

                if (selection == 1)
                {
                    DeleteCard();
                }
                else
                {
                    loadingMainMenu();
                }
            }            

            Console.WriteLine(cardToDeleteID + " Id'li kart silinmiştir.");
            loadingMainMenu();

        }

        static void MoveCard() // Main Menu Option 4 - Moves cards among boards
        {
            Console.WriteLine("Taşımak istediğiniz kartın id'sini giriniz:");
            int cardToMoveID = InputValidation();

            if (Card.cardList.Exists(x => x.CardID == cardToMoveID))
            {
                foreach (Card card in Card.cardList)
                {
                    if (card.CardID == cardToMoveID)
                    {
                        Console.WriteLine();
                        Console.WriteLine(cardToMoveID + " id'li kartı taşımak istediğiniz boardu seçiniz:");
                        Console.WriteLine("1. To Do");
                        Console.WriteLine("2. In Progress");
                        Console.WriteLine("3. Done");
                        Console.WriteLine();
                        int boardToMoveInto = InputValidation();

                        Card.cardToDoList.Remove(card);
                        Card.cardInprogressList.Remove(card);
                        Card.cardDoneList.Remove(card);

                        switch (boardToMoveInto)
                        {
                            case 1:
                                RemoveFromBoards(card);
                                Card.cardToDoList.Add(card);
                                loadingMainMenu();
                                break;

                            case 2:
                                RemoveFromBoards(card);
                                Card.cardInprogressList.Add(card);
                                loadingMainMenu();
                                break;

                            case 3:
                                RemoveFromBoards(card);
                                Card.cardDoneList.Add(card);
                                loadingMainMenu();
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("Böyle bir board bulunmamaktadır.");
                                boardToMoveInto = InputValidation();
                                break;
                        }
                    }
                }
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("Bu id'de bir kart bulunamadı. İşleme devam etmek istiyor musunuz?");
                Console.WriteLine("Evet için 1, Hayır için 2'yi tuşlayınız.");
                int selection = InputValidation();

                if (selection == 1)
                {
                    MoveCard();
                }
                else
                {
                    loadingMainMenu();
                }
            }
            
        }

        public static void RemoveFromBoards(Card card) // Removes card from all boards
        {
            Card.cardToDoList.Remove(card);
            Card.cardInprogressList.Remove(card);
            Card.cardDoneList.Remove(card);
        }

        public static int cardOwner() // Make sure task owner is valid and exists in the member list
        {
            Console.WriteLine("Kartın atanacağı kişinin id'sini seçiniz: ");
            int ownerID = int.Parse(Console.ReadLine());
            if (!OwnerCheck(ownerID))
            {
                Console.WriteLine("Bu id'de bir çalışan bulunamamıştır.");
                cardOwner();
            }

            return ownerID;
        }

        static string responsibleMemberName(int responsibleID) // matches card id with member id, in order to find task owner name
        {
            string name = "";
            foreach (Member member in Member.memberList)
            {
                if (member.memberID == responsibleID)
                {
                    name = member.memberName;
                }
            }
            return name;
        }

        static bool OwnerCheck(int id) // Checks if member exists in the complete member list
        {
            foreach (Member member in Member.memberList)
            {
                if (member.memberID == id)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public static void CardAddToBoardList() // Adds cards to related boards
        {
            foreach (Card card in Card.cardList)
            {
                if (!Card.cardToDoList.Contains(card) && card.boardState == Card.BoardState.TODO)
                {
                    Card.cardToDoList.Add(card);
                }

                else if (!Card.cardInprogressList.Contains(card) && card.boardState == Card.BoardState.INPROGRESS)
                {
                    Card.cardInprogressList.Add(card);
                }

                else if (!Card.cardDoneList.Contains(card) && card.boardState == Card.BoardState.DONE)
                {
                    Card.cardDoneList.Add(card);
                }
            }
        }

        #region Tools

        public static string CaseCorrection(string inputStr)
        {
            inputStr = inputStr[0].ToString().ToUpper() + inputStr.Substring(1).ToLower();
            return inputStr;
        }

        public static int InputValidation()
        {
            string userInput = Console.ReadLine();
            try
            {
                int input = Convert.ToInt32(userInput);
                return input;
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir giriş yapınız:");
                Console.WriteLine();
                return InputValidation();
            }
        }

        public static void loadingMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("İşlem sonlanmıştır.");
            Console.WriteLine("Ana menuye aktarılıyorsunuz...");
            Console.WriteLine();
            MainMenuOptions();
        }

        #endregion
    }

}
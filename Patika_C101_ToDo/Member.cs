using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Patika_C101_ToDo
{
    public class Member:Card
    {
        public string memberName { get; }
        public int memberID { get; }

        public Nullable<int> cardResponsibility;

        public static List<Member> memberList = new List<Member>();

        public Member(string name, int id, int cardID)
        {
            this.memberName = name;
            this.memberID = id;
            CardID = cardID;
        }

        public Member(string name, int id)
        {
            this.memberName = name;
            this.memberID = id;     
        }

        public static void DefaultMembers()
        {
            Member.memberList.Add(new Member("Aragorn Elessar", 101, 1));
            Member.memberList.Add(new Member("Arwen Evenstar", 102, 2));
            Member.memberList.Add(new Member("Frodo Baggins", 103,3));
            Member.memberList.Add(new Member("Boromir Rohannes", 104));
        }

        public static void Print()
        {
            Console.WriteLine(memberList[0].CardID);
            Console.WriteLine(cardList[(memberList[0].CardID)-1].CardTopic);
        }
        

    }
}

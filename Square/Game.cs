using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackGame
    {
        //Card[] Deck = new Card[52];

        private int count;
        private int count1;
        public int sum, sum1, j = 1;
        private List<Card> Deck = new List<Card>();
        private List<Card> YourDeck = new List<Card>();
        private List<Card> CompDeck = new List<Card>();
        public Random rand = new Random();
        public BlackJackGame()
        {
            count = 0;
            count1 = 0;
            sum = 0;
            sum1 = 0;
        }

        public void CreateDeck()
        {
            for (int rankVal = 2; rankVal < 12; rankVal++)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    if (rankVal == 5)
                        continue;
                    Deck.Add(new Card() { suitname = (Suitnames)suitVal, cardname = (Cardnames)rankVal });

                }
            }

        }
        public void GiveTwoCards()
        {
            for (int i = 0; i < 2; i++)
            {
                YourDeck.Add(Deck[rand.Next(0, 36)]);
                if (YourDeck[i].cardname == Cardnames.Ace)
                    count++;
                if (count == 2)
                    Console.WriteLine("You WIN!!!");
                CompDeck.Add(Deck[rand.Next(0, 36)]);
                if (CompDeck[i].cardname == Cardnames.Ace)
                    count1++;
                if (count == 2)
                    Console.WriteLine("You WIN!!!");
                if (count1 == 2)
                    Console.WriteLine("You LOST!!!");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(YourDeck[i].cardname + "   of    " + YourDeck[i].suitname);
                sum += (int)YourDeck[i].cardname;
                sum1 += (int)CompDeck[i].cardname;
            }
            Console.WriteLine("Сумма ваших очков   " + sum);
        }
        public void GiveOneMoreCard()
        {
            YourDeck.Add(Deck[rand.Next(0, 36)]);
            sum += (int)YourDeck[YourDeck.Count - 1].cardname;
            Console.WriteLine(YourDeck[YourDeck.Count - 1].cardname + "   of   " + YourDeck[YourDeck.Count - 1].suitname);
            Console.WriteLine("Сумма ваших очков   " + sum);
            CompDeck.Add(Deck[rand.Next(0, 36)]);

            sum1 += (int)CompDeck[CompDeck.Count - 1].cardname;
            if (sum == 21)
            {
                Console.WriteLine("You win");
            }
            if (sum1 == 21)
            {
                Console.WriteLine("You loose");
            }

            Check1();

        }

        public void Check()
        {
            if (sum < 21)
            {
                if (21 - sum < 21 - sum1)
                {
                    Console.WriteLine("You win, computer points - " + sum1);
                }
                else
                {
                    Console.WriteLine("You loose, computer points - " + sum1);
                }
            }
            Check1();
        }

        public void Check1()
        {
            if (sum > 21)
            {
                if (sum - 21 < sum1 - 21)
                {
                    Console.WriteLine("You win, computer points - " + sum1);
                }
                else
                {
                    Console.WriteLine("You loose, computer points - " + sum1);
                }

            }
            
        }
    }

}










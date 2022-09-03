// System;
namespace lab1._1
{
    internal class driver
    {
        static public void Main(string[] args)
        {/// not sure where i went wrong with establishing this loop and why it wont loop prperly

            Card card = new Card();
            Console.WriteLine($"The default card is {card.ToString()}");

            Console.WriteLine("hit enter and then enter a non-negative integer between 1-52");
            int userinput = Convert.ToInt32(Console.ReadLine());

            while (userinput >= 1 && userinput <= 52)
            {
                /// not sure why it isnt looping properly 
                userinput = Convert.ToInt32(Console.ReadLine());
                Card usercard = new Card(userinput);
                Console.WriteLine($"your card is {usercard} ");
                Console.WriteLine("Hit enter once and enter a non-negative integer between 1-52");
                Console.ReadLine();


                if (userinput == -1)
                {
                    break;
                }


                ShowDeck();
            }
            


        }

        private static void ShowDeck()
        {/// method to generate/ show deck (works)

            string Deck;
           
            for(int i = 0; i <= 52; i++)
            {
                Card card = new Card(i);
                Deck =  card.ToString();
                Console.WriteLine(Deck); 
            }
        
        }

            
   




    }

}





    





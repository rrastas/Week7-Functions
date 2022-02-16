using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisestage oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number: '1', '2' või '3'");
            char userNumber = Convert.ToChar(Console.ReadLine());

            

            switch (userNumber)
            {
                case '1':
                    UserNameBackwards(userName);
                    break;
                case '2':
                    UserNameFirstLetter(userName);
                    break;
                case '3':
                    UserNameLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void UserNameBackwards(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void UserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void UserNameLenght(string userInput)
        {
            Console.WriteLine($"Sinu eesnime pikkuseks on {userInput.Length} sümbolit");
        }
    }
}

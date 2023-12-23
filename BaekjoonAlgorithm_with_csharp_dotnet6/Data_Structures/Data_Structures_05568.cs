using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_05568
    {
        static int NUMBER_OF_CARD = 0;
        static int NUMBER_OF_SELECT = 0;
        static string[] card;
        static Boolean[] visited;
        static HashSet<string> hs = new HashSet<string>();

        static void SelectCard(int remain, string k)
        {
            if (remain == 0)
            {
                hs.Add(k);
                return;
            }

            for(int i = 0; i < NUMBER_OF_CARD; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    SelectCard(remain - 1, k + card[i]);
                    visited[i] = false;
                }
            }
        }

        public void solve()
        {
            NUMBER_OF_CARD = Int32.Parse(Console.ReadLine());
            NUMBER_OF_SELECT = Int32.Parse(Console.ReadLine());
            card = new string[NUMBER_OF_CARD];
            
            for (int i = 0; i < NUMBER_OF_CARD; i++)
            {
                card[i] = Console.ReadLine();
            }
            visited = new bool[NUMBER_OF_CARD];
            SelectCard(NUMBER_OF_SELECT, "");

            Console.WriteLine(hs.Count);
        }
    }
}

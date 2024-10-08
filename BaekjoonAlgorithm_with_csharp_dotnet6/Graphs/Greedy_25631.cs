namespace BaekjoonAlgorithm_with_csharp_dotnet6.Graphs
{
    class Greedy_25631
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] martroshkas = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int max = 0;
            for (int i = 0; i < N; i++)
            {
                if (dictionary.ContainsKey(martroshkas[i]))
                {
                    dictionary[martroshkas[i]]++;
                }
                else
                {
                    dictionary.Add(martroshkas[i], 1);
                }

                if (max < dictionary[martroshkas[i]])
                    max = dictionary[martroshkas[i]];
            }

            int count = 0;
            while (true)
            {
                if (N == 0) break;

                foreach(var item in dictionary)
                {
                    if(item.Value > 0)
                    {
                        dictionary[item.Key]--;
                        N--;
                    }
                }

                count++;
            }

            Console.Write(count);
        }
    }
}

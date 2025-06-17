namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05778
    {
        public void solve()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                if (N == 0 && M == 0)
                    break;

                string[] ticketsInput = Console.ReadLine().Split();
                Dictionary<int, int> ticketCounts = new Dictionary<int, int>();

                for (int i = 0; i < M; i++)
                {
                    int ticket = int.Parse(ticketsInput[i]);

                    if (ticketCounts.ContainsKey(ticket))
                        ticketCounts[ticket]++;
                    else
                        ticketCounts[ticket] = 1;
                }

                int clonedTicketTypes = 0;
                foreach (var count in ticketCounts.Values)
                {
                    if (count > 1)
                        clonedTicketTypes++;  // 중복된 번호 하나로 1 증가
                }

                Console.WriteLine(clonedTicketTypes);
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16727
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int p1 = Int32.Parse(line.Split(" ")[0]);
            int s1 = Int32.Parse(line.Split(" ")[1]);

            line = Console.ReadLine();
            int s2 = Int32.Parse(line.Split(" ")[0]);
            int p2 = Int32.Parse(line.Split(" ")[1]);

            // p팀이 다득점으로 이기는 경우
            if ((p1 + p2) > (s1 + s2))
                Console.Write("Persepolis");
            // s팀이 다득점으로 이기는 경우
            else if ((p1 + p2) < (s1 + s2))
                Console.Write("Esteghlal");
            // 동점인 경우
            else if((p1 + p2) == (s1 + s2))
            {
                // p팀이 원정 다득점으로 이기는 경우
                if(p2 > s1)
                    Console.Write("Persepolis");
                // s팀이 원정 다득점으로 이기는 경우
                else if (p2 < s1)
                    Console.Write("Esteghlal");
                else
                    Console.Write("Penalty");
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27880
    {
        public void solve()
        {
            int answer = 0;
            while (true)
            {
                string line = Console.ReadLine()!;

                if (string.IsNullOrEmpty(line))
                {
                    Console.Write(answer);
                    return;
                }

                string type = line.Split(" ")[0];
                int step = Int32.Parse(line.Split(" ")[1]);

                if (type == "Es")
                    answer += (step * 21);
                else if (type == "Stair")
                    answer += (step * 17);
            }
        }
    }
}

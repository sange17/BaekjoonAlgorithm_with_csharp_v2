namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31994
    {
        public void solve()
        {
            int max = 0;
            string result = "";
            for (int i = 0; i < 7; i++)
            {
                string line = Console.ReadLine()!;
                string seminar = line.Split(" ")[0];
                int people = Int32.Parse(line.Split(" ")[1]);

                if (max < people)
                {
                    max = people;
                    result = seminar;
                }
            }

            Console.Write(result);
        }
    }
}

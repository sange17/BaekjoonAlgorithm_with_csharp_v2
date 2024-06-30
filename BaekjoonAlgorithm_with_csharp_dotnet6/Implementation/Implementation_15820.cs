using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15820
    {
        public void solve()
        {
            string? line = Console.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                int s1 = Int32.Parse(line.Split(" ")[0]);
                int s2 = Int32.Parse(line.Split(" ")[1]);

                int sampleWrong = 0;
                int systemWrong = 0;
                for(int i = 0; i < s1; i++)
                {
                    string? testLine = Console.ReadLine();
                    if (!string.IsNullOrEmpty(testLine))
                    {
                        string[] testcase = testLine.Split(" ");

                        if (testcase[0] != testcase[1])
                        {
                            Console.Write("Wrong Answer");
                            return;
                        }
                    }
                }

                for (int i = 0; i < s2; i++)
                {
                    string? testLine = Console.ReadLine();
                    if (!string.IsNullOrEmpty(testLine))
                    {
                        string[] testcase = testLine.Split(" ");

                        if (testcase[0] != testcase[1])
                        {
                            Console.Write("Why Wrong!!!");
                            return;
                        }
                    }
                }

                Console.Write("Accepted");
            }
        }
    }
}

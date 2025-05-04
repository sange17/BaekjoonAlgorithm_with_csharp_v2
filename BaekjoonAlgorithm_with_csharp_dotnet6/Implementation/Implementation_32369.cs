using System.Runtime.InteropServices;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32369
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int N = Int32.Parse(line.Split(" ")[0]);
            int A = Int32.Parse(line.Split(" ")[1]);
            int B = Int32.Parse(line.Split(" ")[2]);

            int lengthA = 1;
            int lengthB = 1;
            int temp = 0;

            for (int i = 0; i < N; i++)
            {
                lengthA += A;
                lengthB += B;

                if (lengthA < lengthB)
                {
                    temp = lengthB;
                    lengthB = lengthA;
                    lengthA = temp;
                }
                else if(lengthA == lengthB)
                {
                    lengthB--;
                }
            }

            Console.Write(lengthA + " " + lengthB);
        }
    }
}

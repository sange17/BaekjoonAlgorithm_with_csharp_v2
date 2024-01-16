using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_05052
    {
        static bool isConsistent(int N, string[] phone_number)
        {
            for(int i = 0; i < N - 1; i++)
            {
                if (phone_number[i + 1].StartsWith(phone_number[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(Console.ReadLine());
                string[] phone_number = new string[N];

                for(int j = 0; j < N; j++)
                {
                    phone_number[j] = Console.ReadLine();
                }

                Array.Sort(phone_number);

                if(isConsistent(N, phone_number))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_26004
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int H = 0;
            int I = 0;
            int A = 0;
            int R = 0;
            int C = 0;

            for (int i = 0; i < n; i++)
            {
                switch (line[i])
                {
                    case 'H':
                        H++; break;
                    case 'I':
                        I++; break;
                    case 'A':
                        A++; break;
                    case 'R':
                        R++; break;
                    case 'C':
                        C++; break;
                }
            }

            Console.Write(Math.Min(H, Math.Min(I, Math.Min(A, Math.Min(R, C)))));
        }
    }
}

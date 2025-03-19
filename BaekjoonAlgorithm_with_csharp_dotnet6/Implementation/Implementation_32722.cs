namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32722
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine()!);
            int b = Int32.Parse(Console.ReadLine()!);
            int c = Int32.Parse(Console.ReadLine()!);

            bool check = false;
            if (a == 1 && b == 6 && c == 2)
                check = false;
            else if (a == 1 && b == 6 && c == 5)
                check = false;
            else if (a == 1 && b == 8 && c == 2)
                check = false;
            else if (a == 1 && b == 8 && c == 5)
                check = false;
            else if (a == 3 && b == 6 && c == 2)
                check = false;
            else if (a == 3 && b == 6 && c == 5)
                check = false;
            else if (a == 3 && b == 8 && c == 2)
                check = false;
            else if (a == 3 && b == 8 && c == 5)
                check = false;
            else
                check = true;

            if(check)
                Console.Write("EI");
            else
                Console.Write("JAH");
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31518
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string wheel1 = Console.ReadLine()!;
            string wheel2 = Console.ReadLine()!;
            string wheel3 = Console.ReadLine()!;

            if(wheel1.Contains('7') && wheel2.Contains('7') && wheel3.Contains('7'))
                Console.Write("777");
            else
                Console.Write("0");
        }
    }
}

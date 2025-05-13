namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27960
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int num1 = int.Parse(line.Split(" ")[0]);
            int num2 = int.Parse(line.Split(" ")[1]);
            int result = num1 ^ num2;
            
            Console.Write(result);
        }
    }
}

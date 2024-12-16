namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_29790
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            bool one = false;
            bool two = false;
            if (array[0] >= 1000) one = true;
            if (array[1] >= 8000 || array[2] >= 260) two = true;

            if(one && two) Console.Write("Very Good");
            else if(one) Console.Write("Good");
            else Console.Write("Bad");
        }
    }
}

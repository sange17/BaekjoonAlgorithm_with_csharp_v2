namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32400
    {
        public void solve()
        {
            double[] array = Console.ReadLine()!.Split(" ").Select(double.Parse).ToArray();

            // Alice
            int index = Array.IndexOf(array, 20);
            double aliceResult = 0;
            if (index == 0)
                aliceResult = (array[19] + array[0] + array[1]) / 3;
            else if (index == 19)
                aliceResult = (array[19] + array[18] + array[0]) / 3;
            else
                aliceResult = (array[index] + array[index - 1] + array[index + 1]) / 3;

            // Bob
            double sum = array.Sum();
            double bobResult = sum / 20;
            if (aliceResult > bobResult)
                Console.Write("Alice");
            else if (aliceResult < bobResult)
                Console.Write("Bob");
            else
                Console.Write("Tie");
        }
    }
}


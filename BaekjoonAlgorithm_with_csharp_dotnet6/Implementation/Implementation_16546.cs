namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16546
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] strArray = Console.ReadLine().Split(" ");
            bool[] boolArray = new bool[n];

            for(int i = 0; i < strArray.Length; i++)
            {
                boolArray[Int32.Parse(strArray[i]) - 1] = true;
            }

            for(int i = 0; i < boolArray.Length; i++)
            {
                if (!boolArray[i])
                {
                    Console.Write(i + 1);
                    break;
                }
            }
        }
    }
}

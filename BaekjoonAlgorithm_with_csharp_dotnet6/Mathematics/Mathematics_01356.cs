namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01356
    {
        public void solve()
        {
            string input = Console.ReadLine()!;
            int length = input.Length;
            bool isEugeneNumber = false;

            for (int i = 1; i < length; i++)
            {
                string left = input.Substring(0, i);
                string right = input.Substring(i);

                int leftProduct = 1;
                int rightProduct = 1;

                foreach (char c in left)
                    leftProduct *= c - '0';

                foreach (char c in right)
                    rightProduct *= c - '0';

                if (leftProduct == rightProduct)
                {
                    isEugeneNumber = true;
                    break;
                }
            }

            Console.WriteLine(isEugeneNumber ? "YES" : "NO");
        }
    }
}

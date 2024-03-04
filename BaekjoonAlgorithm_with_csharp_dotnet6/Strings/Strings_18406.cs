namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_18406
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int lineLength = line.Length;

            int sumLeft = 0;
            int sumRight = 0;
            for(int i = 0; i < lineLength / 2; i++)
            {
                sumLeft += line[i];
                sumRight += line[i + (lineLength / 2)];
            }

            if (sumLeft == sumRight)
                Console.Write("LUCKY");
            else
            {
                Console.Write("READY");
            }
        }
    }
}

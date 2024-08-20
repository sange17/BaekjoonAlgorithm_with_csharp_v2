namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17042
    {
        public void solve()
        {
            char wizard = Console.ReadLine()![0];
            int n = Int32.Parse(Console.ReadLine()!);
            int count = 1;
            bool[] array = new bool[26];
            array[wizard - 65] = true;

            for (int i = 0; i < n; i++)
            {
                char[] wizards = Console.ReadLine()!.ToCharArray();

                if (wizard == wizards[2] && array[wizards[0] - 65] == true)
                {
                    wizard = wizards[0];
                    continue;
                }

                if (wizard == wizards[2] && array[wizards[0] - 65] == false)
                {
                    count++;
                    wizard = wizards[0];
                    array[wizards[0] - 65] = true;
                }
            }

            Console.Write(wizard + "\n" + count);
        }
    }
}

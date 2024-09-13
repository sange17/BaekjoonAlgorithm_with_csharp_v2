namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16316
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string[] array = Console.ReadLine()!.Split(" ");

            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == "mumble" || Int32.Parse(array[i]) == (i + 1)) 
                    continue;
                else if (Int32.Parse(array[i]) != (i + 1))
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
                Console.Write("makes sense");
            else
                Console.Write("something is fishy");
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_16861
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            while (true)
            {
                char[] array = n.ToString().ToCharArray();

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += (array[i] - 48);
                }

                if(n % sum == 0)
                {
                    Console.Write(n);
                    break;
                }
                else
                {
                    n++;
                }
            }
        }
    }
}

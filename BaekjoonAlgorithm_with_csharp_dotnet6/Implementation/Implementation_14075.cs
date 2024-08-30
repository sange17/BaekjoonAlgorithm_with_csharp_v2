namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_14075
    {
        public void solve()
        {
            int[] array = Array.ConvertAll(Console.ReadLine()!.ToCharArray(), c => int.Parse(c.ToString()));

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (array[i] * 2 >= 10)
                    {
                        array[i] *= 2;
                        array[i] = (array[i] / 10) + (array[i] % 10);
                    }
                    else
                    {
                        array[i] *= 2;
                    }
                }

                sum += array[i];
            }

            if (sum % 10 == 0)
            {
                Console.Write("DA");
            }
            else
            {
                Console.Write("NE");
            }
        }
    }
}

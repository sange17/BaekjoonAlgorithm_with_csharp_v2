namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28702
    {
        public void solve()
        {
            int next = 0;
            for (int i = 0; i < 3; i++)
            {
                string line = Console.ReadLine()!;

                if (line != "Fizz" && line != "Buzz" && line != "FizzBuzz")
                {
                    next = Int32.Parse(line) + 3 - i;
                }
            }

            if(next % 3 == 0 && next % 5 == 0) 
            {
                Console.Write("FizzBuzz");
            }
            else if (next % 3 == 0 && next % 5 != 0)
            {
                Console.Write("Fizz");
            }
            else if (next % 3 != 0 && next % 5 == 0)
            {
                Console.Write("Buzz");
            }
            else
            {
                Console.Write(next);
            }
        }
    }
}

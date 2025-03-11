namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_11800
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);
            string[] strArray = { "Yakk", "Doh", "Seh", "Ghar", "Bang", "Sheesh" };

            for (int i = 0; i < N; i++)
            {
                int[] intArray = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                Array.Sort(intArray, (num1, num2) => num2.CompareTo(num1));

                sw.Write("Case " + (i + 1) + ": ");
                if (intArray[0] == intArray[1])
                {
                    switch (intArray[0])
                    {
                        case 1:
                            sw.WriteLine("Habb Yakk");
                            break;
                        case 2:
                            sw.WriteLine("Dobara");
                            break;
                        case 3:
                            sw.WriteLine("Dousa");
                            break;
                        case 4:
                            sw.WriteLine("Dorgy");
                            break;
                        case 5:
                            sw.WriteLine("Dabash");
                            break;
                        case 6:
                            sw.WriteLine("Dosh");
                            break;
                    }
                }
                else
                {
                    if (intArray[0] == 6 && intArray[1] == 5)
                        sw.WriteLine("Sheesh Beesh");
                    else
                        sw.WriteLine(strArray[intArray[0] - 1] + " " + strArray[intArray[1] - 1]);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}

using System.Runtime.InteropServices;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06830
    {
        public void solve()
        {
            int coldest = Int32.MaxValue;
            string cityName = string.Empty;
            while (true)
            {
                string line = Console.ReadLine()!;
                if (string.IsNullOrEmpty(line))
                {
                    Console.Write(cityName);
                    break;
                }

                if (coldest > Int32.Parse(line.Split(" ")[1]))
                {
                    coldest = Int32.Parse(line.Split(" ")[1]);
                    cityName = line.Split(" ")[0];
                }
            }
        }
    }
}

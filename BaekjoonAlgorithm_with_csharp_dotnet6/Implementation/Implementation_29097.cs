using System.Collections;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_29097
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("Joffrey", array[0] * array[3]);
            map.Add("Robb", array[1] * array[4]);
            map.Add("Stannis", array[2] * array[5]);

            map.OrderBy(x => x.Value).OrderBy(x => x.Key);

            foreach (KeyValuePair<string, int> pair in map)
            {
                if(pair.Value == map.Values.Max())
                    Console.Write(pair.Key + " ");
            }
        }
    }
}

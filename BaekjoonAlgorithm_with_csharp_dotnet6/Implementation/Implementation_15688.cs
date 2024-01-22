using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15688
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = Int32.Parse(sr.ReadLine());
            }

            Array.Sort(nums);

            for(int i = 0; i < n; i++)
            {
                sw.WriteLine(nums[i]);
            }

            sr.Close();
            sw.Close();
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_03181
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string[] array = new string[] { "i", "pa", "te", "ni", "niti", "a", "ali", "nego", "no", "ili" };
            string[] inputArr = sr.ReadLine()!.Split(" ");

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (array.Contains(inputArr[i]) && i != 0) continue;

                string temp = inputArr[i].ToUpper();
                sw.Write(temp[0]);
            }

            sr.Close();
            sw.Close();
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01526
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            for (int i = N; i >= 4; i--)
            {
                string strNum = i.ToString();
                if (strNum.Contains('0')
                 || strNum.Contains('1') 
                 || strNum.Contains('2')
                 || strNum.Contains('3')
                 || strNum.Contains('5')
                 || strNum.Contains('6')
                 || strNum.Contains('8')
                 || strNum.Contains('9'))
                {
                    continue;
                }
                else
                {
                    Console.Write(strNum);
                    break;
                }
            }
        }
    }
}

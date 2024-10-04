namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_29731
    {
        public void solve()
        {
            string[] array = { "Never gonna give you up"
                              ,"Never gonna let you down"
                              ,"Never gonna run around and desert you"
                              ,"Never gonna make you cry"
                              ,"Never gonna say goodbye"
                              ,"Never gonna tell a lie and hurt you"
                              ,"Never gonna stop"
                             };

            int n = Int32.Parse(Console.ReadLine()!);

            bool check = true;
            for(int i = 0; i < n; i++)
            {
                if (!array.Contains(Console.ReadLine()!))
                {
                    check = false;
                    break;
                }
            }

            if (!check)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}

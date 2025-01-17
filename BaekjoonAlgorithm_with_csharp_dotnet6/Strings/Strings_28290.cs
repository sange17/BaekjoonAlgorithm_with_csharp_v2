namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_28290
    {
        public void solve()
        {
            string line = Console.ReadLine()!;

            if (line == "fdsajkl;" || line == "jkl;fdsa")
                Console.Write("in-out");
            else if (line == "asdf;lkj" || line == ";lkjasdf")
                Console.Write("out-in");
            else if (line == "asdfjkl;")
                Console.Write("stairs");
            else if (line == ";lkjfdsa")
                Console.Write("reverse");
            else
                Console.Write("molu");
        }
    }
}

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{

    public class Participant
    {
        public int Id { get; set; }      // 참가자 번호 (1부터 시작)
        public int Score { get; set; }   // 점수
        public int Submissions { get; set; }  // 제출 횟수
        public int LastUploadTime { get; set; }  // 마지막 점수 획득 시간
    }
    internal class Implementation_14592
    {
        public void solve()
        {
            int N = int.Parse(Console.ReadLine()!); // 참가자 수
            List<Participant> participants = new List<Participant>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int score = int.Parse(input[0]);
                int submissions = int.Parse(input[1]);
                int lastUploadTime = int.Parse(input[2]);

                participants.Add(new Participant
                {
                    Id = i + 1,
                    Score = score,
                    Submissions = submissions,
                    LastUploadTime = lastUploadTime
                });
            }

            // 정렬 조건:
            // 1. 점수 내림차순
            // 2. 제출 횟수 오름차순
            // 3. 마지막 제출 시간 오름차순
            var sorted = participants
                .OrderByDescending(p => p.Score)
                .ThenBy(p => p.Submissions)
                .ThenBy(p => p.LastUploadTime)
                .ToList();

            Console.WriteLine(sorted[0].Id); // 1등 참가자의 번호 출력

        }
    }
}

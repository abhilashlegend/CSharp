class Quiz
{
    string[] question = {"Which is the capital city of India", "Where is Taj Mahal", "Which is the IT Hub of India" };

    string[] ans = {"Delhi", "Agra", "Bangalore" };

    int score = 0;

    public void play()
    {
        for(int i = 0; i < question.Length; i++)
        {
            Console.WriteLine(question[i]);
            string answer = Console.ReadLine();
            if(answer == ans[i])
            {
                score++;
            }
        }
        Console.WriteLine("Your score is " + score);
    }

    public static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        quiz.play();
    }

}







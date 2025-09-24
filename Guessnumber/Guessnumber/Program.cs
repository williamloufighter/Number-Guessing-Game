//隨機數(Random)
//迴圈(while)
//判斷式(if-else)
//輸入輸出(Console.ReadLine() / Console.WriteLine())
//例外處理(int.TryParse)

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int answer = random.Next(1,101);
        int guess = 0;
        int attempt = 0;
        Console.WriteLine("歡迎來到猜數字遊戲!");
        Console.WriteLine("想好一個1~100間數字並開始猜吧");

        while(guess != answer)
        {
            Console.WriteLine("請輸入你的猜測:");
            string input = Console.ReadLine();

            if(int.TryParse (input, out guess))
            {
                attempt++;
                if (guess > answer)
                {
                    Console.WriteLine("太大囉");
                }
                else if (guess < answer)
                {
                    Console.WriteLine("太小囉");
                }
                else
                {
                    Console.WriteLine($"恭喜猜中!你總共猜了{attempt}次");
                }
             }
            else
            {
                Console.WriteLine("請輸入有效數字!");
            }
        }
    }
}
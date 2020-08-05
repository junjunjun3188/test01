using System;
namespace Calculator2.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            //タイトルをC＃コンソール電卓アプリとして表示します。
            Console.WriteLine("Console calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                //変数を宣言し、空に設定します。
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                //最初の番号を入力するようにユーザーに依頼します。
                Console.WriteLine("Type a number,and then press Enter:");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                //2番目の番号を入力するようにユーザーに依頼します。
                Console.WriteLine("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                //オペレーターを選択するようユーザーに依頼します。
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option?");

                String op = Console.ReadLine();

                try
                {
                    result = Calculator2.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result:{0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details:" + e.Message);
                }

                Console.WriteLine("--------------------\n");

                // Wait for the user to respond before closing.
                //ユーザーが応答するのを待ってから閉じます。
                Console.WriteLine("Press 'n' and Enter to close the app, or press ather key and Enter to continue:");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");// Friendly linespacing. // フレンドリーな行間
            }
            return;
        }
    }
}
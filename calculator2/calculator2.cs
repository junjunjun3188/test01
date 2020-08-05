using System;

namespace Calculator2
{
    class Calculator2
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; //Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
                                        //デフォルト値は「非数値」で、除算などの演算でエラーが発生する可能性がある場合に使用します。
              //Use a switch statement to do the math
              //switchステートメントを使用して計算を行う
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    //ユーザーにゼロ以外の除数を入力するように依頼してください。
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                //不適切なオプションエントリのテキストを返します。
                default:
                    break;
            }
            return result;
        }
    }
}
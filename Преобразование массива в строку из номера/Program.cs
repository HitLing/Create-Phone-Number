    using System;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        int counterofnumbers = 0;
        string str;
        char[] Trial = new char[14];
        for (int i = 0; i < 14; i++) {
            switch(i){
                case 0:
                    Trial[i] = Convert.ToChar("(");
                    break;
                case 4:
                    Trial[i] = Convert.ToChar(")");
                    break;
                case 5:
                    Trial[i] = Convert.ToChar(" ");
                    break;
                case 9:
                    Trial[i] = Convert.ToChar("-");
                    break;
                default:
                    Trial[i] = Convert.ToChar(Convert.ToString(numbers[counterofnumbers]));
                    counterofnumbers++;
                    break;
            }
        }
        str = new string(Trial);
        return str;
    }
}

namespace Преобразование_массива_в_строку_из_номера
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampel = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i< 10; i++) {
                Console.WriteLine(exampel[i]);
            }
            string ex = Kata.CreatePhoneNumber(exampel);
            Console.WriteLine(ex);
        }
    }
}

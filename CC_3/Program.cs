using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер кредитної карти:");
           string NCard = Console.ReadLine();
            Console.WriteLine("Вендор карти");
           GetCreditCardVendor(NCard);
            Console.WriteLine("Перевiрка валiдностi номера карти");
           IsCreditCardNumberValid(NCard);
            Console.WriteLine("Пошук наступного номера карти");
           GenerateNextCreditCardNumber(NCard);                      
            Console.WriteLine("End");
            Console.ReadLine();
        }
        static public string GetCreditCardVendor(string s)
        {
            switch (s[0])
            {
                case '4':
                    Console.WriteLine("VISA");
                    break;
                case '3':
                    switch (s[1])
                    {
                        case '4':
                            Console.WriteLine("American Express");
                            break;
                        case '7':
                            Console.WriteLine("American Express");
                            break;
                        case '5':
                            Console.WriteLine("JCB"); //JCB
                            break;
                        default:
                            Console.WriteLine("Unknown");
                            break;
                    }
                    break;
                case '5':
                    switch (s[1])
                    {
                        // Вендор MasterCard
                        case '1':
                            Console.WriteLine("MasterCard");
                            break;
                        case '2':
                            Console.WriteLine("MasterCard");
                            break;
                        case '3':
                            Console.WriteLine("MasterCard");
                            break;
                        case '4':
                            Console.WriteLine("MasterCard");
                            break;
                        case '5':
                            Console.WriteLine("MasterCard");
                            break;
                        // Вендор Maestro
                        case '0':
                            Console.WriteLine("Maestro");
                            break;
                        case '6':
                            Console.WriteLine("Maestro");
                            break;
                        case '7':
                            Console.WriteLine("Maestro");
                            break;
                        case '8':
                            Console.WriteLine("Maestro");
                            break;
                        case '9':
                            Console.WriteLine("Maestro");
                            break;
                        default:
                            Console.WriteLine("Unknown");
                            break;
                    }
                    break;
                case '6':
                    Console.WriteLine("Maestro");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
          return s;

        }
        static bool IsCreditCardNumberValid(string s)
        {

            char[] number = s.ToCharArray();    // Конвертація строки в масив символів
            Array.Reverse(number);              // Реверс, для можливості дій над числами з непарним індексом
            s = new string(number);
            
            int[] mas = new int[23];
            int i = 0;
            foreach (int n in s)
            {
                mas[i] = (n - 48) * (i % 2 == 0 ? 1 : 2);  
                i++;
            }

            int sum = 0;
            for (int j = 0; j < mas.Length; j++)
            {
                sum += mas[j] / 10 + mas[j] % 10;
            }

            Console.WriteLine(sum);
            Console.WriteLine("CreditCard is valid {0}", sum % 10 == 0); // Перевірка на кратність 10
                        
            return sum % 10 == 0;

        }        
        static string GenerateNextCreditCardNumber(string s)
        {
            string NewCC = "";
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')                
                {
                    NewCC = NewCC + s[i];         // Формуванння нового номера кредитної карти на основі переданого з клавіатури
                }
            }
            long cash = Int64.Parse(NewCC);       // Конвертація строки в число, для можливості інкременту нового номера карти
            pNewCC:                               // Мітка переходу 
            cash++;
            NewCC = Convert.ToString(cash);       // Конвертація чисда в строку

            Console.WriteLine(NewCC);
            
            if (IsCreditCardNumberValid(NewCC))  // Перевірка валідності нового номера карти
            {
                Console.WriteLine("Next Credit Card is valid {0}", IsCreditCardNumberValid(NewCC)); 
            }
            else
                goto pNewCC;                      // Перехід на до мітки для повторення збільшення значення номера карти

            return NewCC;
        }
    }
}

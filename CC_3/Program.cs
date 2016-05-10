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
            // Вичначення точної довжини номера карти, без врахування пробілів та розділових знаків.
            string KS = "";                         //
                                                    // 
            for (int i = 0; i < s.Length; i++)      //
            {                                       // 
                if (s[i] != ' ')                    //
                {                                   //
                    KS = KS + s[i];                 // 
                }                                   //    
            }                                       //

            switch (s[0])
            {
                case '4':

                    if (KS.Length == 13)
                    {
                        Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                        Console.WriteLine("VISA");
                    }
                    else if (KS.Length == 16)
                    {
                        Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                        Console.WriteLine("VISA");
                    }
                    else if (KS.Length == 19)
                    {
                        Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                        Console.WriteLine("VISA");
                    }
                    else
                    {
                        Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    break;
                case '3':
                    switch (s[1])
                    {
                        case '4':
                            if (KS.Length == 15)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("American Express");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '7':
                            if (KS.Length == 15)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("American Express");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '5':
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("JCB"); //JCB
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
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
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("MasterCard");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '2':
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("MasterCard");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '3':
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("MasterCard");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '4':
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("MasterCard");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '5':
                            if (KS.Length == 16)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("MasterCard");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        // Вендор Maestro
                        case '0':
                            if (KS.Length >= 12 && KS.Length <= 19)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("Maestro");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '6':
                            if (KS.Length >= 12 && KS.Length <= 19)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("Maestro");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '7':
                            if (KS.Length >= 12 && KS.Length <= 19)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("Maestro");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '8':
                            if (KS.Length >= 12 && KS.Length <= 19)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("Maestro");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        case '9':
                            if (KS.Length >= 12 && KS.Length <= 19)
                            {
                                Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                                Console.WriteLine("Maestro");
                            }
                            else
                            {
                                Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                                Console.ReadLine();
                                Environment.Exit(-1);
                            }
                            break;
                        default:
                            Console.WriteLine("Unknown");
                            break;
                    }
                    break;
                case '6':
                    if (KS.Length >= 12 && KS.Length <= 19)
                    {
                        Console.WriteLine("Номер вiдповiдає кiлькостi символiв");
                        Console.WriteLine("Maestro");
                    }
                    else
                    {
                        Console.WriteLine("Номер не вiдповiдає кiлькостi символiв");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
            return s;

        }
        static bool IsCreditCardNumberValid(string s)
        {

            string NewNumber = "";

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != ' ')
                {
                    NewNumber = NewNumber + s[j];
                }
            }
            // --------------------------------------------------------
            if (NewNumber.Length % 2 == 0)
            {
                char[] number = NewNumber.ToCharArray();    // Конвертація строки в масив символів
                Array.Reverse(number);              // Реверс, для можливості дій над числами з непарним індексом
                NewNumber = new string(number);
            }
            else
            {
                char[] number = NewNumber.ToCharArray();
                NewNumber = new string(number);
            }

            int[] mas = new int[23];
            int i = 0;
            foreach (int n in NewNumber)
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

            switch (s[0])
            {
                case '3':
                    if ((s[1] == '4') && (NewCC[1] == '5'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else if ((s[1] == '7') && (NewCC[1] == '8'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else if ((s[2] == '8') && (NewCC[2] == '9'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else
                    {
                        goto SearchNextNumber;
                    }
                    break;

                case '4':
                    if ((s[0] == '4') && (NewCC[0] == '5'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else
                    {
                        goto SearchNextNumber;
                    }
                    break;
                case '5':
                    if ((s[1] == '0') && (NewCC[1] == '1'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else if ((s[1] == '5') && (NewCC[1] == '6'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else
                    {
                        goto SearchNextNumber;
                    }
                    break;
                case '6':
                    if ((s[0] == '9') && (NewCC[0] == '0'))
                    {
                        Console.WriteLine("Введений номер {0} остатнiй \"{1}\" валiдний iз дiапазону вендора", s, IsCreditCardNumberValid(s));
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else
                    {
                        goto SearchNextNumber;
                    }
                    break;
            }



            SearchNextNumber:

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

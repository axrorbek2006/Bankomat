using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Bankomat
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        private int lang = 0;
        //private bool parol = false;
        private  int Parol = 0506;
        private decimal Balans = 5000000;
        private bool davomettirish = true;
        private int count = 1;

        public Bankomat(int id, string adres)
        {
            Id = id;
            Adress = adres;
        }

        public void ChooseLang()
        {

            int num;
            Console.WriteLine(" 1 : UZ \n 2 : ENG");
            Console.Write(" : ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Assalamu alaykum ");

                    lang = 1;
                    break;

                case 2:
                    Console.WriteLine(" Hello ");

                    lang = 2;
                    break;

            }
            Console.WriteLine();
        }
        public void pin()
        {
            int num;
            switch (lang)
            {
                case 1:
                    Console.Write(" Parol : ");
                    num = Convert.ToInt32(Console.ReadLine());
                    while (!( Parol == num) && count != 3)
                    {
                        count++;
                        Console.WriteLine();
                        Console.WriteLine("Parol Xato ! \n 1 Qayta kritish : \n 2 To'xtatish : ");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Parolni qayta kriting : ");
                                Parol = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                davomettirish = false;
                                return;

                        }
                        if (count == 3)
                        {
                            davomettirish = false;
                            Console.WriteLine(" Karta bloklandi !");
                        }
                    }
                    break;
                case 2:
                    Console.Write(" Pin : ");
                    num = Convert.ToInt32(Console.ReadLine());
                    while (!(Parol == num) && count != 3)
                    {
                        count++;
                        Console.WriteLine(" Error pin ! \n 1 Enter again \n 2 Stop ");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Console.Write(" Enter pin again : ");
                                Parol = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                davomettirish = false;
                                return;

                        }
                        if(count  == 3)
                        {
                            davomettirish = false;
                            Console.WriteLine(" Card is blocked !");
                        }
                    }
                    break;
               
            }
            Console.WriteLine();

        }
        public void selectOpr()
        {
            if (davomettirish)
            {
                decimal sum = 0;
                int num = 0;
                switch (lang)
                {

                    case 1:
                    boshlanish:
                        Console.WriteLine();
                        Console.WriteLine(" 1 Pul yechish : \n 2 Balansni tekshirish : \n 3 Parolni o'zgartirish : \n 4 Chiqish");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Console.Write(" Summa : ");
                                sum = Convert.ToInt32(Console.ReadLine());
                                if (sum < Balans)
                                {
                                    Console.WriteLine(" kartangizdan " + sum + " yechib olindi");
                                    Balans -= sum;
                                }
                                else
                                {
                                    Console.WriteLine(" Kartada mablag' yetarli emas !");

                                }
                                goto boshlanish;
                                break;
                            case 2:
                                Console.WriteLine(" Balans : " + Balans);
                                Console.WriteLine();
                                goto boshlanish;
                                break;

                            case 3:
                                Console.Write(" yangi parolni kriting : ");
                                Parol = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" Parol yangilandi ! ");
                                goto boshlanish;
                                break;

                            case 4:
                                return;


                        }
                        break;

                    case 2:
                    boshlanish2:
                        Console.Write(" 1 Withdraw money: \n 2 Check balance: \n 3 Change password: \n 4 Exit");
                        num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                Console.Write(" Amount : ");
                                sum = Convert.ToInt32(Console.ReadLine());
                                if (sum < Balans)
                                {
                                    Console.WriteLine(" " + sum + " was withdrawn from your card");
                                    Balans -= sum;
                                }
                                else
                                {
                                    Console.WriteLine(" Insufficient funds on your card!");
                                }
                                goto boshlanish2;
                                break;

                            case 2:
                                Console.WriteLine(" Balans : " + Balans);
                                Console.WriteLine();
                                goto boshlanish2;
                                break;

                            case 3:
                                Console.Write(" enter new parol : ");
                                Parol = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(" Pin updated ");
                                goto boshlanish2;
                                break;

                            case 4:
                            
                            return;

                        }
                        break;                  
                }

                Console.WriteLine("");

            }
        }
    }
}

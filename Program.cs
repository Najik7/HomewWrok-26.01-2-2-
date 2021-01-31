using System;

namespace Д.з__4__2_2_
{
    class Program
    {
        public class Converter
        {
            public double eur { get; set; }
            public double usd { get; set; }
            public double rub { get; set; }
            public double som { get; set; }


            public Converter(double eur, double usd, double rub)
            {
                this.eur = eur;
                this.usd = usd;
                this.rub = rub;
                
            }
            
            public void GetInfo()
            {
                Console.WriteLine(usd);
                Console.WriteLine(eur);
                Console.WriteLine(rub);
            }


            public double SomToUsd(double som)
            {
                return som / this.usd;
            }

            public double SomToEur(double som)
            {
                return som / this.eur;
            }

            public double SomToRub(double som)
            {
                return som / this.rub;
            }


            public double UsdToSom(double som)
            {
                return this.usd * som;
            }
            public double EurToSom(double som)
            {
                return this.eur * som;
            }
            public double RubToSom(double som)
            {
                return this.rub * som;
            }


        }

        static void Main(string[] args)
        {
            
            double usd = 11.38;
            
            double eur = 13.81;
            
            double rub = 0.15;
            
            

            Converter calc = new Converter(usd, eur, rub);
            Console.WriteLine("Сегодняшний курс по отношению к 1 евро, к 1 доллару, к 1 рублю в сомони: ");
            calc.GetInfo();

            Console.Write("Введите сумму, которую вы хотите обменять: ");
            double sum = double.Parse(Console.ReadLine());

            Console.Write("Выберите валюту обмена:\n" +
                "если хотите обменять сомони на доллары - нажмите 1\n" +
                "если хотите обменять сомони на евро - нажмите 2\n" +
                "если хотите обменять сомони на рубли - нажмите 3\n" +
                "если хотите обменять доллары на сомони - нажмите 4\n" +
                "если хотите обменять евро на сомони - нажмите 5\n" +
                "если хотите обменять доллары на сомони - нажмите 6 \n");
            int currency = int.Parse(Console.ReadLine());


            switch (currency)
            {
                case 1:
                    Console.WriteLine(calc.SomToUsd(sum)); 
                    break;
                case 2:
                    Console.WriteLine(calc.SomToEur(sum));
                    break;
                case 3:
                    Console.WriteLine(calc.SomToRub(sum));
                    break;
                case 4:
                    Console.WriteLine(calc.EurToSom(sum));
                    break;
                case 5:
                    Console.WriteLine(calc.UsdToSom(sum));
                    break;
                case 6:
                    Console.WriteLine(calc.RubToSom(sum));
                    break;
                default:
                    Console.WriteLine("Выбранна неверная валюта!");
                    break;

            }
            


        }
    }
}

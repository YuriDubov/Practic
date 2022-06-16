using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Converter
    {
        private double USD;
        private double EUR;
        private double RUB;

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double FromUsd()
        {
            return USD * 29.5;
        }
        public double FromEur()
        {
            return EUR * 30.9;
        }

        public double FromRub()
        {
            return RUB * 0.5;
        }
        public double ToUsd(double uah)
        {
            return uah * 0.034;
        }
        public double ToEur(double uah)
        {
            return uah * 0.032;
        }
        public double ToRub(double uah)
        {
            return uah * 1.92;
        }
    }
}

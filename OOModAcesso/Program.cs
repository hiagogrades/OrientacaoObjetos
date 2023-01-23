﻿using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace OOModAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            payment.DataPagamento = DateTime.Now;
        }
    }

    public class Payment
    {
        //Atalhos do .Net
        //propg
        public DateTime Teste { get; private set; }
        //prop
        public DateTime Vencimento { get; set; }

        //propfull
        private DateTime _dataPagamento;
        public DateTime DataPagamento
        {
            get {
                Console.WriteLine("Lendo o valor.");
                return _dataPagamento;
                }
            set {
                Console.WriteLine("Atribuido um valor.");
                _dataPagamento = value; 
            }
        }


        void Pagar()
        {

        }
    }
}

using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
using System;

namespace TrilhaNetPOODesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia lumia = new Nokia("123456");
            lumia.Ligar();
            lumia.ReceberLigacao();
            lumia.InstalarAplicativo("facebook");
            Iphone ios = new Iphone("654321");
            ios.Ligar();
            ios.ReceberLigacao();
            ios.InstalarAplicativo("doulingo");
        }
    }
}
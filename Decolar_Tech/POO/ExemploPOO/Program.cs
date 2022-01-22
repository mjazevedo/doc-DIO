﻿using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30,20);
            System.Console.WriteLine($"Área = {r.ObterArea()}");

            //Valores inválidos
            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(0,0);
            System.Console.WriteLine($"Área = {r2.ObterArea()}");



            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Matheus";
            // p1.Idade = 21;

            // p1.Apresentar();
        }
    }
}

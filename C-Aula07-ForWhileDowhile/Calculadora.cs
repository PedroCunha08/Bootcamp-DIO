using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Aula06_OperadoresAritimeticos
{
    public class Calculadora
    {
        public void somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");

        }
        public void subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");

        }
        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");

        }
        public void dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

        }
        public void potencia(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");

            double pot = Math.Pow(x, y);
            System.Console.WriteLine($"A potencia entre os numeros {x} e {y} é: = {pot}");
        }
    }
}
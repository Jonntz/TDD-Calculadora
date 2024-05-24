using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> ListaHistorico;

        public CalculadoraImp()
        {
            ListaHistorico = new List<string>();
        }

        public int Soma(int n1, int n2)
        {
            int resultado = n1 + n2;

            ListaHistorico.Insert(0, $"{n1} + {n2} = {resultado}");
            return resultado;
        }

        public int Subtrair(int n1, int n2)
        {
           int resultado = n1 - n2;
           ListaHistorico.Insert(0, $"{n1} - {n2} = {resultado}");
           return resultado;
        }

        public int Multiplicar(int n1, int n2)
        {
           int resultado = n1 * n2;
           ListaHistorico.Insert(0, $"{n1} * {n2} = {resultado}");
           return resultado;
        }

        public int Dividir(int n1, int n2)
        {
           int resultado = n1 / n2;
           ListaHistorico.Insert(0, $"{n1} / {n2} = {resultado}");
           return resultado;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
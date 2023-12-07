using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FiapCAVendas.Entities
{
    internal class CPF
    {
        public string Numero { get; private set; }
        public CPF(string numero)
        {            
            if (!ValidarCPF(numero))
            {
                throw new Exception("CPF inválido");
            }            
            this.Numero = numero;
        }

        public static bool ValidarCPF(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return false;
            }

            valor = valor.Replace("-", "").Replace(".", "").Trim();

            if (valor.Length != 11)
            {
                return false;
            }

            bool digitosIdenticos = true;

            for (int i = 1; i < 11 && digitosIdenticos; i++)
            {
                if (valor[i] != valor[0])
                {
                    digitosIdenticos = false;
                }
            }

            if (digitosIdenticos || !Regex.IsMatch(valor, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
            {
                return false;
            }

            string num = valor.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(num[i].ToString()) * (10 - i);
            }

            int digito1 = 11 - (soma % 11);

            if (digito1 > 9)
            {
                digito1 = 0;
            }

            soma = 0;
            num += digito1;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(num[i].ToString()) * (11 - i);
            }

            int digito2 = 11 - (soma % 11);

            if (digito2 > 9)
            {
                digito2 = 0;
            }

            num += digito2;
            return valor.EndsWith(num.Substring(num.Length - 2));
        }

    }
}

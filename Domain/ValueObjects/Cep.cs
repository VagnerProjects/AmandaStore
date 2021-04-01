using Microsoft.Practices.EnterpriseLibrary.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class Cep
    {
        public const int Maxlength = 10;
        private string Numero;

        protected Cep() { }

        public Cep(string pCep)
        {
            Numero = pCep;
        }

        public void SetCep(string cepNumero)
        {
            ///COMENTADO TEMPORARIAMENTE, ENTENDER O PQ RETORNA CEP INVALIDO
            Numero = cepNumero.Trim().Replace("-", "");


            if (!string.IsNullOrEmpty(cepNumero))
            {
                //Guard.validaSize(cepNumero, Maxlength);

                var regex = new Regex(@"^\d{5}-\d{3}$");
                var match = regex.Match(cepNumero);

                if (match.Success)
                    Numero = cepNumero.Trim().Replace("-", "");
                else
                    throw new Exception("CEP inválido");
            }
        }

        public string GetCep()
        {
            int count = 0;
            string maskCep = "";
            if (!string.IsNullOrEmpty(Numero))
            {
                foreach (var item in Numero)
                {
                    if (count == 5)
                        maskCep += "-";

                    maskCep += item;
                    count++;
                }

                return maskCep;
            }

            return Numero;
        }

        public static string GetMaskCep(string cep)
        {
            int count = 0;
            string maskCep = "";
            if (!string.IsNullOrEmpty(cep))
            {
                foreach (var item in cep)
                {
                    if (count == 5)
                        maskCep += "-";

                    maskCep += item;
                    count++;
                }

                return maskCep;
            }
            return maskCep;
        }
    }
}


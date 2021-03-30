using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class Cep
    {
        public const int Maxlength = 10;
        private string numero;

        protected Cep() { }

        public Cep(string pCep, bool autoGe = false)
        {
            if (autoGe)
            {
                numero = pCep;
            }
            else
            {
                setCep(pCep);
            }
        }

        public void setCep(string cepNumero)
        {
            ///COMENTADO TEMPORARIAMENTE, ENTENDER O PQ RETORNA CEP INVALIDO
            numero = cepNumero.Trim().Replace("-", "");


            //if (!string.IsNullOrEmpty(cepNumero))
            //{
            //    Guard.validaSize(cepNumero, Maxlength);

            //    Regex regex = new Regex(@"^\d{5}-\d{3}$");
            //    Match match = regex.Match(cepNumero);

            //    if (match.Success)
            //        numero = cepNumero.Trim().Replace("-", "");
            //    else
            //        throw new Exception("CEP inválido");
            //}
        }

        public string getCep()
        {
            int count = 0;
            string maskCep = "";
            if (!string.IsNullOrEmpty(numero))
            {
                foreach (var item in numero)
                {
                    if (count == 5)
                        maskCep += "-";

                    maskCep += item;
                    count++;
                }

                return maskCep;
            }

            return numero;
        }

        public static string getMaskCep(string cep)
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

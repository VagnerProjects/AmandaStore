using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class CNPJ
    {
        private const int Maxlength = 18;
        public string _numero { get; private set; }

        protected CNPJ() { }

        public CNPJ(string pCnpj, bool autoGe = false)
        {
            if (autoGe)
            {
                string nCnpj = pCnpj.Replace(".", "").Replace("/", "").Replace("-", "");
                _numero = nCnpj;
            }
            else
            {
                setNumero(pCnpj);
            }
        }

        private void setNumero(string cnpjStr)
        {

            if (!string.IsNullOrEmpty(cnpjStr))
            {
                Regex regex = new Regex(@"(^(\d{2}.\d{3}.\d{3}/\d{4}.\d{2})|(\d{14})$)");

                var match = regex.Match(cnpjStr);

                if (match.Success)
                {
                    string nCnpj = cnpjStr.Replace(".", "").Replace("/", "").Replace("-", "");
                    if (IsCnpj(nCnpj))
                        _numero = nCnpj;
                    else
                        throw new Exception("Número de CNPJ inválido");
                }
                else
                {
                    throw new Exception("Número de CNPJ não formatado");
                }
            }
            else
            {
                throw new Exception("Número de CNPJ não pode ser vazio!");
            }
        }

        public string getCnpj()
        {
            int count = 0;
            string maskCnpj = "";
            if (!string.IsNullOrEmpty(_numero))
            {
                foreach (var item in _numero)
                {
                    if (count == 2)
                        maskCnpj += ".";

                    if (count == 5)
                        maskCnpj += ".";

                    if (count == 8)
                        maskCnpj += "/";

                    if (count == 12)
                        maskCnpj += "-";

                    maskCnpj += item;


                    count++;
                }

                return maskCnpj;
            }

            return _numero;
        }

        private static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}

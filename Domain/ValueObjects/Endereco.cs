using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string CepEndereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Endereco(string logradouro, string complemento, string numero, string cepEndereco,
                       string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            CepEndereco = cepEndereco;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string SetLogradouro(string logradouro)
        {
            if (!String.IsNullOrEmpty(logradouro))
                return Logradouro = logradouro.Trim().ToUpper();

            return "";
        }

        public string SetComplemento(string complemento)
        {
            if (!String.IsNullOrEmpty(complemento))
                return Complemento = complemento.Trim().ToUpper();

            return "";
        }

        public string SetNumero(string numero)
        {
            if (!String.IsNullOrEmpty(numero))
                return Numero = numero.Trim().ToUpper();

            return "";
        }
        public string SetCep(string cep)
        {
            if (!String.IsNullOrEmpty(cep))
                return CepEndereco = new Cep(cep).getCep().Trim().ToUpper();

            return "";
        }

        public string SetBairro(string bairro)
        {
            if (!String.IsNullOrEmpty(bairro))
                return Bairro = bairro.Trim().ToUpper();

            return "";
        }

        public string SetCidade(string cidade)
        {
            if (!String.IsNullOrEmpty(cidade))
                return Cidade = cidade.Trim().ToUpper();

            return "";
        }

        public string SetEstado(string estado)
        {
            if (!String.IsNullOrEmpty(estado))
                return Estado = estado.Trim().ToUpper();

            return "";
        }

        public override bool Equals(object obj)
        {
            if(obj is Endereco)
            {
                var endereco = (Endereco)obj;

                if(Logradouro == endereco.Logradouro && Numero == endereco.Numero && CepEndereco == endereco.CepEndereco &&
                    Complemento == endereco.Complemento && Bairro == endereco.Bairro &&
                    Cidade == endereco.Cidade && Estado == endereco.Estado)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

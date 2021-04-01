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

        public void SetLogradouro(string logradouro) => Logradouro = logradouro;
        public void SetComplemento(string complemento) => Complemento = complemento;
        public void SetNumero(string numero) => Numero = numero;
        public void SetCep(string cep) => CepEndereco = cep;
        public void SetBairro(string bairro) => Bairro = bairro;
        public void SetCidade(string cidade) => Cidade = cidade;
        public void SetEstado(string estado) => Estado = estado;

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

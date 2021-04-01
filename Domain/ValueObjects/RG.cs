using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Domain.ValueObjects
{
    public class RG
    {
        public string Numero { get; private set; }
        public string OrgaoEmissor { get; private set; }
        public string PaisEmissor { get; private set; }
        public DateTime? DataDeEmissao { get; private set; }

        protected RG() { }

        public RG(string numero)
        {
            Numero = numero;
        }

        public RG(string numero, string orgaoEmissor, string paisEmissor, DateTime? dataDeEmissao)
        {
            Numero = numero;
            OrgaoEmissor = orgaoEmissor;
            PaisEmissor = paisEmissor;
            DataDeEmissao = dataDeEmissao;
        }

        public void SetOrgaoEmissor(string orgao) => OrgaoEmissor = orgao;

        public void SetPaisEmissor(string paisEmissor) => PaisEmissor = paisEmissor;

        public void SetDataDeEmissao(DateTime? data) => DataDeEmissao = data;

        public void SetNumero(string numeracao) => Numero = numeracao;

        /// <summary>
        /// Exibe data formatada na saída do método
        /// </summary>
        public string GetDataDeEmissao
        {
            get
            {
                if (this.DataDeEmissao != null)
                    return string.Format("{0:d}", this.DataDeEmissao);

                return "Não Informado";
            }
        }
    }
}

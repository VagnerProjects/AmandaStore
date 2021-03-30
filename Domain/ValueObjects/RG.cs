﻿using System;
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

        public void SetOrgaoEmissor(string orgao)
        {
            if (!string.IsNullOrEmpty(orgao))
                this.OrgaoEmissor = orgao;
        }

        public void SetPaisEmissor(string emissor)
        {
            if (!string.IsNullOrEmpty(emissor))
                this.PaisEmissor = emissor;
        }

        public void SetDataDeEmissao(DateTime? data)
        {
            this.DataDeEmissao = data;
        }

        public void SetNumero(string numeracao)
        {
            if (!string.IsNullOrEmpty(numeracao))
                this.Numero = numeracao;
            else
                this.Numero = "";
        }

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

using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Status
{
    public class ServerStatus : IServerStatus
    {
        public string Mensagem { get; set; }
        public int StatusServer { get; set; }

        public ServerStatus(string mensagem, int status)
        {
            Mensagem = mensagem;
            StatusServer = status;
        }

        
    }
}

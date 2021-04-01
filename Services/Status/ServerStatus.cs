using AmandaStore.Services.Status.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Status
{
    public class ServerStatus : IServerStatus
    {

       public int Status { get; set; }
        public string Mensagem { get; set; }
    }
}

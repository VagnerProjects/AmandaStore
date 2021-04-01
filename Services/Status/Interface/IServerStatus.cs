using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Status.Interface
{
    public interface IServerStatus
    {
        int Status { get; set; }
        string Mensagem { get; set; }
    }
}

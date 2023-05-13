using M2S5E01.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01.Interface
{
    public interface IClienteService
    {
        void CriarConta();
        Cliente BuscarClientePorConta(string numeroConta);
        void ListarClientes();
    }
}

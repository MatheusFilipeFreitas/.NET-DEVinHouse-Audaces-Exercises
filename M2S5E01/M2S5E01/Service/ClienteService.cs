using M2S5E01.Interface;
using M2S5E01.model;
using M2S5E01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2S5E01.service
{
    public class ClienteService : IClienteService
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        public ClienteService()
        { 
            PessoaFisica pessoaFisica = new PessoaFisica();
            pessoaFisica.NumeroConta = "0351825";
            pessoaFisica.Cpf = "99999999999";
            pessoaFisica.Nome = "Teste";
            pessoaFisica.DataNascimento = new DateTime(1999,09,09);
            pessoaFisica.Endereco = "Rua Teste do teste da silva";
            _clientes.Add(pessoaFisica);

        }

        public Cliente BuscarClientePorConta(string numeroConta)
        {
            throw new NotImplementedException();
        }

        public void CriarConta()
        {
            throw new NotImplementedException();
        }

        public void ListarClientes()
        {
            throw new NotImplementedException();
        }

        public void CriarContaPessoaFisica()
        {
            PessoaFisica cliente = new PessoaFisica();
            Console.WriteLine("Digite a Data de Nascimento");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
            if (!cliente.EhMaior())
            {
                Console.WriteLine("não é possivel criar conta para menor de idade");
                return;
            }
            Console.WriteLine("Digite o CPF");
            cliente.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o Nome");
            cliente.Nome = Console.ReadLine();

            cliente = (PessoaFisica)AutoPreencherCliente(cliente);

            _clientes.Add(cliente);
        }

        private void CriarContaPessoaJuridica()
        {
            var clientePj = new PessoaJuridica();
            Console.WriteLine("Digite o CNPJ");
            clientePj.Cnpj = Console.ReadLine();
            Console.WriteLine("Digite o Razão Social");
            clientePj.RazaoSocial = Console.ReadLine();
            Console.WriteLine("Digite o Inscrição Estadual");
            clientePj.InscricaoEstadual = Console.ReadLine();

            clientePj = (PessoaJuridica)AutoPreencherCliente(clientePj);
            _clientes.Add(clientePj);
        }

        private Cliente AutoPreencherCliente(Cliente cliente)
        {
            Console.WriteLine("Digite o Numero da conta ");
            cliente.NumeroConta = Console.ReadLine();
            Console.WriteLine("Digite o Endereco");
            cliente.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o Saldo");
            cliente.Saldo = double.Parse(Console.ReadLine());
            return cliente;
        }
    }
}

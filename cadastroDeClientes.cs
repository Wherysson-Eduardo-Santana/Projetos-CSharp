using System;
using System.Collections.Generic;

class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
}

class Program
{
    static List<Cliente> clientes = new List<Cliente>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Excluir Cliente");
            Console.WriteLine("3 - Listar Clientes");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    ExcluirCliente();
                    break;
                case 3:
                    ListarClientes();
                    break;
            }
        } while (opcao != 0);
    }

    static void CadastrarCliente()
    {
        Console.WriteLine("Cadastro de Cliente");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();
        

        Cliente  
 novoCliente = new Cliente { Nome = nome, Email = email, Telefone = telefone };
        clientes.Add(novoCliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
        
        Console.Clear(); // Limpa a tela

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.WriteLine("Precione o Enter para voltar o menu inicial.");
            Console.ReadLine();
    }

    static void ExcluirCliente()
    {
        Console.Write("Digite o nome do cliente a ser excluído: ");
        string nome = Console.ReadLine();

        Cliente clienteEncontrado = clientes.Find(c => c.Nome == nome);

        if (clienteEncontrado != null)
        {
            clientes.Remove(clienteEncontrado);
            Console.Clear(); // Limpa a tela

            Console.WriteLine("Cliente excluído com sucesso!");
            Console.WriteLine("Precione o Enter para voltar o menu inicial.");
            Console.ReadLine();
            
        }
        else
        {
            Console.WriteLine("Cliente não encontrado.");
        }
    }

    static void ListarClientes()
    {
        Console.WriteLine("Lista de Clientes");
        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine($" \nNome: {cliente.Nome}\nEmail: {cliente.Email}\nTelefone: {cliente.Telefone}\n---------------------------------------------");
        }
    }
}   

using System;
using System.Collections.Generic;
using System.Linq;

namespace RevisaoOO
{
    class Program
    {
        static Pessoa EncontrarPessoaPeloCpf(string cpf, List<Pessoa> pessoas) 
        {
            //1a maneira de encontrar uma pessoa
            //Pessoa resultado = pessoas.Where(x=> x.Cpf == cpf).FirstOrDefault();
            //2a maneira de encontrar uma pessoa
            Pessoa resultado = pessoas.SingleOrDefault(x => x.Cpf == cpf);

            return resultado;
        }
        static List<Pessoa> EncontrarPessoasQueNasceramNaMesmaCidade(string naturalidade, List<Pessoa> pessoas) 
        {
            List<Pessoa> pessoasMesmaNaturalidade = pessoas.Where(x=> x.Naturalidade == naturalidade).ToList();
            return pessoasMesmaNaturalidade;
        }
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            //Pessoa pessoa = new Pessoa("Jonathan", "09479806959", "5989267", "47 997443418", "Rua Brusque", new DateTime(1996, 06, 19));

            Console.WriteLine("Informe a opção que deseja fazer.");
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2-Visualizar todos");
            Console.WriteLine("3-Encontrar pessoa pelo CPF");
            Console.WriteLine("4-Encontrar pessoas de mesma naturalidade");
            Console.WriteLine("5-Atualizar, encontrando via CPF");
            Console.WriteLine("0-Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != 0) 
            {
                if (opcao == 1) 
                {                  
                    Console.WriteLine("Insira o Nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Insira o CPF:");
                    string cpf = Console.ReadLine();
                    Console.WriteLine("Insira o Rg:");
                    string rg = Console.ReadLine();
                    Console.WriteLine("Insira o Telefone:");
                    string telefone = Console.ReadLine();
                    Console.WriteLine("Insira o Endereço:");
                    string endereco = Console.ReadLine();
                    Console.WriteLine("Insira o Data de nascimento:");
                    DateTime dataDeNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Insira o Naturalidade:");
                    string naturalidade = Console.ReadLine();

                    Pessoa pessoa = new Pessoa(nome, cpf, rg, telefone, endereco, dataDeNascimento, naturalidade);
                    pessoas.Add(pessoa);
                    Console.WriteLine("Pessoa registrada com sucesso.");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("========Listagem========");
                    foreach (Pessoa p in pessoas) 
                    {
                        Console.WriteLine("========Inicio========");
                        Console.WriteLine("Nome: "+p.Nome);                        
                        Console.WriteLine("CPF: "+p.Cpf);
                        Console.WriteLine("Rg: "+p.Rg);                        
                        Console.WriteLine("Telefone: "+ p.Telefone);                        
                        Console.WriteLine("Endereço: "+p.Endereco);                        
                        Console.WriteLine("Idade: " + p.Idade);                        
                        Console.WriteLine("Naturalidade: "+p.Naturalidade);
                        Console.WriteLine("Data de Nascimento: " + p.DataNascimento);
                        Console.WriteLine("========Fim========");
                    }
                }
                if (opcao == 3) 
                {
                    Pessoa pessoaCpf; 
                    Console.WriteLine("Informe o CPF da pessoa que deseja encontrar:");
                    string cpf = Console.ReadLine();
                    pessoaCpf =  EncontrarPessoaPeloCpf(cpf, pessoas);

                    if(pessoaCpf != null) 
                    {
                        Console.WriteLine("Pessoa encontrada:");
                        Console.WriteLine("Nome: " + pessoaCpf.Nome);
                        Console.WriteLine("CPF: " + pessoaCpf.Cpf);
                        Console.WriteLine("Rg: " + pessoaCpf.Rg);
                        Console.WriteLine("Telefone: " + pessoaCpf.Telefone);
                        Console.WriteLine("Endereço: " + pessoaCpf.Endereco);
                        Console.WriteLine("Idade: " + pessoaCpf.Idade);
                        Console.WriteLine("Naturalidade: " + pessoaCpf.Naturalidade);
                        Console.WriteLine("Data de Nascimento: " + pessoaCpf.DataNascimento);
                    }
                }
                if (opcao == 4) 
                {
                    Console.WriteLine("Informe a cidade das pessoa que deseja encontrar:");
                    string cidade = Console.ReadLine();
                    List<Pessoa> pessoasDaMesmaCidade = EncontrarPessoasQueNasceramNaMesmaCidade(cidade, pessoas);

                    if (pessoasDaMesmaCidade != null) 
                    {
                        Console.WriteLine("Pessoas encontradas:");
                        Console.WriteLine("========Listagem========");
                        foreach (Pessoa p in pessoas)
                        {
                            Console.WriteLine("Nome: " + p.Nome);
                            Console.WriteLine("CPF: " + p.Cpf);
                            Console.WriteLine("Rg: " + p.Rg);
                            Console.WriteLine("Telefone: " + p.Telefone);
                            Console.WriteLine("Endereço: " + p.Endereco);
                            Console.WriteLine("Idade: " + p.Idade);
                            Console.WriteLine("Naturalidade: " + p.Naturalidade);
                            Console.WriteLine("Data de Nascimento: " + p.DataNascimento);
                        }
                    }
                }
                if (opcao == 5) 
                {
                    Pessoa pessoaCpf;
                    Console.WriteLine("Informe o CPF da pessoa que deseja encontrar:");
                    string cpf = Console.ReadLine();
                    pessoaCpf = EncontrarPessoaPeloCpf(cpf, pessoas);

                    if(pessoaCpf != null) 
                    {
                        Console.WriteLine("Insira o Nome:");
                        pessoaCpf.Nome = Console.ReadLine();
                        Console.WriteLine("Insira o CPF:");
                        pessoaCpf.Cpf = Console.ReadLine();
                        Console.WriteLine("Insira o Rg:");
                        pessoaCpf.Rg = Console.ReadLine();
                        Console.WriteLine("Insira o Telefone:");
                        pessoaCpf.Telefone = Console.ReadLine();
                        Console.WriteLine("Insira o Endereço:");
                        pessoaCpf.Endereco = Console.ReadLine();
                        Console.WriteLine("Insira o Data de nascimento:");
                        pessoaCpf.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Insira o Naturalidade:");
                        pessoaCpf.Naturalidade = Console.ReadLine();
                        Console.WriteLine("Pessoa atualizada com sucesso.");
                    }
                }
                Console.WriteLine("Informe a opção que deseja fazer.");
                Console.WriteLine("1-Cadastrar");
                Console.WriteLine("2-Visualizar todos");
                Console.WriteLine("3-Encontrar pessoa pelo CPF");
                Console.WriteLine("4-Encontrar pessoas de mesma naturalidade");
                Console.WriteLine("5-Atualizar, encontrando via CPF");
                Console.WriteLine("0-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }        
        }
    }
}

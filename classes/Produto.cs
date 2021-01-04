using System;
using System.Collections.Generic;

namespace POO_Produtos.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProduto { get; set; }

        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;

            Marca = Marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario();

            ListaDeProduto.Add(novoProduto);
            
        }
        
        public void Listar(){

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProduto){
                Console.WriteLine($"Código {item.Codigo}");
                Console.WriteLine($"Produto {item.NomeProduto}");
                Console.WriteLine($"Preço R$ {item.Preco}");
                Console.WriteLine($"Data de cadastro {item.DataCadastro}");
                Console.WriteLine($"Marca {item.Marca}");


            }
            Console.ResetColor();
        }
        
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProduto.Find(p => p.Codigo == cod);
            ListaDeProduto.Remove(prodDelete);
        }

    }
}
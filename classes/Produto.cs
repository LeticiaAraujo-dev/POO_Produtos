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

            CadastradoPor = new Usuario();
            
        }
        
        public void Listar(){

        }
        
        public void Deletar(int cod){

        }

    }
}
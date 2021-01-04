using System;
using System.Collections.Generic;

namespace POO_Produtos.classes
{
    public class Marca
    {
        int Codigo { get; set; }
        
        public string NomeMarca { get; set; }
        
        DateTime DataCadastro { get; set; }
        
        List<Marca> Marcas { get; set; }
        
        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca:");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){
            foreach( Marca items in Marcas){
                Console.WriteLine($"Código: {items.Codigo}");
                Console.WriteLine($"Marca: {items.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {items.DataCadastro}");


            }
        }

        public void Deletar(int cod){
            Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);
        } 
    }
}
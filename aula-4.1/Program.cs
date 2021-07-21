using System;

namespace aula_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public class Cliente
        {                    
            private int Cod_Cliente;
            private String Nome_Cliente;
            private String Endereco;

            public int Cod_Cliente1 { get => Cod_Cliente; set => Cod_Cliente = value; }
            public string Nome_Cliente1 { get => Nome_Cliente; set => Nome_Cliente = value; }
            public string Endereco1 { get => Endereco; set => Endereco = value; }
        }
        public class Vendedor{
            private int Cod_Vendedor;
            private String Nome_Vendedor;
            private String Meta_de_Venda;

            public int Cod_Vendedor1 { get => Cod_Vendedor; set => Cod_Vendedor = value; }
            public string Nome_Vendedor1 { get => Nome_Vendedor; set => Nome_Vendedor = value; }
            public string Meta_de_Venda1 { get => Meta_de_Venda; set => Meta_de_Venda = value; }
        }
        public class Produto
        {
            private int Cod_Produto;
            private String Descricao;
            private float Valor_Unitario;

            public int Cod_Produto1 { get => Cod_Produto; set => Cod_Produto = value; }
            public string Descricao1 { get => Descricao; set => Descricao = value; }
            public float Valor_Unitario1 { get => Valor_Unitario; set => Valor_Unitario = value; }
        }
    }
    
}                   
   

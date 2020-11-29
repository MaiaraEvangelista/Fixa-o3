using System;

namespace Fixação3
{
    class Program
    {
        static void Main(string[] args)
        {

           

          Console.WriteLine("Digite o nome do produto: ");
          string nomeDoProduto = Console.ReadLine();

          Console.WriteLine("Insira a quantidade desejada: ");
          int quantidade = int.Parse(Console.ReadLine());

          Console.WriteLine("Insira o valor do produto: ");
          float preco = float.Parse(Console.ReadLine());

            TotalAPagar(nomeDoProduto, quantidade, preco);
              float TotalAPagar(string nome, int quantidade, float preco){
              float total = quantidade * preco;
              float desconto;
               
              if(quantidade<=5){
                  desconto = 0.02f;
              } else if(quantidade <=10){
                  desconto = 0.03f;
              } else {
                  desconto = 0.05f;
              }

              float valorDesconto = total * desconto;
              float totalDesconto = total - valorDesconto;

              Console.WriteLine($"Sua compra ficou em R${total}");
              Console.WriteLine($"Você vai receber R${valorDesconto} de desconto");
              Console.WriteLine($"Sua compra com desconto ficou em R$ {totalDesconto}");

               return total;
          }
        }
    }
}

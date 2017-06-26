using System;
using System.Globalization;
namespace curso {
    class Program {
        static void Main(string[] args) {

            Produto p;
            int qte;

            p = new Produto();

            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade em Estoque: ");
            p.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.realizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.realizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine();
        }
    }
}

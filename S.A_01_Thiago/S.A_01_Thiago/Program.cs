using System;
using System.Globalization;

namespace S.A_01_Thiago
{
    class Program
    {
        static void Main(string[] args)
        {
            For f = new For();

            Console.WriteLine();
            Console.WriteLine("    ****************************************************");
            Console.WriteLine("    *******  BEM VINDO AO SISTEMA 'PÃO DO CÉU !  *******");
            Console.WriteLine("    ****************************************************");  
            Console.WriteLine();

            string menu;

            // Indice
            int a, b, c, d, e, g, h, i, j, k;

         
            // Vetores - Cadastro
            string[] nomeCliente = new string[100]; // Exemplo VisualG - nomeCliente: vetor [1..100] de caractere
            int[] cpf = new int[100];
            string[] email = new string[100];


            // Vetores - Produto
            int[] qtdProduto = new int[100];
            int[] qtdCadastro = new int[100];


            double[] valorProduto = new double[100];
            int[] codigoProduto = new int[100];
            int[] qtdProdutoEstoque = new int[100];
            string[] nomeProdutoEstoque = new string[100];
            int[] qtdCompra = new int[100];

            // Compra
            double[] totalCompra = new double[100];
            

            // Número do Cadastro do Cliente
            int cadastro;


            // Número do Cadastro do Cliente
            int nProduto;

            // Produto
            int qtdDoProduto;


            f.TotalCompra = 0;

            //Estrutura de repetição de todo o programa
            do
            {
                Console.WriteLine("    ****************************************************");
                Console.WriteLine("    *                   MENU PRINCIPAL                 *");
                Console.WriteLine("    *                                                  *");
                Console.WriteLine("    *                1- MANTER CLIENTE                 *");
                Console.WriteLine("    *                2- MANTER PRODUTOS                *");
                Console.WriteLine("    *                3- MANTER VENDAS                  *");
                Console.WriteLine("    *                4- HISTÓRICO DE VENDAS            *");
                Console.WriteLine("    *                5- SAIR DO PROGRAMA               *");
                Console.WriteLine("    ****************************************************");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Digite a opção desejada no menu:  ");
                double respostaMenu = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


                switch (respostaMenu)

                {
                    case 1:

                        Console.WriteLine("    ****************************************************");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    *                 Cadastro de Clientes             *");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    ****************************************************");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();


                        Console.Write("Quantos clientes serão cadastrados: ");
                        f.QtdCadastro = int.Parse(Console.ReadLine());


                        Console.WriteLine();
                        Console.WriteLine();


                        for (a = 1; a <= f.QtdCadastro; a++)
                        {
                            cadastro = a;
                            Console.WriteLine("Cadastro: " + cadastro);
                            Console.Write("Nome completo: ");
                            nomeCliente[a] = Console.ReadLine();
                            Console.Write("CPF: ");
                            cpf[a] = int.Parse(Console.ReadLine());
                            Console.Write("E-mail: ");
                            email[a] = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("    ****************************************************");
                            Console.WriteLine("    *********          CADASTRO CONCLUÍDO      *********");
                            Console.WriteLine("    ****************************************************");

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("Aperte Enter para continuar ");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine();
                        }


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 2:

                        Console.WriteLine("    ****************************************************");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    *                    Manter  Produtos              *");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    ****************************************************");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        for (g = 1; g <= 1; g++)
                        {
                            Console.Write("Insira a quantidade de produtos/alimentos que existe estoque: ");
                            f.QtdManterProduto = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            for (h = 1; h <= f.QtdManterProduto; h++)
                            {
                                Console.WriteLine();
                                Console.Write("Nome do " + h + "º produto: ");
                                nomeProdutoEstoque[h] = Console.ReadLine();
                                Console.Write("Valor do produto: R$");
                                valorProduto[h] = double.Parse(Console.ReadLine());
                                Console.Write("Código do produto: ");
                                codigoProduto[h] = int.Parse(Console.ReadLine());
                                Console.Write("Quantidade de produtos/alimentos no estoque: ");
                                qtdProdutoEstoque[h] = int.Parse(Console.ReadLine());

                                Console.WriteLine();
                            }
                            Console.WriteLine();



                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                        }


                        break;

                    case 3:



                        Console.WriteLine("    ****************************************************");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    *                    Manter  Vendas                *");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    ****************************************************");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();




                        Console.WriteLine("Produtos/Alimentos no comércio: ");
                        Console.WriteLine();

                        for (i = 1; i <= f.QtdManterProduto; i++)
                        {
                            Console.WriteLine(nomeProdutoEstoque[i] + " - R$" + valorProduto[i].ToString("F2") + " - " + qtdProdutoEstoque[i] + " em estoque");
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        for (k = 1; k <= f.QtdCadastro; k++)
                        {
                            f.ContadorCliente = k;
                            Console.Write("Insira a quantidade de produtos/alimentos que " + nomeCliente[k] + " irá comprar: ");
                            qtdDoProduto = int.Parse(Console.ReadLine());
                            Console.WriteLine();



                            for (j = 1; j <= qtdDoProduto; j++)
                            {
                                
                                Console.WriteLine();
                                Console.Write("Nome do " + j + "º produto: ");
                                f.NomeProduto = Console.ReadLine();

                                for (d = 1; d <= qtdDoProduto; d++)
                                {
                                    if (f.NomeProduto == nomeProdutoEstoque[d])
                                    {

                                        Console.WriteLine("Valor do produto: R$" + valorProduto[d].ToString("F2"));
                                        Console.WriteLine("Código do produto: " + codigoProduto[d]);
                                        Console.WriteLine("Em estoque: " + qtdProdutoEstoque[d]);
                                        Console.Write("Quantidade desejada: ");
                                        qtdCompra[d] = int.Parse(Console.ReadLine());
                                        
                                        Console.WriteLine();

                                        totalCompra[d] = valorProduto[d] * qtdCompra[d];

                                        Console.WriteLine("Total : R$" + totalCompra[d].ToString("F2"));
                                        Console.WriteLine();
                                       
                                        f.Contador = f.Contador + d;
                                        
                                    }

                                }

                                Console.WriteLine();

                                Console.WriteLine();
                                Console.WriteLine("    ****************************************************");
                                Console.WriteLine("    *********           COMPRA CONCLUÍDO       *********");
                                Console.WriteLine("    ****************************************************");
                                Console.WriteLine();

                                
                            }

                            



                            
                            if (valorProduto[k] == 0)
                            {
                                Console.WriteLine("    ======== NENHUMA COMPRA REALIZADA ========");
                                Console.WriteLine();
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        }


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;


                    case 4:

                        Console.WriteLine("    ****************************************************");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    *                 Histórico de Vendas              *");
                        Console.WriteLine("    *                                                  *");
                        Console.WriteLine("    ****************************************************");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        //Media
                        for (i = 1; i <= f.Contador; i++)
                        {
                            f.Media = f.Media + totalCompra[i];
                        }
                        f.MediaVendas = f.Media / f.Contador;


                        Console.WriteLine("MÉDIA DE VENDAS: R$"+ f.MediaVendas.ToString("F2"));

                        //Maior venda
                        f.MaiorVenda = totalCompra[1];
                        for (i = 1; i <= f.Contador; i++)
                        {
                            if (totalCompra[i] > f.MaiorVenda)
                            {
                                f.MaiorVenda = totalCompra[i];
                            }
                        }

                         Console.WriteLine("MAIOR VENDA: R$"+ f.MaiorVenda.ToString("F2"));

                        //Menor venda
                        f.MenorVenda = totalCompra[1];
                        for (i = 1; i <= f.Contador; i++)
                        {
                            if ( totalCompra[i] <= f.MenorVenda)
                            {
                                f.MenorVenda = totalCompra[i];
                            }
                        }

                        Console.WriteLine("MENOR VENDA: R$"+ f.MenorVenda.ToString("F2"));

                        // PRODUTOS MAIS VENDIDOS
                        int cont = 0;
                        f.Produto1 = qtdCompra[1];
                        for (i = 1; i <= f.Contador; i++)
                        {

                            if (qtdCompra[i] > f.Produto1)
                            {
                                f.Produto1 = qtdCompra[i];
                                cont = cont + 1;
                            }
                        }
                        f.ProdutoMaisVendido = nomeProdutoEstoque[cont];
                        Console.WriteLine("PRODUTOS MAIS VENDIDOS: "+ f.ProdutoMaisVendido);


                        // PRODUTOS MENOS VENDIDO
                        cont = 0;
                        f.Produto2 = qtdCompra[1];
                        for (i = 1; i <= f.Contador; i++)
                        {
                            
                            if (qtdCompra[i] <= f.Produto2)
                            {
                                f.Produto2 = qtdCompra[i];
                                cont = cont + 1;
                            }
                        }
                        f.ProdutoMenosVendido = nomeProdutoEstoque[cont];
                        Console.WriteLine("PRODUTOS MENOS VENDIDO: "+ f.ProdutoMenosVendido);


                         

                        Console.WriteLine("VENDAS POR CLIENTE: "+ f.ContadorCliente);

                        Console.WriteLine("VENDAS POR PRODUTOS: "+ f.Contador);

                        Console.WriteLine("SALDO FINAl: "+ f.Media);



                        Console.WriteLine(); 
                        Console.WriteLine();
                        Console.WriteLine();

                        break;


                }



                Console.Write("Digite 'm' para voltar ao menu ou 's' para sair do programa: ");
                menu = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            while (menu == "m");



        }
    }
}

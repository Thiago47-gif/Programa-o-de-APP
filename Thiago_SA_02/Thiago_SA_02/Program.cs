using System;

namespace Thiago_SA_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita[] receita = new Receita[100];
            string menu;
            int cont = 0;
            string nomeReceita;
            do
            {

                Console.WriteLine("    ****************************************************");
                Console.WriteLine("    *                   MENU PRINCIPAL                 *");
                Console.WriteLine("    *                                                  *");
                Console.WriteLine("    *                1- RECEITAS                       *");
                Console.WriteLine("    *                2- CONSULTAR RECEITA              *");
                Console.WriteLine("    *                3- MANTER VENDAS                  *");
                Console.WriteLine("    *                4- HISTÓRICO DE VENDAS            *");
                Console.WriteLine("    *                5- SAIR DO PROGRAMA               *");
                Console.WriteLine("    ****************************************************");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Digite a opção desejada no menu:  ");
                int respostaMenu = int.Parse(Console.ReadLine());

                

                Console.WriteLine();
                Console.WriteLine();

                switch (respostaMenu)
                {
                    case 1:
                        Console.WriteLine("    *******RECEITAS*******");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Aqui você pode:");
                        Console.WriteLine();
                        Console.WriteLine("- Adicionar Receita");
                        Console.WriteLine("- Editar Receita");
                        Console.WriteLine("- Eliminar Receita");
                        Console.WriteLine();

                        Console.Write("Deseja adicionar alguma receita ? ");
                        string resp1 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (resp1 == "sim" || resp1 == "SIM" || resp1 == "Sim")
                        {
                            Console.Write("Quantas Receitas deseja adicionar: ");
                            int numReceitas = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            for (int i = 1; i <= numReceitas; i++)
                            {
                                Console.WriteLine("Receita #" + i + ":");
                                Console.WriteLine();
                                Console.Write("Nome: ");
                                nomeReceita = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Tempo de Preparação: ");
                                string tempoPreparacao = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Grau de Dificuldade: ");
                                string grauDificuldade = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Número de Pessoas: ");
                                int numPessoas = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.Write("Categoria: ");
                                string categoria = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Descrição: ");
                                string descricao = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Ingredientes: ");
                                string ingredientes = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine();

                                receita[numReceitas] = new Receita(nomeReceita, tempoPreparacao,
                                                         grauDificuldade, numPessoas, categoria,
                                                         descricao, ingredientes);
                                cont = cont + 1;
                                
                            }
                            foreach (Receita i in receita)
                            {

                                Console.WriteLine(i);

                            }
                        }
                        Console.WriteLine();
                        Console.Write("Deseja editar alguma receita ? ");
                        string resp2 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if  (resp2 == "sim" || resp2 == "SIM" || resp2 == "Sim")
                        {
                            Console.Write("Diga o nome da receita que deseja editar: ");
                            string nomeEditar = Console.ReadLine();

                            for (int i = 1; i <= cont; i++)
                            {
                                
                                if (receita[i].NomeReceita == nomeEditar)
                                {
                                    Console.WriteLine("Receita #" + i + ": ");
                                    Console.WriteLine();
                                    Console.Write("Nome: ");
                                    nomeReceita = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Tempo de Preparação: ");
                                    string tempoPreparacao = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Grau de Dificuldade: ");
                                    string grauDificuldade = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Número de Pessoas: ");
                                    int numPessoas = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.Write("Categoria: ");
                                    string categoria = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Descrição: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Ingredientes: ");
                                    string ingredientes = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    receita[i] = new Receita(nomeReceita, tempoPreparacao,
                                                         grauDificuldade, numPessoas, categoria,
                                                         descricao, ingredientes);
                                }


                            }

                        }

                        Console.Write("Deseja eliminar alguma receita ? ");
                        string resp3 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        if (resp3 == "sim" || resp3 == "SIM" || resp3 == "Sim")
                        {
                            Console.Write("Diga o nome da receita que deseja eliminar: ");
                            string nomeEliminar = Console.ReadLine();
                            
                            Console.WriteLine();
                            Console.WriteLine();

                            for (int i = 1; i <= cont; i++)
                            {
                                
                                if (receita[i].NomeReceita == nomeEliminar)
                                {
                                    receita[i] = null;
                                    Console.WriteLine();
                                    Console.WriteLine("    *******RECEITA APAGADA COM SUCESSO*******");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }

                                
                            }
                            
                        }
                        Console.WriteLine();
                        Console.WriteLine();






                        break;

                    case 2:
                        Console.WriteLine("    ===============================");
                        Console.WriteLine("    *******CONSULTAR RECEITA*******");
                        Console.WriteLine("    ===============================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        bool achar = false;
                        string resp;
                        
                        do
                        {
                            Console.WriteLine("Opcões de consulta:");
                            Console.WriteLine();
                            Console.WriteLine("1-Listar todas as receitas (informação completa);");
                            Console.WriteLine("2-Listar receitas por dificuldade;");
                            Console.WriteLine("3-Listar receitas por categoria;");
                            Console.WriteLine("4-Listar receitas por tempo de preparação;");
                            Console.WriteLine("5-Cotação de ingredientes;");
                            Console.WriteLine("6-Valor estimado da receita;");
                            Console.WriteLine();

                            Console.WriteLine("Digite a opção delejada para fazer a consulta da receita:");
                            int opcaoConsulta = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                             
                            if (opcaoConsulta == 1)
                            {
                                Console.WriteLine("    *******TODAS AS RECEITAS*******");
                                Console.WriteLine();
                                Console.WriteLine();

                                foreach (var receitas in receita)
                                {


                                    Console.WriteLine(receitas);
                                    Console.WriteLine();
                                    Console.WriteLine();
                                }
                            }
                            
                            Console.Write("Deseja fazer nova consulta ? ");
                            resp = Console.ReadLine();
                        }
                        while (resp == "sim" || resp == "SIM" || resp == "Sim");






                        break;

                    case 3:


                        Console.WriteLine();

                        break;


                }
                Console.Write("Digite 'm' para voltar ao menu ou 's' para sair do programa: ");
                menu = Console.ReadLine();
            }
            while (menu == "m");
        }
    }
}

using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;

                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;

                    case "4":
                        ExcluirSerie();
                        break;

                    case "5":
                        VisualizarSerie();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }


                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
            //throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);
            //throw new NotImplementedException();
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                //var excluido = Serie.retornaExcluido();

                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie, 
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);

            repositorio.Atualizar(indiceSerie, atualizaSerie);


            //throw new NotImplementedException();
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série: ");

            foreach (int i in Enum.GetValues(typeof(Genero)))
                    {
                        Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
                    }

            Console.WriteLine("Digite o gênero entre as opções mostradas acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: (Sinapse)");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(), 
                                            genero: (Genero)entradaGenero, 
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);
            
            repositorio.Insere(novaSerie);
            //throw new NotImplementedException();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Series: ");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série encontrada!!!! OOOHHHHH nnnnãããããooooo!!!!");
                return;
            }

            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
            //throw new NotImplementedException();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("**** DIO Séries, escolha a opção desejada: ****");
            Console.WriteLine("1 - Listar séries: ");
            Console.WriteLine("2 - Inserir nova série: ");
            Console.WriteLine("3 - Atualizar série: ");
            Console.WriteLine("4 - Excluir série: ");
            Console.WriteLine("5 - Visualizar série: ");
            Console.WriteLine("C - Limpar tela: ");
            Console.WriteLine("X - Sair! ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}

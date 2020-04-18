using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SistemaMercadim
{
    class Program
    {
        //Declaração do Struct
        struct Produtos
        {
            public string descricao;
            public double valor;
            public double valores;
            public int estoque;
            public double valorTotal;
        }

        //Metodo que cadastra os itens
        static void Cadastro(string[] login, int[] senha, ref int contadorArray, Produtos[] itensAlimentacao, Produtos[] itensHigiene, Produtos[] itensLimpeza, Produtos[] contadorCompras, int contador, double valorCaixa)
        {
            //Declaração da variavel que vai representar os arrays, inicializando com o array de alimentação


            //Funções da opção escolhida

            Console.Write("Bem vindo ao seu sistema de compras!!!\nVamos iniciar cadastrando você\nDigite um nome de usuário: ");
            login[0] = Console.ReadLine();


            Console.Write("Agora digite uma senha (apenas numeros): ");

            string pass = "";

            try
            {
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);

                senha[0] = int.Parse(pass);
            }
            catch
            {
                pass = "";

                Console.WriteLine("\nApenas numeros");
                Console.Write("Digite uma senha (apenas numeros): ");

                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);



            }

            senha[0] = int.Parse(pass);

            Console.Clear();

            Console.WriteLine("\nAgora vamos cadastrar produtos\nVamos começar selecionando a categoria que deseja cadastrar\nPressione enter se estiver pronto(a)");

            Console.ReadKey();

            int cadastro1, a = 0, l = 0, h = 0;

            do
            {

                var array = itensAlimentacao;


                string descricao = "";

                int categoria = Categoria();
                switch (categoria)
                {
                    case 1:
                        descricao = "Alimentação";
                        Console.WriteLine("Quantos produtos de {0} deseja cadastrar?", descricao);
                        cadastro1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (a == 0)
                        {
                            contadorArray = 0;
                        }

                        for (int i = 1; i <= cadastro1; i++)
                        {

                            //Pegando as informações
                            Console.WriteLine("Digite o nome do produto que deseja adicionar");
                            itensAlimentacao[contadorArray].descricao = Console.ReadLine();

                            Console.WriteLine("Digite o valor do item {0}", itensAlimentacao[contadorArray].descricao);
                            itensAlimentacao[contadorArray].valor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a quantidade de estoque do item {0}", itensAlimentacao[contadorArray].descricao);
                            itensAlimentacao[contadorArray].estoque = int.Parse(Console.ReadLine());

                            Console.WriteLine("Item {0} cadastrado com sucesso", itensAlimentacao[contadorArray].descricao);

                            //Variavel para sempre pegar o ultimo valor do array
                            contadorArray++;
                            Console.Clear();
                        }
                        a += 1;
                        break;
                    case 2:
                        descricao = "Higiene";
                        Console.WriteLine("Quantos produtos de {0} deseja cadastrar?", descricao);
                        cadastro1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (h == 0)
                        {
                            contadorArray = 0;
                        }

                        for (int i = 1; i <= cadastro1; i++)
                        {

                            //Pegando as informações
                            Console.WriteLine("Digite o nome do produto que deseja adicionar");
                            itensHigiene[contadorArray].descricao = Console.ReadLine();

                            Console.WriteLine("Digite o valor do item {0}", itensHigiene[contadorArray].descricao);
                            itensHigiene[contadorArray].valor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a quantidade de estoque do item {0}", itensHigiene[contadorArray].descricao);
                            itensHigiene[contadorArray].estoque = int.Parse(Console.ReadLine());

                            Console.WriteLine("Item {0} cadastrado com sucesso", itensHigiene[contadorArray].descricao);

                            //Variavel para sempre pegar o ultimo valor do array
                            contadorArray++;
                            Console.Clear();
                        }
                        h++;
                        break;
                    case 3:
                        descricao = "Limpeza";
                        Console.WriteLine("Quantos produtos de {0} deseja cadastrar?", descricao);
                        cadastro1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (l == 0)
                        {
                            contadorArray = 0;
                        }
                        for (int i = 1; i <= cadastro1; i++)
                        {

                            //Pegando as informações
                            Console.WriteLine("Digite o nome do produto que deseja adicionar");
                            itensLimpeza[contadorArray].descricao = Console.ReadLine();

                            Console.WriteLine("Digite o valor do item {0}", itensLimpeza[contadorArray].descricao);
                            itensLimpeza[contadorArray].valor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a quantidade de estoque do item {0}", itensLimpeza[contadorArray].descricao);
                            itensLimpeza[contadorArray].estoque = int.Parse(Console.ReadLine());

                            Console.WriteLine("Item {0} cadastrado com sucesso", itensLimpeza[contadorArray].descricao);

                            //Variavel para sempre pegar o ultimo valor do array
                            contadorArray++;
                            Console.Clear();
                        }
                        l++;
                        break;
                }



                Console.WriteLine("Deseja cadastrar mais algum item (S/N) ?");

            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Pronto, agora vamos para a tela principal do sistema\nAo entrar como administrador, você podera cadastrar mais itens");
            Console.ReadKey();
            Console.Clear();



        }
        //===============================================================================================================================================================================================================

        //Função que retorna a categoria escolhida
        static int Categoria()
        {
            //Verificando a categoria

            int categoria = 0;

            Console.Clear();

            Console.WriteLine("\nSelecione a categoria:\n" +
            "\n1 - Alimentação" +
            "\n2 - Higiene" +
            "\n3 - Limpeza");
            categoria = int.Parse(Console.ReadLine());
            Console.Clear();

            while (categoria <= 0 || categoria >= 4)
            {

                Console.Clear();
                Console.WriteLine("Categoria incorreta, por favor selecione novamente");
                Console.WriteLine("\nSelecione a categoria:\n" +
                "\n1 - Alimentação" +
                "\n2 - Higiene" +
                "\n3 - Limpeza");
                categoria = int.Parse(Console.ReadLine());
                Console.Clear();

            }


            return categoria;
        }
        //===============================================================================================================================================================================================================

        //Funções do Sistema Admin
        static void FuncoesAdmin(ref double x2, ref double x3, int info, int opcaoAdmin, ref int contadorArray, Produtos[] itensAlimentacao, Produtos[] itensHigiene, Produtos[] itensLimpeza, Produtos[] contadorCompras, int contador, double valorCaixa)
        {
            //Declaração da variavel que vai representar os arrays, inicializando com o array de alimentação

            var array = itensAlimentacao;

            //Se info = 1 é administrador
            if (info == 1)
            {
                //Funções da opção escolhida
                switch (opcaoAdmin)
                {
                    case 1:
                        int categoria = Categoria();
                        switch (categoria)
                        {
                            case 1:
                                array = itensAlimentacao;
                                break;
                            case 2:
                                array = itensHigiene;
                                break;
                            case 3:
                                array = itensLimpeza;
                                break;
                        }

                        //Variavel para sempre pegar o ultimo valor do array


                        //Pegando as informações

                        for (int i = 0; i < 50; i++)
                        {
                            if (array[i].valor > 0 && array[i + 1].valor <= 0)
                            {
                                contadorArray = i + 1;
                            }
                        }
                        Console.WriteLine("Digite o nome do produto que deseja adicionar");
                        array[contadorArray].descricao = Console.ReadLine();

                        Console.WriteLine("Digite o valor do item {0}", array[contadorArray].descricao);
                        array[contadorArray].valor = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de estoque do item {0}", array[contadorArray].descricao);
                        array[contadorArray].estoque = int.Parse(Console.ReadLine());

                        Console.WriteLine("Item {0} cadastrado com sucesso", array[contadorArray].descricao);

                        Console.ReadKey();
                        Console.Clear();
                        contadorArray++;
                        break;

                    case 2:

                        //Poss inicia com -1 para que não interfira no array se a descrição do produto não for encontrada
                        int poss = -1;
                        categoria = Categoria();
                        switch (categoria)
                        {
                            case 1:
                                array = itensAlimentacao;
                                break;
                            case 2:
                                array = itensHigiene;
                                break;
                            case 3:
                                array = itensLimpeza;
                                break;
                        }

                        //Pegando a posição do produto que deseja excluir
                        Console.WriteLine("Digite o nome do produto que deseja excluir");
                        string descricaoProduto = Console.ReadLine();

                        for (int i = 0; i < 20; i++)
                        {
                            //Se a descrição for igual ao digitado poss vai receber a posição deste item
                            if (array[i].descricao == descricaoProduto)
                            {
                                poss = i;
                            }
                        }

                        if (poss > -1)
                        {

                            //Se encontrar pega o item que está na proximo a posição e coloca no lugar do item que foi excluido
                            for (int c = poss; c < 20; c++)
                            {
                                array[c].descricao = array[c + 1].descricao;
                                array[c].valor = array[c + 1].valor;
                                array[c].estoque = array[c + 1].estoque;
                            }

                            Console.WriteLine("Item {0} excluido com sucesso", descricaoProduto);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        //Poss inicia com -1 para que não interfira no array se a descrição do produto não for encontrada
                        poss = -1;

                        categoria = Categoria();
                        switch (categoria)
                        {
                            case 1:
                                array = itensAlimentacao;
                                break;
                            case 2:
                                array = itensHigiene;
                                break;
                            case 3:
                                array = itensLimpeza;
                                break;
                        }

                        //Pegando a posição do produto que deseja excluir
                        Console.WriteLine("Digite o nome do produto que deseja alterar o valor:");
                        descricaoProduto = Console.ReadLine();

                        Console.WriteLine("Digite o novo valor do item {0}:", descricaoProduto);
                        double novoValor = double.Parse(Console.ReadLine());

                        for (int i = 0; i < 20; i++)
                        {
                            //Se a descrição for igual ao digitado poss vai receber a posição deste item
                            if (array[i].descricao == descricaoProduto)
                            {
                                poss = i;

                                //Atribuindo novo valor ao produto
                                array[i].valor = novoValor;
                            }
                        }

                        if (poss > -1)
                        {
                            Console.WriteLine("Valor do item {0} alterado com sucesso", descricaoProduto);
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        //Poss inicia com -1 para que não interfira no array se a descrição do produto não for encontrada
                        poss = -1;
                        categoria = Categoria();

                        switch (categoria)
                        {
                            case 1:
                                array = itensAlimentacao;
                                break;
                            case 2:
                                array = itensHigiene;
                                break;
                            case 3:
                                array = itensLimpeza;
                                break;
                        }

                        //Pegando a posição do produto que deseja excluir
                        Console.WriteLine("Digite o nome do produto que deseja ver o valor de estoque:");
                        descricaoProduto = Console.ReadLine();

                        //Titulos 
                        Console.WriteLine("Item      Quantidade em estoque      Valor em estoque:");

                        for (int i = 0; i < 20; i++)
                        {
                            //Se a descrição for igual ao digitado poss vai receber a posição deste item
                            if (array[i].descricao == descricaoProduto)
                            {
                                poss = i;

                                //Mostrando o item e sua quantidade e valor de estoque os espaços são para que os item fiquem embaixo do titulo
                                Console.WriteLine("{0}                  {1}                {2}", array[i].descricao, array[i].estoque, array[i].valor * array[i].estoque);
                                break;
                            }
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        //Variaveis para contar valor quantidade de todos os itens e somar todos
                        double va = 0, vh = 0, vl = 0;
                        int ea = 0, eh = 0, el = 0, da = 0, dh = 0, dl = 0;

                        Console.Clear();

                        /* Console.WriteLine("\n\nItens: ");
                         Console.SetCursorPosition(15, 2);
                         Console.WriteLine("Quantidade em estoque: ");
                         Console.SetCursorPosition(43, 2);
                         Console.WriteLine("Valor em Estoque: ");*/

                        Console.WriteLine("Item      Quantidade em estoque      Valor em estoque:");

                        Console.WriteLine("\t\nAlimentação:\n\n");


                        for (int i = 0; i < 20; i++)
                        {
                            if (itensAlimentacao[i].valor != 0)
                            {
                                /*Console.SetCursorPosition(0, 6 + i);
                                Console.WriteLine("{0} ", itensAlimentacao[i].descricao);
                                Console.SetCursorPosition(15, 6 + i);
                                Console.WriteLine("{0} ", itensAlimentacao[i].estoque);
                                Console.SetCursorPosition(43, 6 + i);
                                Console.WriteLine("{0:n2}", itensAlimentacao[i].valor * itensAlimentacao[i].estoque);*/
                                Console.WriteLine("{0}                  {1}                {2:n2}", itensAlimentacao[i].descricao, itensAlimentacao[i].estoque, itensAlimentacao[i].valor * itensAlimentacao[i].estoque);
                                va += itensAlimentacao[i].valor * itensAlimentacao[i].estoque;
                                ea += itensAlimentacao[i].estoque;
                                da += 1;
                            }
                        }

                        Console.WriteLine("\t\nHigiene:\n");

                        for (int i = 0; i < 20; i++)
                        {
                            if (itensHigiene[i].valor != 0)
                            {
                                /*Console.SetCursorPosition(0, 14 + i);
                                Console.WriteLine("{0} ", itensHigiene[i].descricao);
                                Console.SetCursorPosition(15, 14 + i);
                                Console.WriteLine("{0} ", itensHigiene[i].estoque);
                                Console.SetCursorPosition(43, 14 + i);
                                Console.WriteLine("{0:n2}", itensHigiene[i].valor * itensHigiene[i].estoque);*/
                                Console.WriteLine("{0}                  {1}                {2:n2}", itensHigiene[i].descricao, itensHigiene[i].estoque, itensHigiene[i].valor * itensHigiene[i].estoque);
                                vh += itensHigiene[i].valor * itensHigiene[i].estoque;
                                eh += itensHigiene[i].estoque;
                                dh += 1;
                            }
                        }

                        Console.WriteLine("\t\nLimpeza:\n");

                        for (int i = 0; i < 20; i++)
                        {
                            if (itensLimpeza[i].valor != 0)
                            {
                                /*Console.SetCursorPosition(0, 22 + i);
                                Console.WriteLine("{0} ", itensLimpeza[i].descricao);
                                Console.SetCursorPosition(15, 22 + i);
                                Console.WriteLine("{0} ", itensLimpeza[i].estoque);
                                Console.SetCursorPosition(43, 22 + i);
                                Console.WriteLine("{0:n2}", itensLimpeza[i].valor * itensLimpeza[i].estoque);*/
                                Console.WriteLine("{0}                  {1}                {2:n2}", itensLimpeza[i].descricao, itensLimpeza[i].estoque, itensLimpeza[i].valor * itensLimpeza[i].estoque);
                                vl += itensLimpeza[i].valor * itensLimpeza[i].estoque;
                                el += itensLimpeza[i].estoque;
                                dl += 1;
                            }
                        }

                        //Mostrando todos os valores de quantidade e financeiro de tudo que temos em estoque
                        Console.WriteLine("\n\nQuantidade de itens cadastrados = {0}" +
                                          "\nQuantidade total de itens em estoque = {1}" +
                                          "\nValor total do estoque R$ {2:n2}", da + dh + dl, ea + eh + el, va + vh + vl);
                        break;

                    case 6:

                        //Atribuindo novos valores para porcentagem de descontos
                        Console.Clear();
                        Console.WriteLine("Digite o novo valor em porcentagem de desconto para compras em 2 vezes ");
                        x2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o novo valor em porcentagem de descomto para compras em 3 vezes ");
                        x3 = int.Parse(Console.ReadLine());
                        break;

                    case 7:
                        //Mostraando historico do caixa
                        Console.WriteLine("Compras realizadas\nItens comprados..........Quantidade..........Valor");
                        for (int i = 0; i < 60; i++)
                        {
                            if (contadorCompras[i].estoque > 0)
                            {
                                Console.WriteLine("{0}.....{1}/un......R$ {2:n2}/cada", contadorCompras[i].descricao, contadorCompras[i].estoque, contadorCompras[i].valor);
                            }
                        }

                        Console.WriteLine("Balanço do caixa do dia...........................+ R$ {0:n2}", valorCaixa);
                        break;


                }
            }
        }
        //===============================================================================================================================================================================================================

        //Sistema Administrador e suas funções
        static void Admin(ref double x2, ref double x3, string[] login, int[] senha, ref int contadorArray, Produtos[] itensAlimentacao, Produtos[] itensHigiene, Produtos[] itensLimpeza, Produtos[] contadorCompras, int contador, double valorCaixa)
        {
            //Perguntando o Login

            Console.SetCursorPosition(45, 0);
            Console.WriteLine("Por favor, entre com Login e Senha");
            Console.Write("\nNome de Usuario: ");
            string nomeUser = Console.ReadLine().ToLower();

            //Validando o Login
            if (login.Contains(nomeUser))
            {
                //Perguntando a Senha
                int posUser = login.ToList().IndexOf(nomeUser);
                Console.Write("\nSenha: ");


                string pass = "";
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                } while (true);

                Console.WriteLine("\n");

                //Validando a Senha
                int senhaUser = int.Parse(pass);

                if (senhaUser == senha[posUser])
                {
                    //Lista de funções administrador
                    Console.Clear();
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("BEM VINDO {0}!", nomeUser.ToUpper());

                    //Deixando um loop infinito para que o admin não faça login toda hora
                    do
                    {
                        //Verificanco a opção
                        int opcaoAdmin = 0;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\nSelecione a opção desejada\n" +
                                           "\n1 - Adicionar itens" +
                                           "\n2 - Excluir itens;" +
                                           "\n3 - Alterar valor;" +
                                           "\n4 - Consultar unidades e valor de estoque por item;" +
                                           "\n5 - Consultar quantidade total e valor de estoque total;" +
                                           "\n6 - Alterar desconto para tipo de pagamento;" +
                                           "\n7 - Balanço do caixa;");

                            opcaoAdmin = int.Parse(Console.ReadLine());
                        }

                        while (opcaoAdmin < 1 || opcaoAdmin > 7);
                        FuncoesAdmin(ref x2, ref x3, 1, opcaoAdmin, ref contadorArray, itensAlimentacao, itensHigiene, itensLimpeza, contadorCompras, contador, valorCaixa);

                        Console.WriteLine("Deseja fazer mais alguma alteração? S/N ");


                    }

                    while (char.Parse(Console.ReadLine().ToUpper()) == 'S');
                }

                else
                {

                    Console.WriteLine("Senha incorreta");
                    Console.ReadKey();
                }
            }

            else
            {

                Console.WriteLine("Nome de Usuario incorreto");
                Console.ReadKey();
            }
        }
        //===============================================================================================================================================================================================================

        //Sistema Usuario
        static void User(Produtos[] itensAlimentacao, Produtos[] itensHigiene, Produtos[] itensLimpeza, double x2, double x3, Produtos[] contadorCompras, ref int contador, ref double valorCaixa)
        {

            //Declarando o array do carrinho
            Produtos[] carrinho = new Produtos[63];

            //Variavel para o array da categoria escolhida
            var array = itensAlimentacao;

            //Indice do array carrinho
            int car = 0;


            do
            {
                //Peganto a categoria do Prodduto 
                int categoria = Categoria();

                switch (categoria)
                {
                    case 1:
                        array = itensAlimentacao;
                        break;
                    case 2:
                        array = itensHigiene;
                        break;
                    case 3:
                        array = itensLimpeza;
                        break;
                }

                while (array[0].valor <= 0)
                {
                    Console.WriteLine("Não temos itens nesta categoria ainda");
                    Console.WriteLine("Pressione enter e selecione outra categoria");
                    Console.ReadKey();


                    categoria = Categoria();
                    switch (categoria)
                    {
                        case 1:
                            array = itensAlimentacao;
                            break;
                        case 2:
                            array = itensHigiene;
                            break;
                        case 3:
                            array = itensLimpeza;
                            break;
                    }

                }


                //Mostrando na tela a lista de itens adquirido e pedindo o código do produto
                int c = 0, produto = 0;
                do
                {
                    //Zerando as variaveis para não ter alteração quando o loop voltar
                    c = 0;
                    produto = 0;
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Selecione o Produto");
                    int r = 1;
                    for (int i = 0; i < 20; i++)
                    {

                        //Mostrando apenas os itens que tem valor > 0 no array
                        if (array[i].valor != 0)

                        {
                            Console.WriteLine("{0} - {1}", r, array[i].descricao);
                            r++;
                            c++;
                        }
                    }

                    produto = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                while (produto < 0 || produto > c);

                //Mostrando o Produto selecionado e perguntando a quantidade
                Console.Write("\nProduto: {0} ", array[produto - 1].descricao);

                Console.Write("\nDigite a quantidade: ");
                int quantidadeAdd = int.Parse(Console.ReadLine());

                while (quantidadeAdd < 0 || array[produto - 1].estoque < quantidadeAdd)
                {
                    Console.WriteLine("Quantidade invalida. Tente novamente\nDigite a quantidade");
                    quantidadeAdd = int.Parse(Console.ReadLine());
                }

                //Subtraindo do estoque a quantidade do item comprado
                array[produto - 1].estoque -= quantidadeAdd;


                //Adicionando os itens ao carrinho
                carrinho[car].descricao = array[produto - 1].descricao;
                carrinho[0].valorTotal += array[produto - 1].valor * quantidadeAdd;
                carrinho[car].valores = array[produto - 1].valor * quantidadeAdd;
                carrinho[car].estoque = quantidadeAdd;
                carrinho[car].valor = array[produto - 1].valor;

                //Mostrando o valor da compra e atualizando ele na tela
                Console.WriteLine("\n\t\t\tValor da compra {0:n2}", carrinho[0].valorTotal);

                car++;
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Adicionar mais Produtos?  S/N");

            } while (char.Parse(Console.ReadLine().ToUpper()) == 'S');

            //Perguntando se o usuario deseja excluir algum item do carrinho
            Console.Clear();
            Console.WriteLine("Deseja excluir algum item ? S/N");
            if (char.Parse(Console.ReadLine().ToUpper()) == 'S')
            {
                do
                {
                    //Listando os itens do carrinho e suas quantidades
                    for (int i = 0; i < 60; i++)
                    {
                        //Mostrando apenas os itens que tem + de 0 no carrinho
                        if (carrinho[i].estoque != 0)
                        {
                            Console.WriteLine("\n{0} - {1}.....{2}", i + 1, carrinho[i].descricao, carrinho[i].estoque);
                        }
                    }
                    Console.WriteLine("\nDigite o código do item");
                    int itemCar = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nDigite a quantidade que deseja excluir");
                    int excluir = int.Parse(Console.ReadLine());

                    //Se a quantdade que deseja excluir for toda a quantidade que tem, eliminar o item
                    if (excluir == carrinho[itemCar - 1].estoque)
                    {
                        //Tirando a quantidade do total
                        carrinho[0].valorTotal = carrinho[0].valorTotal - carrinho[itemCar - 1].valor * excluir;

                        //Devolvendo o item para o estoque
                        for (int i = 0; i < 20; i++)
                        {

                            if (itensAlimentacao[i].descricao == carrinho[itemCar - 1].descricao)
                            {
                                itensAlimentacao[i].estoque += carrinho[itemCar - 1].estoque;
                            }
                            else
                            {
                                if (itensHigiene[i].descricao == carrinho[itemCar - 1].descricao)
                                {
                                    itensHigiene[i].estoque += carrinho[itemCar - 1].estoque;
                                }
                                else
                                {
                                    if (itensLimpeza[i].descricao == carrinho[itemCar - 1].descricao)
                                    {
                                        itensLimpeza[i].estoque += carrinho[itemCar - 1].estoque;
                                    }
                                }
                            }
                        }

                        //Removendo o item do carrinho
                        for (int i = itemCar - 1; i < 20; i++)
                        {
                            carrinho[i].descricao = carrinho[i + 1].descricao;
                            carrinho[i].estoque = carrinho[i + 1].estoque;
                            carrinho[i].valores = carrinho[i + 1].valores;
                            carrinho[i].valor = carrinho[i + 1].valor;
                        }
                    }

                    //Se quiser excluir só uma parte do item
                    else
                    {
                        if (excluir < carrinho[itemCar - 1].estoque)
                        {
                            //Tirando a quantidade do total
                            carrinho[0].valorTotal = carrinho[0].valorTotal - carrinho[itemCar - 1].valor * excluir;


                            //Removendo o item do carrinho
                            carrinho[itemCar - 1].estoque = carrinho[itemCar - 1].estoque - excluir;
                            carrinho[itemCar - 1].valores = carrinho[itemCar - 1].valores - carrinho[itemCar - 1].valores / excluir;


                            //Devolvendo o item para o estoque
                            for (int i = 0; i < 20; i++)
                            {

                                if (itensAlimentacao[i].descricao == carrinho[itemCar - 1].descricao)
                                {
                                    itensAlimentacao[i].estoque = itensAlimentacao[i].estoque + excluir;
                                }
                                else
                                {
                                    if (itensHigiene[i].descricao == carrinho[itemCar - 1].descricao)
                                    {
                                        itensHigiene[i].estoque = itensHigiene[i].estoque + excluir;
                                    }
                                    else
                                    {
                                        if (itensLimpeza[i].descricao == carrinho[itemCar - 1].descricao)
                                        {
                                            itensLimpeza[i].estoque = itensLimpeza[i].estoque + excluir;
                                        }
                                    }
                                }
                            }
                        }

                    }

                    //Mostrando o valor da compra e atualizando ele na tela
                    Console.WriteLine("\n\t\t\tValor da compra {0:n2}", carrinho[0].valorTotal);

                    Console.WriteLine("Deseja excluir mais algum item? S/N");
                }
                while (char.Parse(Console.ReadLine().ToUpper()) == 'S');

            }

            Console.Clear();
            //Mostrando os itens do carrinho e seus valores
            for (int i = 0; i < 60; i++)
            {
                if (carrinho[i].estoque > 0)
                {
                    Console.WriteLine("{0}.....{1}/un......R$ {2:n2}/cada", carrinho[i].descricao, carrinho[i].estoque, carrinho[i].valor);
                }
            }

            //Variavel para validar a forma de pagamento
            int pagar = 0;
            do
            {
                //Forma de pagamento
                //Mostrando Valor da compra


                Console.WriteLine("\nSelecione a forma de pagamento:\n" +
                                  "\n1 - A vista R$ {0:n2}" +
                                  "\nParcelado:" +
                                  "\n2 - Em 2x de R$ {1:n2}" +
                                  "\n3 - Em 3x de R$ {2:n2}",
                                  carrinho[0].valorTotal,
                                  (carrinho[0].valorTotal + (carrinho[0].valorTotal * x2) / 100) / 2,
                                  (carrinho[0].valorTotal + (carrinho[0].valorTotal * x3) / 100) / 3);
                pagar = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (pagar < 1 || pagar > 3);

            //Pegando o valor total da forma escolhida
            double valorFinal = 0;

            switch (pagar)
            {
                case 1:
                    valorFinal = carrinho[0].valorTotal;
                    break;

                case 2:
                    valorFinal = carrinho[0].valorTotal + ((carrinho[0].valorTotal * x2) / 100) / 2;
                    break;

                case 3:
                    valorFinal = carrinho[0].valorTotal + ((carrinho[0].valorTotal * x3) / 100) / 3;
                    break;
            }

            //Mostrando a folha final do pagamento

            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Total da sua Compra\n");
            for (int i = 0; i < 60; i++)
            {
                if (carrinho[i].estoque > 0)
                {

                    Console.WriteLine("{0}.....{1} un......R$ {2:n2} un......R$ {3:n2}", carrinho[i].descricao, carrinho[i].estoque, carrinho[i].valor, carrinho[i].valor * carrinho[i].estoque);
                }
            }


            //Colocando os itens da compra no Historico de compras
            int j = 0;

            for (int i = 0; i < 100; i++)
            {
                //pegando a posição vazia do arrey contador e adicionando os produtos da compra
                if (contadorCompras[i].estoque == 0 && carrinho[j].estoque > 0)
                {
                    contadorCompras[i].descricao = carrinho[j].descricao;
                    contadorCompras[i].estoque = carrinho[j].estoque;
                    contadorCompras[i].valor = carrinho[j].valor;
                    contadorCompras[i].valorTotal = valorFinal;

                    j++;
                }
            }

            valorCaixa += valorFinal;

            Console.Clear();

            Console.WriteLine("\nValor total da compra..................R$ {0:n2}", valorFinal);

            Console.WriteLine("\nInsira o cartão");
            Thread.Sleep(3000);
            Console.Write("\nDigite a senha: ");

            //Ocultando a senha da tela
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            Console.Write("\n\n.");
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);

            Console.WriteLine("\n\nTransação aprovada\nRetire o cartão");
            Thread.Sleep(3000);

            Console.WriteLine("\t\t\n\n\t\tObrigado por utilizar os nossos serviços");
            Console.WriteLine("\t\tClique para sair...");
            Console.ReadKey();
            Console.Clear();
        }
        //===============================================================================================================================================================================================================

        static void Main(string[] args)
        {
            //Declaração da variavel para axuliar no historico de compras
            int contador = 0;
            double valorCaixa = 0;

            //Declaração de variaveis para os descontos
            double x2 = 5, x3 = 10;

            //Declaração de variaveis de Login e senha
            string[] login = new string[5];
            int[] senha = new int[5];

            int contadorArray = 0;

            //Declaração do vetor de itens
            Produtos[] itensAlimentacao = new Produtos[25];
            Produtos[] itensHigiene = new Produtos[25];
            Produtos[] itensLimpeza = new Produtos[25];
            Produtos[] contadorCompras = new Produtos[630];


            //Chamando o metodo de cadastro quando é feito o primeiro acesso
            if (itensAlimentacao[0].valor == 0)
            {
                Cadastro(login, senha, ref contadorArray, itensAlimentacao, itensHigiene, itensLimpeza, contadorCompras, contador, valorCaixa);
            }

            //Loop infinito para o programa não fechar
            while (true)
            {
                //Verificanco se é admin ou comprador
                int opcaoEntrada = 0;

                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 0);
                    Console.WriteLine("Bem Vindo Ao nosso Sistema De Compras!");
                    Console.WriteLine("\nDigite a opção desejada:\n" +
                        "\n1 - Administrador" +
                        "\n2 - Comprador");
                    opcaoEntrada = int.Parse(Console.ReadLine());

                }

                while (opcaoEntrada < 1 || opcaoEntrada > 2);



                //Chamando o metodo dependendo da escolha
                switch (opcaoEntrada)
                {
                    case 1:
                        Console.Clear();
                        Admin(ref x2, ref x3, login, senha, ref contadorArray, itensAlimentacao, itensHigiene, itensLimpeza, contadorCompras, contador, valorCaixa);
                        break;

                    case 2:
                        Console.Clear();
                        User(itensAlimentacao, itensHigiene, itensLimpeza, x2, x3, contadorCompras, ref contador, ref valorCaixa);
                        break;
                }
            }

        }
    }
}
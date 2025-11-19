// Desafios das aulas da Alura, C# Criando Sua Primeira Aplicação

// Onda 04: Dicionarios e Avaliações de Bandas

void menuDeDesafios04(){
    Console.Clear();
    Console.WriteLine("Onda 04: Dicionarios e Avaliações de Bandas\n");
    Console.WriteLine("Lista de exercicios:\n");

    Console.WriteLine("[ 1] - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.");
    Console.WriteLine("[ 2] - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.");
    Console.WriteLine("[ 3] - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.");
    Console.WriteLine("[ 4] - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.\n");
    Console.WriteLine("[-1] - Para sair do programa.\n");

    Console.Write("Qual exercicio você deseja executar: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            exercicio1();
            break;
        case 2:
            exercicio2();
            break;
        case 3:
            exercicio3();
            break;
        case 4:
            exercicio4();
            break;
        case -1:
            Console.WriteLine("\n Bye :).");
            break;
        default:
            Console.WriteLine("\n Opção invalida.");
            Thread.Sleep(2000);
            menuDeDesafios04();
            break;
    }

}

// 1 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

void exercicio1()
{
    Console.Clear();
    Dictionary <string, List<int>> listaDeAlunos = new Dictionary<string, List<int>>();
    listaDeAlunos["Morpheus"] = new List<int> { 10, 7, 6, 8};
    listaDeAlunos["Repolho"] = new List<int> { 6, 5, 10, 7};

    Console.WriteLine("\nSomatória da média de alunos em um dicionario:");

    foreach (var aluno in listaDeAlunos)
    {
        int resultado = 0;        
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            resultado += aluno.Value[i];
        }
        int media = resultado / aluno.Value.Count;
        string nome = aluno.Key;
        Console.WriteLine($"\nA média do aluno {nome}, é de {media}.");
    }
    
}


// 2 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.

Console.Clear();
Dictionary <string, int> listaDeProdutos = new Dictionary<string, int>();
listaDeProdutos["Batata"] = 6;
listaDeProdutos["Polenta"] = 3;

void exercicio2()
{

    Console.WriteLine ("Produtos em estoque na lojinha bacana:\n");
    foreach (var produto in listaDeProdutos)
    {
        Console.WriteLine($"Produto: {produto.Key} // Quantidade: {produto.Value}");
    }

    Console.Write ("\nDigite o nome do produto que deseja pesquisar:");
    string pesquisarProduto = Console.ReadLine()!;
    verificarEstoque(pesquisarProduto);
    
}

void verificarEstoque(string produto)
{
    if (listaDeProdutos.ContainsKey(produto))
    {
        Console.Write ($"\nO produto {produto}, tem {listaDeProdutos[produto]} unidades disponiveis no estoque.");
    }
    else
    {
        Console.WriteLine ("\nProduto não encontrado em estoque. :()");
    }
    
}

// 3 - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Console.Clear();
Dictionary <string, string> quiz = new Dictionary<string, string>
{
    {"Sem fertilizantes, em quantos dias é possivel colher uma batata? (apenas números) ", "6"},
    {"Quando é o aniversário da Abigail? (DD de Estação)", "13 de Outono"},
    {"Quantos dias tem um mês em Stardew Valley? (apenas números)", "28"}
};


void exercicio3()
{
    Console.Clear();
    Console.WriteLine("\nBem vindo ao mini quiz de Stardew Valley, valendo nada!\n");
    Thread.Sleep(2000);

    int respostaCorreta = 0;

    foreach (var pergunta in quiz)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("\nSua resposta é: ");
        string resposta = Console.ReadLine()!;
        Thread.Sleep(1000);

        if (resposta.ToLower() == pergunta.Value.ToLower())
        {
            Console.WriteLine("\nParabens você acertou a resposta!\n");
            respostaCorreta++;
        }
        else
        {
            Console.WriteLine($"\nNão a resposta correta é: {pergunta.Value}. :(\n");
        }
        Thread.Sleep(1000);
    }

    Console.WriteLine($"Fim de jogo, você acertou {respostaCorreta} de {quiz.Count} perguntas.");

    if (respostaCorreta == quiz.Count)
    {
        Console.WriteLine("WOAH! 100% :O");
    }

}

//4 - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Console.Clear();
Dictionary <string, string> loginESenha = new Dictionary<string, string>()
{
    {"Batata1936", "Pãocomovoémuitobom"},
    {"BlackKingnit", "runescape"}
};

void exercicio4()
{
    Console.WriteLine("\nLogin Simulator :)");
    Console.Write("Digite seu login: ");
    string login = Console.ReadLine()!;
    Console.Write("Digite sua senha: ");
    string senha = Console.ReadLine()!;

    if (loginESenha.ContainsKey(login))
    {
        if (loginESenha[login] == senha)
        {
            Console.WriteLine($"\nSeja bem-vindo {login}, você concluiu o simulador de login.\n");
        }
        else
        {
            Console.WriteLine($"\nSenha incorreta. GAME OVER >:(\n");
        }
    }
    else
    {
        Console.WriteLine("\nEsse login não existe. GAME OVER :(\n");
    }
}

menuDeDesafios04();
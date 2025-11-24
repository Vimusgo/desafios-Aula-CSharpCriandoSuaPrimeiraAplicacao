// Desafios das aulas da Alura, C# Criando Sua Primeira Aplicação

Random gerador = new Random();

void menuDeDesafiosGeral(){
    Console.Clear();
    Console.WriteLine("Desafios das aulas da Alura, C# Criando Sua Primeira Aplicação\n");
    Console.WriteLine("Lista de Desafios:\n");

    Console.WriteLine("[ 1] - Criando o Primeiro Programa.");
    Console.WriteLine("[ 2] - Tipos e Funções no C#");
    Console.WriteLine("[ 3] - Listas e Loops no C#");
    Console.WriteLine("[ 4] - Dicionarios e Avaliações de Bandas.\n");
    Console.WriteLine("[-1] - Para sair do programa.\n");

    Console.Write("Qual exercicio você deseja executar: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            desafio1();
            break;
        case 2:
            desafio2();
            break;
        case 3:
            desafio3();
            break;
        case 4:
            menuDeDesafios04();
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

// Onda 01: Criando o Primeiro Programa

void desafio1()
{

    // 1 - Criar uma variável chamada curso, e guarde nela o nome do curso estudado.

    string curso = "C# Criando sua primeira aplicação";

    // 2 - Mostrar o conteúdo da variável curso no console.

    Console.WriteLine($"\nNo momento estou aprendendo com o curso: {curso}.\n");

    // 3 - Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.

    string nome = "Vinicius";
    string sobrenome = "Amaral Fink";

    // 4 - Mostrar na tela o nome dos instrutores do curso.

    List<string> instrutores = new List<string> {"Guilherme Lima", "Daniel Portugal"};

    foreach (var instrutor in instrutores){
    Console.WriteLine($"Instrutor: {instrutor}");
    }

    string aluno = nome + " " + sobrenome;

    Console.WriteLine($"Aluno: {aluno}");

    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafiosGeral();

}

// Onda 02: Tipos e Funções no C#

// 1 - Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".

void desafio2(){

    int notaAleatoria =gerador.Next(0, 11);

    if (notaAleatoria >= 5)
    {
        Console.WriteLine($"\nO destino lhe concedeu a nota {notaAleatoria}, parabéns você passou na avalição aleatória.");
    } else
    {
        Console.WriteLine($"\nO destino lhe concedeu a nota {notaAleatoria}, meus pêssames você reprovou na avalição aleatória.");
    }

    // 2 - Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.

    List<string> linguagensDeProgramacao = new List<string> {"C#", "Java", "JavaScript"};

    // 3 - Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.

    Console.WriteLine($"\n{linguagensDeProgramacao[0]}");

    // 4 - Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.

    Console.Write($"\nDigite um numero de 1 a 3: ");
    int numeroEscolhido = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"\nVocê escolheu o programa: {linguagensDeProgramacao[numeroEscolhido - 1]}");

    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafiosGeral();

}

// Onda 03: Listas e Loops no C#

void desafio3(){

    // 1 - Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

    float a = gerador.Next(0, 100);
    float b = gerador.Next(0, 100);

    Console.WriteLine($"\nResultados de operações basicas entre o número {a} e {b}:");
    Console.WriteLine($"\n   {a} + {b} = {a + b}");
    Console.WriteLine($"\n   {a} - {b} = {a - b}");
    Console.WriteLine($"\n   {a} / {b} = {a / b}");
    Console.WriteLine($"\n   {a} * {b} = {a * b}");

    // 2 - Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

    List<string> listaDeBandas = new List<string>
    {
      "Iron Mouse", "Helloween", "TOOBOE"
    };

    // 3 - Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

    Console.WriteLine("\nUma lista com minhas bandas favoritas:\n");
    foreach (var banda in listaDeBandas)
    {
        Console.WriteLine($" - {banda}");
    }

    // 4 - Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

    List<int> listaDeNumeros = new List<int>{1,2,3,4,5,6,7,8,9};

    int resultado = listaDeNumeros.Sum();

    Console.WriteLine("\nA soma da lista de numeros: ");
    for (var i = 0; i < listaDeNumeros.Count; i++)
    {
        Console.Write(listaDeNumeros[i]);
        if (i + 1 < listaDeNumeros.Count)
        {
            Console.Write(" + ");
        }
    }

    Console.Write($" = {resultado}\n");


    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafiosGeral();

}

// Onda 04: Dicionarios e Avaliações de Bandas

void menuDeDesafios04(){
    Console.Clear();
    Console.WriteLine("Onda 04: Dicionarios e Avaliações de Bandas\n");
    Console.WriteLine("Lista de exercicios:\n");

    Console.WriteLine("[ 1] - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.");
    Console.WriteLine("[ 2] - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.");
    Console.WriteLine("[ 3] - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.");
    Console.WriteLine("[ 4] - Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.\n");
    Console.WriteLine("[-1] - Para voltar ao menu de desafios.\n");

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
            menuDeDesafiosGeral();
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
    
    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafios04();

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
        Console.WriteLine ("\nProduto não encontrado em estoque. :(");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafios04();
    
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

    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafios04();

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

    Console.WriteLine("\nDigite uma tecla para voltar ao menu de desafios.");
    Console.ReadKey();
    menuDeDesafios04();

}

menuDeDesafiosGeral();
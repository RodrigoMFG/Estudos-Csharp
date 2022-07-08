// See https://aka.ms/new-console-template for more information

Inicio();

static void Inicio()
{
    Console.Clear();
    Console.WriteLine("Bem vindo a calculadora C#!");
    Menu();
    Console.WriteLine("Deseja fazer uma nova Operação?");
    Console.WriteLine("S/N : ");
    string novaOp = Console.ReadLine();
    while(novaOp != "n")
    {
        if(novaOp =="s")
        {
            Menu();
            Console.WriteLine("Deseja fazer uma nova Operação?");
            Console.WriteLine("S/N: ");
            novaOp = Console.ReadLine(); 
        }else
        {
            Console.Clear();
            Console.WriteLine("Opção Inválida!");
            Console.WriteLine("Deseja fazer uma nova Operação?");
            Console.WriteLine("S/N: ");
            novaOp = Console.ReadLine();
        }
            
    }
    Console.Clear();
    Console.WriteLine("Obrigado por utilizar a Calculadora C# !");
    Console.ReadKey();
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("OPERAÇÃO SOMA: \n");
    Console.WriteLine("Insira o Primeiro Valor:");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Segundo Valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;

    Console.WriteLine("\nO Resultado da Soma é: " + resultado);
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("OPERAÇÃO SUBTRAÇAO: \n");
    Console.WriteLine("Insira o Primeiro Valor:");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Segundo Valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;

    Console.WriteLine("\nO Resultado da Subtração é: " + resultado);

}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("OPERAÇÃO DIVISÃO: \n");
    Console.WriteLine("Insira o Primeiro Valor:");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Segundo Valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;

    Console.WriteLine("\nO Resultado da Divisão é: " + resultado);
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("OPERAÇÃO MULTIPLICAÇÃO: \n");
    Console.WriteLine("Insira o Primeiro Valor:");
    float valor1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Segundo Valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;

    Console.WriteLine("\nO Resultado da Multiplicação é: " + resultado);
}

static void Menu()
{
    
    Console.WriteLine("Escolha qual a operação desejada, conforme o menu abaixo:");
    Console.WriteLine("Soma => 1");
    Console.WriteLine("Subtração => 2");
    Console.WriteLine("Divisão => 3");
    Console.WriteLine("Multiplicação => 4");
    Console.WriteLine("Sair => 5");
    string operacao = Console.ReadLine();

    switch(operacao)
    {
        case "1": Soma(); break;
        case "2": Subtracao(); break;
        case "3": Divisao(); break;
        case "4": Multiplicacao();break;
        case "5": Console.WriteLine("Voce saiu."); break;
        default: Console.Clear(); Console.WriteLine("Operação Inválida"); Menu(); break;

    }


}



class program
{
    public static void Main()
    {
        //tipo nomedavariavel

        // cria duas variaveis do tipo inteiro
        double numero1, numero2;

        //escreve a infomação na tela sem pular linha
        //Console.Write("Entre com o primeiro valor");
        //Console.Write("Entre com o segundo numero");

        //escreve a informação e depois pula um a linha
        Console.WriteLine("Entre o número1:");
        //numero1 = Console.ReadLine() - lê o que o usuario digitou
        //converte o valor da variavel para inteiro
        //e salva dentro da variavel numero1

        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entre o munero2: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        double soma = (double)numero1 + numero2;
        double subtracao = numero1 - numero2;
        double divisao = numero1 / numero2;
        double multiplicacao = numero1 * numero2;


        //soma
        Console.WriteLine($"soma: {soma}");


        //subtração
        Console.WriteLine("subtração:{0}", subtracao, divisao);


        //divisão
        Console.WriteLine($"Divisão:{divisao}");


        //multiplicação
        Console.WriteLine($"Multiplicação:{multiplicacao}");



    }
}




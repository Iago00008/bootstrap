//Receber o ano de nascimento da pessoa 

//receber o ano atual do usuario
//callcular a idade da pessoa 
//mostra a idade da pessoa na tela
class program
{
    public static void Main()
    {
        int num1, num2;


        Console.WriteLine("Informe sue ano de nascimento:");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o ano atual: ");

        num2 = Convert.ToInt32(Console.ReadLine());

        int subtracao = num2 - num1;

        Console.WriteLine($"subtração: {subtracao}");







    }
}
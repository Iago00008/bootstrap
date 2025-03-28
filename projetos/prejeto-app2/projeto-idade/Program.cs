//Receber o ano de nascimento da pessoa 

//receber o ano atual do usuario
//callcular a idade da pessoa 
//mostra a idade da pessoa na tela
class program
{
    public static void Main()
    {
        int ano1, ano2;


        Console.WriteLine("Informe sue ano de nascimento:");

        ano1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o ano atual: ");
        
        ano2 = Convert.ToInt32(Console.ReadLine());

        int idade = ano2 - ano1;

        Console.WriteLine($"Idade: {idade}");







    }
}
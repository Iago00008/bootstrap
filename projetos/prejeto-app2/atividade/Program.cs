
class Program
{
    public static void Main()
    {
        Console.Write("Nome da Escola: ");
        string escola = Console.ReadLine();
        Console.Write("Nome do Aluno: ");
        string aluno = Console.ReadLine();
        Console.Write("Sexo (M/F): ");
        char sexo = Console.ReadLine()[0];
        sexo = char.ToUpper(sexo);
        Console.Write("Idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Frequência (%): ");
        double frequencia = double.Parse(Console.ReadLine());

        Console.WriteLine("me fale suas notas:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());
        double nota4 = Convert.ToDouble(Console.ReadLine());
        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.Clear();
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Escola: " + escola);
        Console.WriteLine("Aluno: " + aluno);
        Console.WriteLine("Sexo: " + sexo);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Frequência: " + frequencia + "%");
        Console.WriteLine("Média: " + media);

    }

}

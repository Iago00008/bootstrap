//tipo nomedavariavel


// cria duas variaveis do tipo inteiro
int numero1, numero2, numero3, numero4;

//escreve a infomação na tela sem pular linha
//Console.Write("Entre com o primeiro valor");
//Console.Write("Entre com o segundo numero");

//escreve a informação e depois pula um a linha
Console.WriteLine("Entre o número1:");

//numero1 = Console.ReadLine() - lê o que o usuario digitou
var informacao = Console.ReadLine();


//converte o valor da variavel para inteiro
//e salva dentro da variavel numero1

numero1 = Convert.ToInt32(informacao);

Console.WriteLine("Entre o munero2: ");
var informacao2 = Console.ReadLine();

numero2 = Convert.ToInt32(informacao2);

int soma = numero1 + numero2;
int subtracao = numero1 - numero2; 
int divisao = numero1 / numero2; 
int multiplicacao = numero1 * numero2;

Console.Write("soma: ");
Console.WriteLine(soma);
Console.Write("subtração;");
Console.WriteLine(subtracao);
Console.Write("Divisão:");
Console.WriteLine(divisao);
Console.Write("Multiplicação:");
Console.WriteLine(multiplicacao);


double temperatura = 0;
string opcao = "C";
double conversao = 0;

Console.WriteLine("Qual o valor da temperatura que deseja converter?");
temperatura = double.Parse(Console.ReadLine());

Console.WriteLine("Deseja converter para qual unidade de temperatura?");
Console.WriteLine("C - Graus CELSIUS");
Console.WriteLine("F - Graus FAHRENHEIT");
opcao = Console.ReadLine();

Console.WriteLine("");

switch (opcao)
{
    case "C":
        // (0 ºC x 9/5) + 32 = 32 ºF
        conversao = (temperatura * 9 / 5) + 32;
        break;

    case "F":
        // (0 ºF -32) x 5/9 = -17,78 ºC
        conversao = (temperatura - 32) * 9 / 5;
        break;

        default:

        break;
}
Console.WriteLine("Temperatura convertida é: " + conversao);

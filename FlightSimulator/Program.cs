var minutosVoo = 0;
var litrosAbastecidos = 0.0;

do
{
    if (minutosVoo <= 0)
    {
        Console.WriteLine("Quantos minutos de voo deseja simular?");
        minutosVoo = int.Parse(Console.ReadLine());
    }

    if (litrosAbastecidos <= 0.0)
    {
        Console.WriteLine("Quantos litros sera abastecido no avião?");
        litrosAbastecidos = double.Parse(Console.ReadLine());
    }
} while (minutosVoo <= 0 || litrosAbastecidos <= 0.0);

var nivelCombustivel = litrosAbastecidos;
var altitude = 0;
var velocidade = 0;

for (int i = 1; i <= minutosVoo; i++)
{
    nivelCombustivel -= 5.0;

    if (i <= 10)
    {
        altitude += 100;
    }

    if (i <= 5)
    {
        velocidade += 50;
    }

    if (nivelCombustivel <= 0)
    {
        Console.WriteLine("ALERTA! Combustivel esgotado.");
    }

    Console.WriteLine("Nivel de combustivel:" + nivelCombustivel);
    Console.WriteLine("Altitude:" + altitude);
    Console.WriteLine("Velocidade:" + velocidade);
}


Console.WriteLine("....Calculador de Itens para Churrasco....");

Console.Write("Quantos adultos consomem bebidas alcoólicas? ");
int adultosComAlcool = int.Parse(Console.ReadLine());

Console.Write("Quantos adultos não consomem bebidas alcoólicas? ");
int adultosSemAlcool = int.Parse(Console.ReadLine());

Console.Write("Quantas crianças? ");
int criancas = int.Parse(Console.ReadLine());

double carne = ((adultosComAlcool + adultosSemAlcool) * 400 + criancas * 200) / 1000.0; // 400g por adulto, 200g por criança
double acompanhamentos = ((adultosComAlcool + adultosSemAlcool) * 200 + criancas * 200) / 1000.0; // 200g por adulto, 200g por criança
double cerveja = adultosComAlcool * 2.0;
double refrigerante = ((adultosComAlcool + adultosSemAlcool) * 500 + criancas * 500) / 1000.0; // 500ml por adulto, 500ml por criança
double agua = ((adultosComAlcool + adultosSemAlcool) * 400 + criancas * 400) / 1000.0; // 400ml por adulto, 400ml por criança

Console.WriteLine("\nQuantidade de itens necessários para o churrasco:");
Console.WriteLine($"Carne: {carne:F1} kg");        
Console.WriteLine($"Acompanhamentos: {acompanhamentos:F1} kg");
Console.WriteLine($"Cerveja: {cerveja} litros");
Console.WriteLine($"Refrigerante: {refrigerante:F1} litros");
Console.WriteLine($"Água: {agua:F1} litros");

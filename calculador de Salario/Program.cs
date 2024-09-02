double Sal, Dollar,horas;

Console.WriteLine("Digite Valor da Moeda:");
Dollar = double.Parse(Console.ReadLine());
Console.WriteLine("Digite as horas trabalhadas");
horas = double.Parse(Console.ReadLine());

Sal = Dollar * horas;

Console.WriteLine("valor do salario:" + Sal);
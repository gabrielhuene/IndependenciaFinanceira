decimal gastosMensais, valorAInvestir;
double dividendYield;

Console.WriteLine("--- Vivendo de dividendos ---\n");
Console.Write("Gastos mensais (em R$)....: ");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");
dividendYield = Convert.ToDouble(Console.ReadLine());
valorAInvestir = gastosMensais / Convert.ToDecimal(dividendYield / 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentode de {dividendYield:N1}% voce precisa ter investido {valorAInvestir:C}.");

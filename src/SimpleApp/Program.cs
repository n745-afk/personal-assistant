using SimpleApp;

var calculator = new Calculator();

Console.WriteLine("Простой калькулятор для уведомлений");
Console.WriteLine("====================================");
Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
Console.WriteLine($"10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"7 * 6 = {calculator.Multiply(7, 6)}");
Console.WriteLine($"20 / 5 = {calculator.Divide(20, 5)}");
Console.WriteLine($"7 - четное? {calculator.IsEven(7)}");
Console.WriteLine($"17 - простое? {calculator.IsPrime(17)}");
Console.WriteLine("\nВсе операции выполнены успешно!");

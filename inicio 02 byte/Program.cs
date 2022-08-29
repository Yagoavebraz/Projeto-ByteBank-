using Inicio;
ContaCorrente conta = new ContaCorrente();

conta.titular = "Gabriela";

conta.saldo = 200;

Console.WriteLine(conta.titular);
Console.WriteLine(conta.saldo);
Console.WriteLine(conta.agencia);
Console.ReadLine();
using Inicio;

ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";
Console.WriteLine(contaDoBruno.saldo);

bool resultadosaque = contaDoBruno.Sacar(500);


Console.WriteLine(contaDoBruno.saldo);
Console.WriteLine(resultadosaque);

contaDoBruno.Depositar(500);
Console.WriteLine(contaDoBruno.saldo);

ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);


bool resultadoTransferencia = contaDoBruno.Transferir(200, contaDaGabriela);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);
Console.WriteLine("Resultado Transferencia: " + resultadoTransferencia);

contaDaGabriela.Transferir(100, contaDoBruno);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);




Console.ReadLine();

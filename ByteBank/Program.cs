// vai representar uma conta corrente 
using ByteBank;


// vamos criar um objeto 
ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
contaDoAndre.conta = "1010-X";
// contaDoAndre.saldo = 100;

// Console.WriteLine("Saldo da conta do André " + contaDoAndre.saldo);

contaDoAndre.Depositar(1000);
// Console.WriteLine("Novo saldo" + contaDoAndre.saldo);

ContaCorrente conta = new ContaCorrente();
Console.WriteLine($"Titular da conta: {conta.titular}");
Console.WriteLine($"Número da conta: {conta.conta}");
Console.WriteLine($"Agência: {conta.agencia}");
// Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");
// Console.WriteLine("Saldo da conta do André pós saque" + contaDoAndre.saldo);

if (contaDoAndre.Sacar(1000) == true)
{
    // Console.WriteLine("Saldo da conta" + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque");
}

// usamos new para o novo objeto que queremos criar 
ContaCorrente contaDaIsa = new ContaCorrente();
//contaDaIsa.titular = "Isabella";
contaDaIsa.numero_agencia = 17;
contaDaIsa.conta = "1010-5";
// contaDaIsa.saldo = 350;

// Console.WriteLine("Saldo da conta da Isa" + contaDaIsa.saldo);
contaDaIsa.Transferir(50, contaDaIsa);
// Console.WriteLine("Saldo da conta da Isa" + contaDaIsa.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Isabella Oliveira";
cliente.Cpf = "36759212800";
cliente.profissao = "Dev back-end";

ContaCorrente contaIsa = new ContaCorrente();
// o titular recebe o objeto de cliente que esta acima
contaIsa.titular = cliente;
contaIsa.conta = "1010-X";
// contaIsa.saldo = 100;

// definir e obter saldo 
ContaCorrente contaTeste = new ContaCorrente(); 
// podemos manipular os campos privados dessa classe através dos métodos publicos 
// contaTeste.saldo = -10; não acesso mais o campo saldo direto 
contaTeste.SetSaldo(-10); 
Console.WriteLine("Aqui temos o metodo obter saldo: ");
Console.WriteLine(contaTeste.GetSaldo());









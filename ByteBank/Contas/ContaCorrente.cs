using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        // dizer que é static quer dizer que essa propriedade é da classe 
        public static int TotalDeContasCriadas { get; set; }
        // estrutura que representa o real 
        // todas as variaveis tem um valor parão de 0 ou null 
        private int numero_agencia;
        // uma propriedade tem um get e um set
        public int Numero_agencia 
        {
            get { return numero_agencia; }
            private set { 
                    if(value > 0)
                    {
                        this.numero_agencia = value; 
                    }
                }
        }
        // public string conta; 
        public string Conta { get; set; }
        public string agencia;
        public string nome_agencia;
        private double saldo = 100;
        public Cliente Titular { get; set; } 

        public void Depositar(double valor)
        {
            // método 
            this.saldo += valor;
        }

        // se conseguirmos efetuar o saque ele retorna true 
        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        // o valor adicionado e o destino são os parâmetros 
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        // vamos manipular o campo saldo para que nao sejam permitidos que sejam colocados
        // valores menores que 0
        // manipula um campo privado da minha classe 
        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        // vamos criar um metodo publico que acessa e exibe o campo saldo 
        public double GetSaldo()
        {
            return this.saldo;
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.Numero_agencia = numero_conta;
            this.Conta  = numero_conta; 
            // vamos adicionar mais uma conta
            TotalDeContasCriadas++;
        }

        public ContaCorrente()
        {
            // agora temos um que não chama método nenhum
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + titular);
            Console.WriteLine("Conta :" + conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Nome Agência :" + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}

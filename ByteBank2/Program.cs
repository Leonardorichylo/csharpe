using System;
using ByteBank2.Model;
namespace ByteBank2 {
    class Program {
        static void Main (string[] args) {
            string cliente1 = "Alexandre";
            string cliente2 = "Cesar";

            ContaCorrente contaCorrente1 = new ContaCorrente(1,1,cliente1);
            ContaCorrente contaCorrente2 = new ContaCorrente(1,2,cliente2);
            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);
            TransferenciaEntreContas(contaCorrente1,contaCorrente2);
            
        }
    }
}
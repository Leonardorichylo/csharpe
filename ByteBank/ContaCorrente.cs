namespace ByteBank
{
    public class ContaCorrente

    //Atributos
    {
        public Cliente titular{get;set;}
        public int agencia{get;set;}
        public int numero{get;set;}
        public double Saldo{get;set;}


        //Construtor
        public ContaCorrente(int agencia,int numero,Cliente titular){
            this.agencia = agencia;
            this.numero = numero;
            this.titular = titular;
            this.Saldo= 0.0;
        }
        public double Deposito(double valor){
            this.Saldo += valor;
            return this.Saldo;
        }
        public bool Saque(double valor){
            if(valor <= this.Saldo){
                this.Saldo-= valor;

            return true;
            } else{
                return false;
            }
        }

        public bool Transferencia(ContaCorrente destino, double valorTrans){
            if (this.Saque(valorTrans)) {
                destino.Deposito(valorTrans);
                return true;
            } else {
                return false;
            }
        }
    }
}
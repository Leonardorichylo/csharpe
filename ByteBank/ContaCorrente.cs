namespace ByteBank
{
    public class ContaCorrente

    //Atributos
    {
        public string titular{get;set;}
        public int agencia{get;set;}
        public int numero{get;set;}
        public double Saldo{get;set;}
        public ContaCorrente(int agencia,int numero,string titular){
            this.agencia = agencia;
            this.numero = numero;
            this.titular = titular;
            this.Saldo= 0.0;
        }
    }
}
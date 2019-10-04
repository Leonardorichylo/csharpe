namespace ByteBank {
    public class Cliente {
        //Atributos
        public string cpf;
        public string nome;
        public string email;
        public string senha;

        //Construtor
        public Cliente (string nome,string cpf, string email) {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }

        public bool TrocaSenha (string senha) {
            if (senha.Length > 6 && senha.Length < 16) {
                this.senha = senha;
                return true;
            } else {
                return false;
            }
        }

    }

}
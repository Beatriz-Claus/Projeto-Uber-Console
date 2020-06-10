namespace Aula13ProjetoUberConsole
{
    public class Cartao
    {
         private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private string titular;
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        private string bandeira;
        public string Bandeira
        {
            get { return bandeira; }
            set { bandeira = value; }
        }
        private string cvv;
        public string Cvv
        {
            get {return cvv;}
            set {cvv = value;}
        }

        public string Cadastrar(){
            if (Numero==null || Titular==null || Bandeira==null || Cvv==null)
                return "Os dados são inválidos.";
            else 
                return "Cadastro realizado com sucesso!";
        }
    }
} 
namespace Aula13ProjetoUberConsole
{
    public class Usuario
    {
        
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string foto;
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        private string localizacaoAtual;
        public string LocalizacaoAtual
        {
            get { return localizacaoAtual; }
            set { localizacaoAtual = value; }
        }
        private string tokenLogin;
        public string TokenLogin
        {
            get { return tokenLogin; }
            set { tokenLogin = value; }
        }
        
        public bool FazerLogin(string l, string s) {
            if ((l!=Login) || (s!=Senha)) {
                System.Console.WriteLine("ERRO! Login ou senha inválidos.");
                return false;
            }
            else if (TokenLogin!=null) {
                System.Console.WriteLine("ERRO! Você já está logado.");
                return false;
            }
            else {
                TokenLogin="csjdfoisjefierjerifjsj83434jrw90jsf09wrj0sei3490wr";
                System.Console.WriteLine("Login realizado com sucesso.");
                return true;
            }
        }

        public void FazerLogout() {
            if (TokenLogin==null) 
                System.Console.WriteLine("ERRO! você não pode fazer logout pois não está logado.");
            else {
                TokenLogin = null;
                System.Console.WriteLine("Logout feito com sucesso.");
            }
        }
    }
}

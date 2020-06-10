namespace Aula13ProjetoUberConsole
{
      public class Passageiro : Usuario
    {
        private Cartao cartao;
        public Cartao Cartao
        {
            get { return cartao;}
            set { cartao = value;}
        }

        public string SolicitarMotorista(){
            if (TokenLogin!=null)
                return "Motorista solicitado!";
            else 
                return "Você não está logado";
        }

        public bool Pagar(){
            if (SolicitarMotorista()=="Motorista solicitado com êxito!"){
                System.Console.WriteLine("Pagamento efetuado com êxito!");
                return true;
            }
            else {
                return false;
            }
        }
    }
} 
namespace Aula13ProjetoUberConsole
{
    public class Motorista : Usuario
    {
        private string carro;
        public string Carro
        {
            get {return carro;}
            set {carro = value;}
        }
        private string placa;
        public string Placa
        {
            get {return placa;}
            set {placa = value;}
        }
        private Conta conta;
        public Conta Conta
        {
            get {return conta;}
            set {conta = value;}
        }

        public string AceitarPassageiro(Passageiro p){
            return $"Passageiro {p.Login} Aceito!";
        }

        public bool ReceberPagamento(Passageiro p){
            if (p.Pagar() == true)
                return true;
            else 
                return false;
        }
    }
} 
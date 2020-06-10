using System;

namespace Aula13ProjetoUberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();

            Conta conta = new Conta();
            conta.Agencia = "0255";
            conta._Conta = "350098";

            Motorista m = new Motorista();
            m.Login = "Beatriz.Claus";
            m.Senha = "090807";
            m.Nome = "Beatriz";
            m.Foto = "3x4";
            m.LocalizacaoAtual = "São Paulo";
            m.Carro = "Kicks";
            m.Conta=conta;

            Cartao cartao = new Cartao();
            cartao.Numero = "9808 9808 9808 9808";
            cartao.Titular = "Beatriz Luanny Claus";
            cartao.Bandeira = "Elo";
            cartao.Cvv = "808";

            Passageiro p = new Passageiro();
            p.Login = "Beatriz";
            p.Senha = "090807";
            p.Cartao = cartao;
            System.Console.Write("Login: ");
            string l = Console.ReadLine();
            System.Console.Write("Senha: ");
            string s = Console.ReadLine();
            p.FazerLogin(l, s);
            System.Console.WriteLine($"{p.SolicitarMotorista()}\n{m.AceitarPassageiro(p)}\n");

            Pagamento p123456789 = new Pagamento();

            System.Console.WriteLine($"\nDados do Pagamento\n{p123456789.Data}\n{p123456789.Status}");

            Corrida c24574522 = new Corrida();
            c24574522.Inicio = "Jd. Peri";
            c24574522.Chegada = "Santana Parque Shopping";
            c24574522.Motorista = m;
            c24574522.Passageiro = p;
            System.Console.WriteLine($"\nDados da Corrida: {c24574522.Inicio}\n{c24574522.Chegada}\n{c24574522.Motorista.Nome}\n{c24574522.Passageiro.Login}");
        }
    }
}
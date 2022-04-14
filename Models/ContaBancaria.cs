namespace Projeto_Sistema_Bancario.Models
{
    public class ContaBancaria
    {
        private double Saldo { get; set; }
        private Titular Titular { get; set; }
        private int Agencia { get; set; }
        private string NumeroDaConta { get; set; }

        public double GetSaldo(double saldo)
        {
            return saldo;
        }
        public void SetSaldo(double saldo)
        {
            Saldo = saldo;
        }
         public Titular GetTitular()
        {
            return Titular;
        }
        public void SetTitular(Titular titular)
        {
            Titular = titular;
        }
        public int GetAgencia(int agencia)
        {
            return agencia;
        }
        public void SetSaldo(int agencia)
        {
            Agencia = agencia;
        }
        public string GetNumeroDaConta(string numerodaconta)
        {
            return numerodaconta;
        }
        public void SetNumeroDaConta(string numerodaconta)
        {
            NumeroDaConta = numerodaconta;
        }
        public void Sacar(double valor)
        {
            valor = valor;
        }
        public void Depositar(double valor)
        {
            valor = valor;
        }

    }
}
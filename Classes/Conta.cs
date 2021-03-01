namespace DIO.Bank
{
    public class Conta
    {

        private TipoConta TipoConta{get;set;}
        private double Saldo { get; set; }
        private double Credito { get; set; } 
        private string Nome { get; set; }

        public Conta(TipoConta _tipoconta, double _saldo, double  _credito, string _nome){
            this.TipoConta = _tipoconta;
            this.Saldo = _saldo;
            this.Credito = _credito;
            this.Nome = _nome;

        }

        
    }
}
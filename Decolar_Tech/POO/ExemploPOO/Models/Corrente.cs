namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.Saldo = valor; //Direto na herança
        }
    }
}
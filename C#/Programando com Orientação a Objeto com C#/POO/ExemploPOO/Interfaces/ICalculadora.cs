namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        //Interfaces sem a implantação de métodos. Estes são implantados na classe herdada
         int Somar(int num1, int num2);
         int Subtrair(int num1, int num2);
         int Multiplicar(int num1, int num2);

         //Interface com a implementação de métodos
         int Dividir(int num1, int num2){
             return num1 / num2;
         }
    }
}
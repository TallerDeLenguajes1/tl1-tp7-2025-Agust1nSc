namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato = 100;
        public void sumar(double termino)
        {
            dato += termino;
        }

        public void restar(double termino)
        {
            dato -= termino;
        }

        public void multiplicar(double termino)
        {
            dato *= termino;
        }
        
        public void dividir(double termino)
        {
            dato /= termino; 
        }

        public void limpiar(double termino)
        {
            dato = 0;
        }

        public double resultado
        {
            get => dato;
        }


    }
}
namespace EntidadesCuadrado
{
    public class Exagono
    {
        private const int _cantidadLados = 6;
        private int _medidaLados;
        
        

        public Exagono()
        {
            
        }

        public void setLado(int medida)
        {
            if(medida>0)
            {
                _medidaLados = medida;
            }
        }

        public Exagono(int MedidaLado) 
        {
            if (MedidaLado > 0)
            {
                _medidaLados = MedidaLado;

            }
            else
            {
                throw new ArgumentException("Medida del Lado No Valida");
            }
            
        }

        public int getLado() => _medidaLados;

        public double getPerimetro() => _cantidadLados * 6;

        public double getArea() => Math.Pow(_medidaLados, 2);

      

       

        
    }
}

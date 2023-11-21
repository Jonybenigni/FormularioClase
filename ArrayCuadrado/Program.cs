namespace ArrayCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayCuadrado = new int[5];

            for(int i = 0; i < arrayCuadrado.Length; i++)
            {
                Console.WriteLine("Ingrese La Medida del Lado: ");

                arrayCuadrado[i] = int.Parse(Console.ReadLine());
            
            }
            Console.WriteLine("Array Lleno ");
            Console.Clear();

            foreach(var item in arrayCuadrado) 
            {
                Console.WriteLine(item);
            }

        }
    }
}
namespace tareaE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, IRS, calculo;
            Console.Write("ingrese su sueldo actual: ");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo <= 416220)
            {
                Console.WriteLine($"su sueldo es de {sueldo}");
                Console.WriteLine(" IRS= N/A");
            }
            else if (sueldo > 416221 && sueldo <= 624329)
            {
                calculo = sueldo - 416220;
                IRS = 0.15 * calculo;
                Console.WriteLine($"su sueldo es de {sueldo}");
                Console.WriteLine($"el IRS es de {IRS}");
            } 
            else if (sueldo > 624330 && sueldo <= 867123)
            {
                calculo = sueldo - 624329;
                IRS = 31216 + (0.2 * calculo);
                Console.WriteLine($"su sueldo es de {sueldo}");
                Console.WriteLine($"el IRS es de {IRS}");
            }
            else
            {
                calculo = sueldo - 867123;
                IRS = 79776 + (0.25 * calculo);

                Console.WriteLine($"su sueldo es de {sueldo}");
                Console.WriteLine($"el IRS es de {IRS}");
            }

         

        }
    }
}
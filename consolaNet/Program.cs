using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre;
              Console.WriteLine("Bienvenido a C#");
               Console.WriteLine("Escribe tu nombre");
             nombre = Console.ReadLine();
               Console.WriteLine("Bienvenido a C#, " + nombre);
              Console.ReadKey();*/

            /*int n = -10;
            Console.Write(Math.Abs(n));
            Console.ReadKey();*/

            /*Console.WriteLine("Mayor de los dos");
            int n1 = 10, n2 = 20;
            Console.WriteLine(Math.Max(n1, n2));
            Console.ReadKey();*/


            /*int basesita = 2;
            int exponente = 5;
            int rta = (int)Math.Pow(basesita, exponente);
            double respuesta = Math.Pow(basesita, exponente);
            Console.WriteLine(respuesta);
            Console.ReadKey();*/

            /*string nom1 = " Johan";
            string nom2 = " Sebastian";
            string ape1 = " Carrillo";
            string ape2 = " Sanchez";
            string nombreCompleto = string.Concat(nom1, "", nom2, "", ape1, "", ape2);
            Console.WriteLine(nombreCompleto.ToUpper());
            Console.ReadKey();*/

            /*int sueldo = 5000;
            Console.WriteLine(sueldo.ToString("C"));
            Console.WriteLine(sueldo.ToString("D5"));
            Console.WriteLine(sueldo.ToString("F2"));
            Console.ReadKey();*/

            /*string nombre1 = "Johan";
            Console.WriteLine(nombre1.Trim());
            Console.ReadKey();*/

            /*string nombre;
            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Su nombre es: " + nombre);
            Console.ReadKey();*/

            /*string nombre1, nombre2, apellido1, apellido2;
            Console.WriteLine("Escriba su primer nombre: ");
            nombre1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Escriba su segundo nombre: ");
            nombre2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Escriba su primer apellido: ");
            apellido1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Escriba su segundo apellido: ");
            apellido2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Su nombre completo es: " + nombre1 + " " + nombre2 + " " + apellido1 + " " + apellido2);
            Console.ReadKey();*/

            /*byte CANB, CANH, CANP; double APAGAR; string linea;
            const double PRECIOB = 0.8;
            const double PRECIOH = 2;
            const double PRECIOP = 1.2;
            Console.Write("CANTIDAD DE HAMBURGUESAS :"); linea = Console.ReadLine();
            CANH = byte.Parse(linea);
            Console.Write("CANTIDAD DE PAPAS :"); linea = Console.ReadLine();
            CANP = byte.Parse(linea);
            Console.Write("CANTIDAD DE BEBIDAS :"); linea = Console.ReadLine();
            CANB = byte.Parse(linea); Console.WriteLine();
            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB); Console.WriteLine("VALOR A PAGAR: " + APAGAR);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();*/

            /*double BASE, ALTURA, RESUL; 
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL)); Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL)); Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL)); Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL)); Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now)); Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",
            DateTime.Now));
            Console.Write("Pulse una Tecla: "); Console.ReadLine();*/

            /*double litroGalon = 3785;
            double numeroGalones;
            double resultado;

            Console.WriteLine("Ingresa un número de galones");
            numeroGalones = double.Parse(Console.ReadLine());
            resultado = numeroGalones * litroGalon;
            Console.WriteLine($"Los {numeroGalones} galones son {resultado} litros.");
            Console.ReadKey();*/

            /*double numero;
            Console.WriteLine("Ingrese un número entero positivo:");
            // Leer la entrada del usuario y convertirla a un número entero
            numero = double.Parse(Console.ReadLine());
            // Calcular cuadrado y cubo utilizando Math.Pow
            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            // Mostrar resultados
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
            Console.WriteLine($"El cubo de {numero} es: {cubo}");
            Console.ReadKey();*/

            /* Console.WriteLine("Ingrese el número de días:");
             int numeroDias = Convert.ToInt32(Console.ReadLine());
             // Calcular el número de segundos en un día
             int segundosEnUnDia = 24 * 60 * 60;
             // Calcular el número total de segundos
             int numeroSegundos = numeroDias * segundosEnUnDia;
             // Mostrar el resultado
             Console.WriteLine("Número de segundos en " + numeroDias + " días: " + numeroSegundos);
             // Esperar a que el usuario presione una tecla para salir
             Console.ReadKey();*/

            /* int x, y, z;
             Console.Write("Digite el primer numero: ");
             x = int.Parse(Console.ReadLine());
             Console.Write("Digite el segundo numero: ");
             y = int.Parse(Console.ReadLine());
             z = x + y;
             Console.Write("la suma es: " + x + "+" + y + "=" + z);

             z = x + y;
             Console.WriteLine("La suma de los numeros es: " + z);

             z = x - y;
             Console.WriteLine("La resta de los numeros es: " + z);

             z = x * y;
             Console.WriteLine("La multiplicacion de los numeros es: " + z);

             z = x / y;
             Console.WriteLine("La division de los numeros es: " + z);

             z = x % y;
             Console.WriteLine("El residuo de la division es: " + z);

             Console.WriteLine("La potencia de los numeros es: " + Math.Pow(x, y));

             Console.ReadKey();*/


            // Solicitar el nombre del alumno
            Console.WriteLine("Ingrese el nombre del alumno:");
            string nombre = Console.ReadLine().ToUpper();

            // Solicitar las tres notas del alumno
            Console.WriteLine("Ingrese la primera nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota:");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el promedio de notas
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Imprimir el nombre del alumno en mayúsculas y su promedio de notas
            Console.WriteLine($"Nombre del alumno: {nombre},promedio:{promedio.ToString("0.00")}");

            // Esperar a que el usuario presione una tecla para salir
            Console.ReadKey();

        }


    }
}
 
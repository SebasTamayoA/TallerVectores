using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerArreglos
{
    internal class Program
    {
        public void Ejercicio1()
        {
            // Solicitar al usuario un número de 4 cifras(dígito por dígito)
            // almacenándolo en un Array, e indicar cuál es el último dígito.

            Console.Write("Ingresar numero de 4 cifras:");
            Console.WriteLine();
            int[] num = new int[4];
            bool error = false;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingresar dígito " + (i + 1) + " :");
                int aux = int.Parse(Console.ReadLine());
                int digits = (int)Math.Floor(Math.Log10(aux) + 1);
                if (digits == 1)
                {
                    num[i] = aux;
                }
                else
                {
                    Console.WriteLine("Solo se admite un dígito");
                    error = true;
                    break;
                }
            }

            Console.WriteLine();

            if (!error)
            {
                Console.WriteLine("El ultimo dígito es: " + num[num.Length - 1]);
            }
            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio2()
        {

            // Solicitar al usuario un número de 4 cifras (dígito por dígito)
            // almacenándolo en un Array, e indicar la suma de esos dígitos.

            Console.Write("Ingresar numero de 4 cifras:");
            Console.WriteLine();
            int[] num = new int[4];
            int sum = 0;
            bool error = false;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingresar dígito " + (i + 1) + " :");
                int aux = int.Parse(Console.ReadLine());
                int digits = (int)Math.Floor(Math.Log10(aux) + 1);
                if (digits == 1)
                {
                    num[i] = aux;
                    sum = sum + num[i];
                }
                else
                {
                    Console.WriteLine("Solo se admite un dígito");
                    error = true;
                    break;
                }
            }

            Console.WriteLine();

            if (!error)
            {
                Console.WriteLine("la suma de los dígitos es: " + sum);
            }
            Console.ReadKey();
        }

        // ===============================================================================

        public void Ejercicio3()
        {

            // Solicitar al usuario un número de 4 cifras(dígito por dígito)
            // almacenándolo en un Array,e indicar cuál es el primer dígito.

            Console.Write("Ingresar numero de 4 cifras:");
            Console.WriteLine();
            int[] num = new int[4];
            bool error = false;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingresar dígito " + (i + 1) + " :");
                int aux = int.Parse(Console.ReadLine());
                int digits = (int)Math.Floor(Math.Log10(aux) + 1);
                if (digits == 1)
                {
                    num[i] = aux;
                }
                else
                {
                    Console.WriteLine("Solo se admite un dígito");
                    error = true;
                    break;
                }
            }

            Console.WriteLine();

            if (!error)
            {
                Console.WriteLine("El primer dígito es: " + num[0]);
            }
            Console.ReadKey();

        }

        // ==========================================================================

        public void Ejercicio4()
        {
            //Solicitar al usuario un número de 4 cifras (dígito por dígito) 
            //almacenándolo en un Array, al final procesar esos dígitos, 
            //para indicar el número completo. Por ej: Ingresó 4 - 7 - 1 - 2. 
            //Como resultado va a mostrar el número completo 4712. 
            //Nota: Se debe realizar efectuando una operación matemática, 
            //y NO simplemente imprimiendo cada dígito de la posición.

            Console.Write("Ingresar numero de 4 cifras:");
            Console.WriteLine();
            int[] num = new int[4];
            bool error = false;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Ingresar dígito " + (i + 1) + " :");
                int aux = int.Parse(Console.ReadLine());
                int digits = (int)Math.Floor(Math.Log10(aux) + 1);
                if (digits == 1)
                {
                    num[i] = aux;
                }
                else
                {
                    Console.WriteLine("Solo se admite un dígito");
                    error = true;
                    break;
                }
            }

            Console.WriteLine();

            if (!error)
            {
                Console.Write("el numero completo es: ");
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i]);
                }

                Console.ReadKey();
            }

        }

        // =================================================================================

        public void Ejercicio5()
        {

            //Desarrollar un algoritmo, para recorrer los números del 1 al 100, almacenándolos en un Array, 
            //luego recorriendo el Array indique cuáles de estos son múltiplos de 5.

            int[] num = new int[100];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
            }

            Console.WriteLine("Numeros del 1 al 100 multiplos de 5: ");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 5 == 0)
                {
                    Console.WriteLine(num[i]);
                }

            }
            Console.ReadKey();
        }

        // ================================================================================

        public void Ejercicio6()
        {
            //Desarrolle un algoritmo que lea por teclado 5 notas de estudiantes(en número) almacenándolas en un Array,
            //después recorriendo el Vector mostrar esas notas en letras específicas, según:
            //Si la nota está entre 0 y 1 = D
            //Si es mayor a 1 y menor a 3 = I
            //Si está entre 3.1 y 4.4 = B
            //Si es mayor a 4.4 = E
            //Si no es ninguna, indicar, que no es una nota válida.
            //Este resultado debe ser visualizado en pantalla, las 5 veces.

            double[] notes = new double[5];
            Console.WriteLine("Ingrese notas de estudiante: ");
            for (int i = 0; i < notes.Length; i++)
            {
                Console.Write("Ingrese nota " + (i + 1) + " : ");
                notes[i] = double.Parse(Console.ReadLine());
                if (notes[i] >= 0 && notes[i] <= 1)
                {
                    Console.WriteLine("Nota: D");
                }
                else if (notes[i] > 1 && notes[i] <= 3)
                {
                    Console.WriteLine("Nota: I");
                }
                else if (notes[i] >= 3.1 && notes[i] < 4.4)
                {
                    Console.WriteLine("Nota: B");
                }
                else if (notes[i] > 4.4 && notes[i] <= 5)
                {
                    Console.WriteLine("Nota: E");
                }
                else
                {
                    Console.WriteLine("No es una nota válida");
                }
            }
            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio7()
        {
            //Teniendo en cuenta el ejercicio anterior, realizar lo siguiente:
            //Leer 5 notas por teclado.De estas notas realizar su promedio y a partir de ese promedio,
            //realizar las mismas validaciones del Ejercicio 6(para mostrar el valor numérico en Letra).

            double[] notes = new double[5];
            double average = 0;
            double sum = 0;
            Console.WriteLine("Ingrese notas de estudiante: ");

            for (int i = 0; i < notes.Length; i++)
            {
                Console.Write("Ingrese nota " + (i + 1) + " : ");
                notes[i] = double.Parse(Console.ReadLine());
                sum = sum + notes[i];
            }

            average = sum / 5;
            Console.WriteLine();
            Console.WriteLine("El promedio es: " + average);
            Console.WriteLine();

            if (average >= 0 && average <= 1)
            {
                Console.WriteLine("Nota: D");
            }
            else if (average > 1 && average <= 3)
            {
                Console.WriteLine("Nota: I");
            }
            else if (average >= 3.1 && average < 4.4)
            {
                Console.WriteLine("Nota: B");
            }
            else if (average > 4.4 && average <= 5)
            {
                Console.WriteLine("Nota: E");
            }
            else
            {
                Console.WriteLine("No es una nota válida");
            }

            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio8()
        {
            //Leer un número por teclado, y de ese número buscar qué números dividen exactamente
            //al número ingresado.Los números que lo dividen exactamente van a quedar
            //almacenados en un Array, para mostrarlos luego.Por ej: Ingreso el número 6, es dividido
            //exactamente por 1, 2, 3, 6.
            //Console.ReadKey();

            Console.WriteLine("Ingrese un numero entero: ");
            int num = int.Parse(Console.ReadLine());
            int[] dividers = new int[num];
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    dividers[i - 1] = i;

                    Console.WriteLine("El numero " + num + " es divisible exactamente por: " + dividers[i - 1]);
                }
            }

            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio9()
        {
            //Hacer un programa para llenar un arreglo e imprimirlo,
            //con los números del 1 al 15.

            int[] nums = new int[15];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }
            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio10()
        {
            // Hacer un programa para llenar un arreglo e imprimirlo,
            // con los números del 5 al 15.

            int[] nums = new int[11];
            int count = 4;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = count + 1;
                count++;
            }

            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio11()
        {
            //Hacer un programa para llenar un arreglo e imprimirlo,
            //con los números del 20 al 0.

            int[] nums = new int[21];
            int count = 21;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = count - 1;
                count--;
            }

            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio12()
        {
            // Hacer un programa que con los números del 1 al 100, llene un arreglo y lo imprima,
            //con los números pares de ese rango.

            int[] nums = new int[50];
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    nums[count] = i;
                    count++;
                }


            }

            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio13()
        {
            // Hacer un programa que con los números del 1 al 100, llene un arreglo y lo imprima,
            //con los números impares de ese rango.

            int[] nums = new int[50];
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums[count] = i;
                    count++;
                }


            }

            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio14()
        {
            //Diseñar un algoritmo, que permita guardar en un arreglo, los números múltiplos de 3,
            //en un rango comprendido entre 1 y 30.

            int[] nums = new int[10];
            int count = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    nums[count] = i;
                    count++;
                }


            }

            Console.WriteLine("El arreglo de numeros es: ");
            Console.Write("[");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(" " + nums[i] + " ");
            }
            Console.WriteLine("]");
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio15()
        {
            //Hacer un programa que con los números del 1 al 100, llene un arreglo y lo imprima,
            //con los números pares de ese rango, indicando en qué posición del arreglo quedó.

            int[] nums = new int[50];
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    nums[count] = i;
                    count++;
                }
            }

            Console.WriteLine("El arreglo de numeros es: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(" El número " + nums[i] + " está en la posición " + i + " del arreglo");
            }

            Console.ReadKey();
        }

        // ==============================================================================

        public void Ejercicio16()
        {
            //Hacer un programa que con los números del 1 al 100, llene un arreglo y lo imprima,
            //con los números impares de ese rango, indicando en qué posición del arreglo quedó.

            int[] nums = new int[50];
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums[count] = i;
                    count++;
                }
            }
            Console.WriteLine("El arreglo de numeros es: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(" El número " + nums[i] + " está en la posición " + i + " del arreglo");
            }

            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio17()
        {
            //Hacer un programa que con los números del 1 al 50, llene un arreglo con los números
            //pares de ese rango. (2, 4, 6…50). Luego hacer el recorrido de los datos del arreglo,
            //para realizar la sumatoria de esos números pares e indicar su resultado

            int[] nums = new int[25];
            int count = 0;
            int sum = 0;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    nums[count] = i;
                    sum = sum + i;
                    count++;
                }
            }

            Console.WriteLine("La suma de los numeros pares del 1 al 50 es: " + sum);
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio18()
        {
            // Hacer un programa que con los números del 1 al 50, llene un arreglo con los números
            //impares de ese rango. (1, 3, 5…49). Luego hacer el recorrido de los datos del arreglo,
            //para realizar el producto de esos números impares e indicar su resultado

            int[] nums = new int[25];
            int count = 0;
            double multiplication = 1;

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    nums[count++] = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                multiplication *= nums[i];
            }

            Console.WriteLine("La multiplicación de los números impares del 1 al 50 es: " + multiplication);
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio19()
        {
            // Implementar un algoritmo que en un arreglo, introduzca los números del 0 al 100,
            //luego recorrer dicho arreglo para sumar estos valores e imprimir el resultado. 

            int[] nums = new int[101];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
                sum = sum + i;
            }

            Console.WriteLine("La suma de los numeros del 0 al 100 es: " + sum);
            Console.ReadKey();

        }

        // ==============================================================================

        public void Ejercicio20()
        {
            //Implementar un algoritmo que en un arreglo almacene los números del 1 al 50, luego
            //recorrer dicho arreglo para sumar de estos valores, solo aquellos que se encuentran
            //en posiciones pares e imprimir el resultado.

            int[] nums = new int[50];
            int sum = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                nums[i - 1] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + nums[i];
                }
            }

            Console.WriteLine("La suma de los numeros del 1 al 50 en posiciones pares es: " + sum);
            Console.ReadKey();
        }

        // ==============================================================================

        static void Main(string[] args)
        {
            Program nums = new Program();
            //nums.Ejercicio1();
            //nums.Ejercicio2();
            //nums.Ejercicio3();
            nums.Ejercicio4();
            //nums.Ejercicio5();
            //nums.Ejercicio6();
            //nums.Ejercicio7();
            //nums.Ejercicio8();
            //nums.Ejercicio9();
            //nums.Ejercicio9();
            //nums.Ejercicio10();
            //nums.Ejercicio11();
            //nums.Ejercicio12();
            //nums.Ejercicio13();
            //nums.Ejercicio14();
            //nums.Ejercicio14();
            //nums.Ejercicio15();
            //nums.Ejercicio16();
            //nums.Ejercicio17();
            //nums.Ejercicio18();
            //nums.Ejercicio19();
            //nums.Ejercicio20();
        }
    }
}

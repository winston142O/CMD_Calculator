using System;

class Calculadora
{
    static void Main()
    {
        double num1, num2, result;
        char op;
        bool stay = true;

        while (stay)
        {
            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un operador (+, -, *, /): ");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: {0}", result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: {0}", result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: {0}", result);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("El resultado de la división es: {0}", result);
                    }
                    break;
                default:
                    Console.WriteLine("Ese operador no es válido.");
                    break;
            }

            Console.WriteLine("¿Desea realizar otra operación? (s/n)");
            string respuesta = Console.ReadLine();
            stay = respuesta.ToLower() == "s";
        }
    }

}


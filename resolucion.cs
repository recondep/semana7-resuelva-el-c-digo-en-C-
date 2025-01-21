Código en C#
1. Verificación de Balanceo de Paréntesis
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = "{7+(8*5)-[(9-7)+(4+1)]}";
        if (IsBalanced(expression))
        {
            Console.WriteLine("La fórmula está balanceada.");
        }
        else
        {
            Console.WriteLine("La fórmula no está balanceada.");
        }
    }

    /// <summary>
    /// Verifica si la expresión tiene paréntesis balanceados.
    /// </summary>
    /// <param name="expression">La expresión a verificar.</param>
    /// <returns>True si está balanceada, de lo contrario false.</returns>
    static bool IsBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in expression)
        {
            if (c == '{' || c == '(' || c == '[')
            {
                stack.Push(c); // Agrega el carácter de apertura a la pila.
            }
            else if (c == '}' || c == ')' || c == ']')
            {
                if (stack.Count == 0) return false; // Verifica si la pila está vacía.
                char top = stack.Pop(); // Retira el carácter de apertura de la pila.
                if (!IsMatchingPair(top, c))
                {
                    return false; // Verifica si hay un par correspondiente.
                }
            }
        }
        return stack.Count == 0; // Devuelve true si la pila está vacía.
    }

    /// <summary>
    /// Verifica si los caracteres de apertura y cierre son un par correspondiente.
    /// </summary>
    /// <param name="open">Carácter de apertura.</param>
    /// <param name="close">Carácter de cierre.</param>
    /// <returns>True si son un par, de lo contrario false.</returns>
    static bool IsMatchingPair(char open, char close)
    {
        return (open == '{' && close == '}') ||
               (open == '(' && close == ')') ||
               (open == '[' && close == ']');
    }
}

2. Torres de Hanoi
using System;

class Program
{
    static void Main()
    {
        int n = 3; // Número de discos
        Console.WriteLine("Movimientos para resolver las Torres de Hanoi:");
        SolveHanoi(n, 'A', 'C', 'B'); // A: origen, C: destino, B: auxiliar
    }

    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi de manera recursiva.
    /// </summary>
    /// <param name="n">Número de discos.</param>
    /// <param name="source">Torre de origen.</param>
    /// <param name="destination">Torre de destino.</param>
    /// <param name="auxiliary">Torre auxiliar.</param>
    static void SolveHanoi(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {source} a {destination}");
            return;
        }
        SolveHanoi(n - 1, source, auxiliary, destination); // Mueve n-1 discos a la torre auxiliar.
        Console.WriteLine($"Mover disco {n} de {source} a {destination}"); // Mueve el disco n a la torre de destino

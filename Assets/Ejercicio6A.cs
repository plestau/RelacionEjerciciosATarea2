using System;
using UnityEngine;

public class Ejercicio6A : MonoBehaviour
{
    public int numero;

    private void Start()
    {
        int resultado = CalcularFactorialDeNumero(numero);
        Debug.Log("Ejercicio 6A: El factorial de " + numero + " es: " + resultado);
    }

    private int CalcularFactorialDeNumero(int n)
    {
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
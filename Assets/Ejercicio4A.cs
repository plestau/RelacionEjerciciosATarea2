using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4A : MonoBehaviour
{
    private bool esPar;
    public int numero1;
    public int numero2;

    private void Start()
    {
        int suma = numero1 + numero2;
        if (suma % 2 == 0)
        {
            esPar = true;
        }
        else
        {
            esPar = false;
        }
        Debug.Log("Ejercicio 4A: " + esPar);
    }
}

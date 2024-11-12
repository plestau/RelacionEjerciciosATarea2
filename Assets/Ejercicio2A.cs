using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2A : MonoBehaviour
{
    public float numero1;
    public float numero2;

    private void Start()
    {
        float sumados = numero1 + numero2;
        float restados = numero1 - numero2;
        float multiplicados = numero1 * numero2;
        float divididos = numero1 / numero2;

        Debug.Log(
            "Ejercicio 2A: Sumados: " + sumados + ", restados: " + restados + ", multiplicados: " + multiplicados + ", divididos: " + divididos);
    }
}

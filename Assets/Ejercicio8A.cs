using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Ejercicio8A : MonoBehaviour
{
    private int contador = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ejercicio 8A: " + contador);
        contador += 1;
    }
}
*/

public class Ejercicio8A : MonoBehaviour
{
    private float tiempoAnterior;

    private void Start()
    {
        tiempoAnterior = Time.time;
    }

    private void Update()
    {
        float tiempoTranscurrido = Time.time - tiempoAnterior;

        Debug.Log("Ejercicio 8A: Tiempo transcurrido desde el último fotograma: " + tiempoTranscurrido + " segundos");

        tiempoAnterior = Time.time;
    }
}

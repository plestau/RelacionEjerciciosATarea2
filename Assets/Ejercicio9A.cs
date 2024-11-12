using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9A : MonoBehaviour
{
    private float tiempoAnterior;
    private float contadorFotogramas;

    private void Start()
    {
        tiempoAnterior = Time.time;
    }
    
    private void Update()
    {
        contadorFotogramas += 1;
        if (contadorFotogramas % 100 == 0)
        {
            float tiempoTranscurrido = Time.time - tiempoAnterior;
            Debug.Log("Ejercicio 9A: Tiempo transcurrido desde el inicio: " + tiempoTranscurrido + " segundos");
        }
    }
}

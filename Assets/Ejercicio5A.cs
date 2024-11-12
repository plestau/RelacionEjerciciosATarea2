using System;
using UnityEngine;

public class Ejercicio5A : MonoBehaviour
{
    private void Start()
    {
        DayOfWeek diaActual = DateTime.Now.DayOfWeek;

        if (diaActual == DayOfWeek.Thursday)
        {
            Debug.Log("Ejercicio 5A: Hoy es jueves");
        }
        else
        {
            Debug.Log("Ejercicio 5A: Hoy no es jueves");
        }
    }
}
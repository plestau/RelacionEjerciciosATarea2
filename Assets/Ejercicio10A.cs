using UnityEngine;

public class Ejercicio10A : MonoBehaviour
{
    private int probabilidad;
    private float intervalo = 10f;
    private float tiempoAcumulado = 0f;

    private void Start()
    {
        probabilidad = Random.Range(0, 101);
        Debug.Log("Ejercicio10A: Número inicial: " + probabilidad);
    }

    private void Update()
    {
        tiempoAcumulado += Time.deltaTime;

        if (tiempoAcumulado >= intervalo)
        {
            tiempoAcumulado = 0f;
            int numeroAleatorio = Random.Range(0, 101);
            if (numeroAleatorio > probabilidad)
            {
                Debug.Log("Ejercicio10A: Acierto (" + numeroAleatorio + ")");
            }
            else
            {
                Debug.Log("Ejercicio10A: Fallo (" + numeroAleatorio + ")");
            }
        }
    }
}
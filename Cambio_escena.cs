//Nombre del desarrollador: Alejandra Bravo A.
//Asignatura: Estructura de datos
//Descripción del uso de este código:
/*
Cambio escenas
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambio_escena : MonoBehaviour
{
    [Tooltip("esta variable me ayuda a definir el num de escena a cargar")]
    public int numEscena;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(numEscena);
        }
    }
}

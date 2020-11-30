using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorScript : MonoBehaviour
{
    [SerializeField] Text TextContador;

    // Start is called before the first frame update
    // No sé como hacer para que al iniciar el contador cuente para siempre sin crear un bucle infinito
    void Start()
    {
        for (int n = 0; n < 10; n++)
        {
            TextContador.text = "Tiempo de juego transcurrido: " + n + "s";
        }
    }
    
    // Update is called once per frame
    void Update()
    {
            
       
     }
    //Método creado por mí para que el contador funcione mediante corrutinas
    IEnumerator Cronometro()
    {
        while (true)
        {
            for (int n = 0; < 10; n++)
            {
               
                yield return new WaitForSeconds(speed);
            }
        }
    }
}

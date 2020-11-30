using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorScript : MonoBehaviour
{
    [SerializeField] Text TextContador;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
         while (true)
        {
            for (int n = 0; ; n++)
            {
                TextContador.text = "Tiempo de juego transcurrido: " + n + "s";
             }
        }
     }
            
}

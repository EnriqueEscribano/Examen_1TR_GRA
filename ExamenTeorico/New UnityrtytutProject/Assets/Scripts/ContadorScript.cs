using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorScript : MonoBehaviour
{
    [SerializeField] Text MyText;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");
    }
    
    // Update is called once per frame
    void Update()
    {
         while (true)
        {
            for (int n = 0; ; n++)
            {
                MyText.text = "Tiempo de juego transcurrido: " + n + "s";
             }
        }
     }
            
}

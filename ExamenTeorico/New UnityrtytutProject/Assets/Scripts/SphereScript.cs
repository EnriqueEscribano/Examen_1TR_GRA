using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    
    [SerializeField] float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float desplY = Input.GetAxis("Vertical") * speed;

        transform.Translate(Vector3.up * desplY * Time.deltaTime);


        float desplX = Input.GetAxis("Horizontal") * speed;

        transform.Translate(Vector3.left * desplX * Time.deltaTime);
    }

  
}

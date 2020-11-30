using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour
{

    [SerializeField] GameObject CylinderPrefab;
    [SerializeField] Transform InitPos;

    Vector3 NewPos;


   // Start is called before the first frame update
    void Start()
    {
        int y = 0;

        for (int n = 0; n < 10; n++)
        {
            Vector3 CambioPos = new Vector3(y, 0, 0);
            NewPos = InitPos.position + CambioPos;

            Instantiate(CylinderPrefab, NewPos, Quaternion.identity);

            y += 2; //Por cada vuelta de ciclo, suma 2 a la vaiable y.
        }
        
    }
}

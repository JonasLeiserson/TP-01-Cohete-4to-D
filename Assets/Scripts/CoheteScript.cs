using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
     
{
    public float velocidad = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, velocidad, 0f);
    }

    public void Despegue()
    {
       velocidad = 0.1f;
        transform.Rotate(45f0f, 0f);
    }
}

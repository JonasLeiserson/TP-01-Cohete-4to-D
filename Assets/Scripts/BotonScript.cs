﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public GameObject llama;
    public CoheteScript CoheteScript;
    public GameObject torres;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        botonGO.SetActive(false);
        llama.SetActive(true);
        CoheteScript.Despegue();
        torres.SetActive(true);
    
    }

    void OnMouseUp()
    {
        botonGO.SetActive(true);
        llama.SetActive(false);
    }
}

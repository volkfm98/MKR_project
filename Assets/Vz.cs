﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vz : MonoBehaviour
{
    public GameObject obj1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        { obj1.SetActive(false); }
    }
}

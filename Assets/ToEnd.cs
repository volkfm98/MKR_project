﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToEnd : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
    	SceneManager.LoadScene("End");
    }
}

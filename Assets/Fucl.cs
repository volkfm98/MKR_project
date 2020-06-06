using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[AddComponentMenu ("My components/Fucl")]
public class Fucl : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D mycollaider)
    { 
   if (mycollaider.tag == "Player")
        { SceneManager.LoadScene("3_LVL"); }
    }
}

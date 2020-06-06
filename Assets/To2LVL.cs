using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To2LVL : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collider)
	{
		SceneManager.LoadScene("2_lvl");
	}
}

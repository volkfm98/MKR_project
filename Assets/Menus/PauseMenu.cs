﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] private GameObject pauseMenuUI;

	[SerializeField] public bool isPaused;

    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Escape))
    	{
    		isPaused = !isPaused;
    	}

    	if(isPaused)
    	{
    		ActivateMenu();
    	}
    	else
    	{
    		DeactivateMenu();
    	}
    }

    void ActivateMenu()
    {	
    	Time.timeScale = 0;
    	pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
    	Time.timeScale = 1;
    	pauseMenuUI.SetActive(false);
    	isPaused = false;
    }

    public void Quit()
    {
    	Application.Quit();
    }
}

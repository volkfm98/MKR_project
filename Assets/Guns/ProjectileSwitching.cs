using UnityEngine;
using UnityEngine.UI;

public class ProjectileSwitching : MonoBehaviour
{	
	//Select standart projectile
	public int selectedWeapon = 0;
    public Text selectedWeaponUI;

    // Start is called before the first frame update
    void Start()
    {
     	SelectWeapon();   
    }

    // Update is called once per frame
    void Update()
    {	
    	var previousSelectedWeapon = selectedWeapon;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f) 
        {
    		if(selectedWeapon >= transform.childCount - 1)
    			selectedWeapon = 0;
			else
        		selectedWeapon++;
        }

        if(Input.GetAxis("Mouse ScrollWheel") < 0f) 
        {
    		if(selectedWeapon <= 0)
    			selectedWeapon = transform.childCount - 1;
			else
        		selectedWeapon--;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
        	SelectWeapon();
        }
    }

    void SelectWeapon()
    {	
    	var gun = FindObjectsOfType<SpideyGun>()[0];
        string[] projectileNames = new string[3] {"Обычный", "Антигравитационный", "Отскакивающий"};

    	int i = 0;
    	foreach(Transform projectile in transform)
    	{
    		if(i==selectedWeapon)
    		{
    			gun.m_Projectile = projectile.gameObject;
                selectedWeaponUI.text = projectileNames[i];
    		}

    		i++;
    	}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public void GetDirection(Vector3 direction)
    {
        InputProvider.TriggerDirection(direction);
    }
    public void ShotPressed()
    {
        InputProvider.TriggerOnHasShoot();
    }

    private void Update()
    {

        if (Input.GetButtonDown("Shoot")) 
        { 
            ShotPressed();
        }

        GetDirection( new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
    }
}

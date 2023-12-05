using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adapted from BMO, 2020. ChestController.cs. N/A: BMo.

public class BombController : MonoBehaviour
{
    public bool isDisarmed;

//If the bomb is disarmed. Display this debug message
public void DisarmBomb()
    {
        if(!isDisarmed)
        {
            isDisarmed = true;
            Debug.Log("Bomb has been disarmed");
        }
    }
}

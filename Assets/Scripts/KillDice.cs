using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDice : MonoBehaviour
{
    public void Kill()
    {
        foreach(var dice in Spawndice.CreatedDice)
        {   
            Destroy(dice);
        }  
        Spawndice.CreatedDice.Clear();
    }

    public void Undo()
    {   
        Destroy(Spawndice.CreatedDice[Spawndice.CreatedDice.Count - 1]);
        Spawndice.CreatedDice.RemoveAt(Spawndice.CreatedDice.Count - 1);
    }
}

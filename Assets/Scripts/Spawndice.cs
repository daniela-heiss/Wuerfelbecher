using System.Collections.Generic;
using UnityEngine;

public class Spawndice : MonoBehaviour
{   
    public GameObject Dice;
    public GameObject Point;

    public void Click(){
        var newDice = Instantiate (Dice, Point.transform.position, Quaternion.identity, Point.transform);
    }
}

//public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
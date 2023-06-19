using System.Collections.Generic;
using UnityEngine;

public class Spawndice : MonoBehaviour
{   
    public GameObject Dice;
    public GameObject Point;
    public static List <GameObject> CreatedDice = new List<GameObject>();

    public void Click(){
        var newDice = Instantiate (Dice, Point.transform.position, Quaternion.identity, Point.transform);
        CreatedDice.Add(newDice);
    }
}

//public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
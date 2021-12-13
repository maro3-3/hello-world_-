using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone_ishikado : MonoBehaviour
{
    DataBase database = null;
    static int[] TurnCount;

    // Start is called before the first frame update
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        TurnCount = new int[database.PossessionDroneNum];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setdrone(int num)
    {
        TurnCount[num] = database.TurnNum;
    }
}

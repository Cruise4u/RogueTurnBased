using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetingType
{
    Auto,
    Free,
    Trail,
}

public abstract class AbilityTargetingContext
{
    public virtual GameObject originalTarget { get; }
    public abstract AbilityData abilityData { get; }
    public abstract void CreateTargetingDisplay(GameObject cellAimDisplay);

    public abstract List<GameObject> cellTargetRangeList { get; }

    public abstract GameObject[] GetCellTargetingArray();
}

public class TrailTargetingContext : AbilityTargetingContext
{
    public GameObject targetCell;
    public override AbilityData abilityData => Resources.Load<AbilityData>("");

    public override List<GameObject> cellTargetRangeList => new List<GameObject>();

    public override void CreateTargetingDisplay(GameObject cellAimDisplay)
    {
        if(GetType() == typeof(TrailTargetingContext))
        {

        }
    }


    public void CreateList()
    {

    }



    public override GameObject[] GetCellTargetingArray()
    {
        GameObject[] cellTargetArray = new GameObject[abilityData.range];
        for (int i = 0; i < cellTargetArray.Length; i++)
        {
            var cellTarget = GameObject.Instantiate(originalTarget);
            cellTargetArray[i] = cellTarget;
        }
        return cellTargetArray;
    }

     
}
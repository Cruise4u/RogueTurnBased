using System.Collections;
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

    public abstract GameObject[] GetCellTargetingArray();
}

public class TrailTargetingContext : AbilityTargetingContext
{
    public override AbilityData abilityData => Resources.Load<AbilityData>("");

    public override void CreateTargetingDisplay(GameObject cellAimDisplay)
    {
        if(GetType() == typeof(TrailTargetingContext))
        {

        }
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class GridData : ScriptableObject
{
    public int width;
    public int height;
    public int widthMargin;
    public int heightMargin;
    public CellObject cellOriginalObject;
    public SpriteDataMap spriteDataMap;
}

public class CellReferencer
{
    public static Dictionary<Cell, CellObject> cellDictionary;

    public static void LinkCells(Cell cell,CellObject cellObject)
    {
        if(!cellDictionary.ContainsKey(cell))
        {
            cellDictionary.Add(cell, cellObject);
        }
    }


}
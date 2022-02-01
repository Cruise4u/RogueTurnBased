using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CellReferencer
{
    public static Dictionary<Cell, CellObject> cellDictionary;

    public static void Init()
    {
        cellDictionary = new Dictionary<Cell, CellObject>();
    }

    public static void LinkCells(Cell cell, CellObject cellObject)
    {
        if (!cellDictionary.ContainsKey(cell))
        {
            cellDictionary.Add(cell, cellObject);
        }
    }


}
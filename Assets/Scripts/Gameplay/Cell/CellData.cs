using System;
using System.Collections;
using UnityEngine;

public class CellData
{
    public int x { get; }
    public int y { get; }
    public bool isTransversable { get; set; }

    public CellData(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

}

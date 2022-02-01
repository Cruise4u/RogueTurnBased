using System;
using System.Collections;
using UnityEngine;

public class Cell
{
    public int xPosition { get; }
    public int yPosition { get; }
    public bool isTransversable { get; set; }

    public Cell(int xPosition,int yPosition)
    {
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

}

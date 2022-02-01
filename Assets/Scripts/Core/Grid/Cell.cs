using System;
using System.Collections;
using UnityEngine;


public class CellObject : MonoBehaviour
{
    public Cell cell;
    public BoxCollider2D boxCollider;

    public void Init()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void Start()
    {
        Init();
    }
}

public class Cell
{
    public int xPosition { get; set; }
    public int yPosition { get; set; }
    public bool isTransversable { get; set; }

    public Cell(int xPosition, int yPosition)
    {
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

}

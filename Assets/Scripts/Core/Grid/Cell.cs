using System;
using System.Collections;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public int xPosition { get; set; }
    public int yPosition { get; set; }
    public bool isTransversable { get; set; }


    public void Init(int xPosition,int yPosition)
    {
        this.xPosition = xPosition;
        this.yPosition = yPosition;
        boxCollider = GetComponent<BoxCollider2D>();
    }



    public void AssignCellSpriteImage(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

}




public class CellObject : MonoBehaviour
{
    public Cell cell;

    public void Init()
    {

    }

    public Cell GetCell(int xPosition,int yPosition)
    {
        return CellReference.cellArray[xPosition, yPosition];
    }


}


public class CellReference
{
    public static Cell[,] cellArray;

}
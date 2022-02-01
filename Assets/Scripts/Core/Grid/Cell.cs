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
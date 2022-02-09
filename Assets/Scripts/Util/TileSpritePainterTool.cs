using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpritePainterTool
{
    public static void DrawSpriteOnCell(Cell cellObject, Sprite sprite)
    {
        cellObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
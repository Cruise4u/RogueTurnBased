using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpritePainterTool
{
    public static void DrawSpriteOnCell(CellObject cellObject, Sprite sprite)
    {
        cellObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }

}
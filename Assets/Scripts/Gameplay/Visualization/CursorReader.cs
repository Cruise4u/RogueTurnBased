using System;
using UnityEngine;


public class CursorReader 
{
    public CursorReader()
    {

    }

    public Cell GetCellObjectHighlightedUnderCursor()
    {
        if(RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            var currentSelectedCell = RaycastTool.GetCellObject().GetComponent<Cell>();
            return currentSelectedCell;
        }
        else
        {
            return null;
        }
    }

    public void ShowInfoFromTile()
    {
        //In the GUI pass text that says :
        //Tile type
        //Character habitating it
        //If  there's something on it
        //etc..
        //General Info about cell
    }
}




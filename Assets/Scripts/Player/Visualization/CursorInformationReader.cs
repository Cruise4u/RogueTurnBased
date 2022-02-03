using System;
using UnityEngine;


public class CursorInformationReader 
{
    private GameObject cellNormalDisplayObject;
    private GameObject cellAbilityDisplayObject;

    public CursorInformationReader(GameObject cellNormalDisplayObject)
    {
        this.cellNormalDisplayObject = cellNormalDisplayObject;
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

    public void SetCellObjectHighlightedUnderCursor()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            var currentSelectedCell = RaycastTool.GetCellObject();
            cellNormalDisplayObject.transform.position = currentSelectedCell.transform.position;
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
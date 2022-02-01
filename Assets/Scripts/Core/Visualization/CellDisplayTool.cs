using System;
using UnityEngine;


public class CellDisplayTool
{
    private GameObject cellNormalDisplayObject;
    private GameObject cellAbilityDisplayObject;

    public CellDisplayTool(GameObject cellNormalDisplayObject)
    {
        this.cellNormalDisplayObject = cellNormalDisplayObject;
    }

    public void HighlightCellUnderCursor()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.cellTag))
        {
            var currentSelectedCell = RaycastTool.GetCellObject();
            cellNormalDisplayObject.transform.position = currentSelectedCell.transform.position;
            Debug.Log("X:" + currentSelectedCell.GetComponent<CellObject>().cell.xPosition + "Y:" + currentSelectedCell.GetComponent<CellObject>().cell.yPosition);
        }
    }


    public void CalculateCellRangeFromCasterToTarget()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.cellTag))
        {
            var currentSelectedCell = RaycastTool.GetCellObject();
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
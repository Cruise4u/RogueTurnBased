using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject cursorDisplayObject;

    public void UpdateCursorPosition()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            cursorDisplayObject.transform.position = RaycastTool.GetCellObject().transform.position;
        }
    }

    public Cell GetCellObjectUnderCursor()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            return RaycastTool.GetCellObject().GetComponent<Cell>();
        }
        else
        {
            return null;
        }
    }

    public void Init()
    {
        cursorDisplayObject = FindObjectOfType<CursorObject>().gameObject;
    }



    public void GetCalculatedDistanceFromCurrentActorLocation()
    {
        var gridPosition = ReferenceManager.gridContext.CellArray[GetComponent<Movement>().x, GetComponent<Movement>().y];
        GridDistanceCalculator.GetCalculatedDistance(gridPosition);
    }
}

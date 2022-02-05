using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    private CursorReader cursorInformationReader;
    private GameObject cursorCellDisplay;
    private GameObject cellAbilityDisplayObject;

    // **ATTENTION**

    // It's required to implement an observer/receiver to pass information from the selected coordinates from mouse input every frame
    // To ActorMovement, so by the time it issues a click event
    // The Move Command can be executed and send data to actorMovement to peform it's functionality correctly!
    
    // **ATTENTION**

    #region In Start()
    public void Start()
    {
        Init();
    }
    public void Init()
    {
        cursorInformationReader = new CursorReader();
    }
    #endregion

    #region In Update()
    public void Update()
    {
        UpdateHighlightCellPosition();
        if (Input.GetMouseButtonDown(0))
        {
            GetCellObjectUnderCursorPosition();
        }
    }
    public void UpdateHighlightCellPosition()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            var currentSelectedCell = RaycastTool.GetCellObject();
            cursorCellDisplay.transform.position = currentSelectedCell.transform.position;
        }
    }



    public Cell GetCellObjectUnderCursorPosition()
    {
        if (RaycastTool.IsHitted(GUIController.baseCamera, GUIController.usableMask))
        {
            var cellGO = RaycastTool.GetCellObject();
            var cellobject = cellGO.GetComponent<Cell>();
            return cellobject;
        }
        else
        {
            return null;
        }
    }



    #endregion

    #region Interfaces


    #endregion
}
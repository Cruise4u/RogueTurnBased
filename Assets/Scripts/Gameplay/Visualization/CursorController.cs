using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour, IReferenceReceiver
{
    private CursorReader cursorInformationReader;
    private GameObject cursorCellDisplay;
    private GameObject cellAbilityDisplayObject;

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
    public void GetNotified()
    {
        throw new System.NotImplementedException();
    }
    #endregion

    #region Interfaces


    #endregion
}
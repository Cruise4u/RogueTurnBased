using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour, IReferenceReceiver
{
    private IReferenceReceiver cellReceiver;
    private CursorInformationReader cursorInformationReader;
    public GameObject HighlightedCell;


    #region In Start()
    public void Start()
    {
        Init();
    }
    public void Init()
    {
        cursorInformationReader = new CursorInformationReader(HighlightedCell);
        cellReceiver = this;
    }
    #endregion

    #region In Update()
    public void Update()
    {
        UpdateHighlightCellPosition();
        if (Input.GetMouseButtonDown(0))
        {
            var cell = cursorInformationReader.GetCellObjectHighlightedUnderCursor();
            NotifyReceiver();
        }
    }

    public void UpdateHighlightCellPosition()
    {
        cursorInformationReader.SetCellObjectHighlightedUnderCursor();
    }
    #endregion

    #region Interfaces

    public void NotifyReceiver()
    {
        cellReceiver.GetNotified(cursorInformationReader.GetCellObjectHighlightedUnderCursor());
    }

    public void GetNotified(Cell cell)
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
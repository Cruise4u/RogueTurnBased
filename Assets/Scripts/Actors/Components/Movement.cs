using System.Collections;
using UnityEngine;

public class Movement : BaseComponent
{
    public int x;
    public int y;

    public void SetCoordinates(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(Cell cell, bool isInstantMovement)
    {
        SetWorldPosition(cell, isInstantMovement);
    }

    public void SetWorldPosition(Cell cell, bool isInstantMovement)
    {
        if (!isInstantMovement)
        {

        }
        else
        {
            var x = cell.transform.position.x;
            var y = cell.transform.position.y;
            var newPosition = new Vector3(x, y, 0);
            transform.position = newPosition;
        }
    }

    public override void ExecuteLogic()
    {
        if(cellReference.GetCellData().isOccupied != true)
        {
            SetCoordinates(cellReference.GetCellData().x, cellReference.GetCellData().y);
            Move(cellReference.GetCell(),true);
        }
    }

    public override bool IsPossibleToExecute()
    {
        bool condition;
        if (cellReference.GetCellData().isOccupied == false)
        {
            condition = true;
        }
        else
        {
            condition = false;
        }
        return condition;
    }

    public void Start()
    {
        
    }
} 


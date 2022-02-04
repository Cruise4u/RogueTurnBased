using System.Collections;
using UnityEngine;

public class ActorMovement : MonoBehaviour,IPositionContext
{
    public int _x;
    public int _y;

    public int x { get => _x; set => _x = value; }
    public int y { get => _y; set => _y = value; }

    public void Init()
    {
    
    }
    public void SetGridPosition(Cell cell)
    {
        x = cell.cellData.x;
        y = cell.cellData.y;
    }

    public void SetWorldPosition(Vector3 position,bool isInstantMovement)
    {
        if (!isInstantMovement)
        {

        }
        else
        {
            transform.position = position;
        }
    }


    public void Move(IGridContext gridContext,bool isInstantMovement)
    {
        SetGridPosition(gridContext.CellArray[x, y]);
        SetWorldPosition(gridContext.CellArray[x, y].transform.position, isInstantMovement);
    }

}
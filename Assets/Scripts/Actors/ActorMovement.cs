using System.Collections;
using UnityEngine;

public class ActorMovement : MonoBehaviour, IPositionContext
{
    public int _x;
    public int _y;

    public int x { get => _x; set => _x = value; }
    public int y { get => _y; set => _y = value; }

    public void SetCoordinates(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int x, int y, bool isInstantMovement)
    {
        SetWorldPosition(ReferenceManager.gridContext.CellArray[x, y].transform.position, isInstantMovement);
    }

    public void SetWorldPosition(Vector3 position, bool isInstantMovement)
    {
        if (!isInstantMovement)
        {

        }
        else
        {
            transform.position = position;
        }
    }
} 
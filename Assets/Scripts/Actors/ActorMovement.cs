using System.Collections;
using UnityEngine;

public class ActorMovement : MonoBehaviour,IPositionReference
{
    public int _x;
    public int _y;

    public int x { get => _x; set => _x = value; }
    public int y { get => _y; set => _y = value; }

    public void SetWorldPosition(Vector3 position)
    {
        transform.position = position;
    }

    public void SetGridPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(IReferenceGrid referenceGrid)
    {
        referenceGrid.CellArray[x]
    }
}
using System.Collections;
using UnityEngine;

public class Cell : MonoBehaviour,ICellReference
{
    public CellData cellData;

    public Cell GetCell()
    {
        return this;
    }

    public CellData GetCellData()
    {
        return cellData;
    }
}

public class CellContextComparer
{
    public Context context;

    public void CompareContext()
    {

    }

    public void SetContext(Context context)
    {
        this.context = context;
    }

}

public enum Context
{
    Move,
    Attack,
    Interact,
    Cast,
}
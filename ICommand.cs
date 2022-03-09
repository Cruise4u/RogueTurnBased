using UnityEditor;
using UnityEngine;

public interface IReference
{
    void GetContext(ICellContext context);
}

public interface ICellContext
{
    Cell GetCellContext();
}
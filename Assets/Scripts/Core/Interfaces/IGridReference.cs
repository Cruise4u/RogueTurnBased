using System.Collections;
using UnityEngine;

public interface IGridReference
{
    public Cell[,] CellArray { get; set; }
}
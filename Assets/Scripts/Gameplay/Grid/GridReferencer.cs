using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridReferencer : IGridContext
{
    public Cell[,] cellArray;
    public Cell[,] CellArray { get => cellArray; set => cellArray = value; }
}





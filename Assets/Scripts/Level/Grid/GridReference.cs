using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridReference : IGridReference
{
    public Cell[,] cellArray;
    public Cell[,] CellArray { get => cellArray; set => cellArray = value; }
}





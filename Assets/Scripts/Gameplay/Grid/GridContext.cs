using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridContext : IGridContext
{
    public Cell[,] cellArray;
    public Cell[,] CellArray { get => cellArray; set => cellArray = value; }
}





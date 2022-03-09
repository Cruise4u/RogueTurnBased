using System.Collections;
using UnityEngine;

public interface IGlobalReference
{

}

public interface IGridReference : IGlobalReference
{
    Cell[,] CellArray { get; set; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;


public class LevelGrid : MonoBehaviour
{
    public Tilemap tileMap;
    public List<Vector3> baseCellList;
    public List<Vector3> populatedCellList;
    public List<Tile> tileList;
    public void Init()
    {
        baseCellList = new List<Vector3>();
        populatedCellList = new List<Vector3>();
    }
    public void CreateBaseGridData(Tilemap tileMap)
    {
        var bounds = tileMap.cellBounds;
        foreach (Vector3Int cellPosition in bounds.allPositionsWithin)
        {
            baseCellList.Add(cellPosition);
        }
    }
    public void CreatePopulatedGridData(List<Vector3> cellList)
    {
        for (int i = 0; i < cellList.Count; i++)
        {
            var cellPositionInt = new Vector3Int((int)cellList[i].x, (int)cellList[i].y, (int)cellList[i].z);
            if (tileMap.GetTile<Tile>(cellPositionInt) != null)
            {
                populatedCellList.Add(baseCellList.ToArray()[i]);
            }
        }
    }
    public void Start()
    {
        Init();
        CreateBaseGridData(tileMap);
        CreatePopulatedGridData(baseCellList);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Nothing happens so far..
        }
    }
}

//public Vector3 GetMaximumCoordinatesValue()
//{
//    var x = populatedCellList.Max(position => position.x);
//    var y = populatedCellList.Max(position => position.y);
//    return new Vector3(x, y, 0);
//}
//public Vector3 GetMinimumCoordinatesValue()
//{
//    var x = populatedCellList.Min(position => position.x);
//    var y = populatedCellList.Min(position => position.y);
//    return new Vector3(x, y, 0);
//}
//public int ReturnArraySize(int max, int min)
//{
//    int arraySize = 0;
//    if (max != 0 && max > 0)
//    {
//        if (min != 0 && min < 0)
//        {
//            min *= (-1);
//            arraySize = max + min;
//            arraySize -= 1;
//        }
//        else
//        {
//            arraySize = max - min;
//            arraySize += 1;
//        }
//    }
//    return arraySize;
//}
//public void SetRowColumnsSize()
//{
//    Vector3 maxCoordinates = GetMaximumCoordinatesValue();
//    Vector3 minCoordinates = GetMinimumCoordinatesValue();
//    int rowArraySize = ReturnArraySize((int)maxCoordinates.x, (int)minCoordinates.x);


//}






//public int GetRowMaxCoordinate()
//{
//    return populatedCellList.Max(position => (int)position.x);
//}
//public int GetRowMinCoordinate()
//{
//    return populatedCellList.Min(position => (int)position.x);
//}
//public void ReorderCellPositionListByAscendingOrder(List<Vector3> positionList)
//{
//    positionList.OrderBy(position => position.x).ThenBy(position => position.y);
//}
//public void ReorganizeRowListByAscendingOrder(int[] array)
//{
//    populatedCellList.OrderBy(position => position.x).ThenBy(position => position.y);
//    for(int i = 0; i < array.Length; i++)
//    {
//        Debug.Log("Row size is :" + array.Length);
//        var coordinate = (int)populatedCellList.ToArray()[i].x;
//        array[i] = coordinate;
//        Debug.Log("Coordinate is " + array[i]);
//        var cellPositionInt = new Vector3Int((int)populatedCellList[i].x, (int)populatedCellList[i].y, (int)populatedCellList[i].z);
//        var tile = tileMap.GetTile<Tile>(cellPositionInt);
//        SetTileWithNumbers(tile, cellPositionInt);
//    }
//}
//public void SetTileWithNumbers(Tile tile,Vector3Int cellPosition)
//{
//    switch(cellPosition.x)
//    {
//        case 0:
//            tileMap.SetTile(cellPosition, tileList[0]);
//            break;
//        case 1:
//            tileMap.SetTile(cellPosition, tileList[1]);
//            break;
//        case 2:
//            tileMap.SetTile(cellPosition, tileList[2]);
//            break;
//        case 3:
//            tileMap.SetTile(cellPosition, tileList[3]);
//            break;
//        case 4:
//            tileMap.SetTile(cellPosition, tileList[4]);
//            break;
//    }
//}

//public int GetRowMaximumCoordinate(Vector3[] vectorArray)
//{
//    int[] row = new int[vectorArray.Length];
//    int xTempCoordinate = 1000;
//    int xCoordinate = 0;
//    for (int i = 0; i < row.Length; i++)
//    {
//        xTempCoordinate = (int)vectorArray[i].x;
//        if (xTempCoordinate > xCoordinate)
//        {
//            xCoordinate = xTempCoordinate;
//        }
//    }
//    return xCoordinate;
//}

//public int GetRowMinimumCoordinate(Vector3[] vectorArray)
//{
//    int[] row = new int[vectorArray.Length];
//    int xTempCoordinate = 1000;
//    int xCoordinate = 0;
//    for (int i = 0; i < row.Length; i++)
//    {
//        xTempCoordinate = (int)vectorArray[i].x;
//        if (xTempCoordinate < xCoordinate)
//        {
//            xCoordinate = xTempCoordinate;
//        }
//    }
//    return xCoordinate;
//}

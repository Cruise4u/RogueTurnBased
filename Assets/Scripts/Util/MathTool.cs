using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class MathTool
{
	public static int GetMedianValue(int number)
	{
		int value = 0;
		if (number % 2 == 0)
		{
			value = number / 2;
		}
		else
		{
			value = Mathf.RoundToInt(number / 2);
		}
		return value;
	}

	public static int GetRandomValue(int min,int max)
	{
		int value = Random.Range(min, max);
		return value;
	}

	public static Vector2 GetRotatedVectorPosition(Vector2 vector, int angle)
	{
		float xAngle = vector.x * Mathf.Cos(angle * Mathf.Deg2Rad) - vector.y * Mathf.Sin(angle * Mathf.Deg2Rad);
		float yAngle = vector.x * Mathf.Sin(angle * Mathf.Deg2Rad) + vector.y * Mathf.Cos(angle * Mathf.Deg2Rad);
		return new Vector2(xAngle, yAngle);
	}

	public static int GetHorizontalMaxValue(List<CellData> cellDataList)
	{
		var value = cellDataList.Max(coordinate => coordinate.x);
		return value;
	}
	public static int GetHorizontalMinValue(List<CellData> cellDataList)
	{
		var value = cellDataList.Min(coordinate => coordinate.x);
		return value;
	}

	public static int GetVerticalMaxValue(List<CellData> cellDataList)
    {
		var value = cellDataList.Max(coordinate => coordinate.y);
		return value;
    }

	public static int GetVerticalMinValue(List<CellData> cellDataList)
	{
		var value = cellDataList.Min(coordinate => coordinate.y);
		return value;
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

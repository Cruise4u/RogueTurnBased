using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System.Linq;

public class GridGenerator : MonoBehaviour
{
	public GridData gridData;
	private int width;
	private int heigth;

	public void Init()
	{
		width = MathTool.GetRandomValue(gridData.width, gridData.widthMargin);
		heigth = MathTool.GetRandomValue(gridData.height, gridData.heightMargin);
		Debug.Log(ReferenceManager.gridReference);
		ReferenceManager.gridReference.CellArray = new Cell[width, heigth];
	}

	public void CreateGrid(IGridContext gridReference)
	{
		GameObject cellParentObject = new GameObject();
		for (int y = 0; y < heigth; y++)
		{
			for (int x = 0; x < width; x++)
			{
				CreateCell(gridReference, x, y, cellParentObject);
			}
		}
	}

	public void CreateCell(IGridContext gridReference, int x, int y, GameObject parent)
	{
		var cellData = new CellData(x, y);
		var cellInstance = Instantiate(gridData.cellPrefab);
		cellInstance.AddComponent<Cell>();
		cellInstance.GetComponent<Cell>().cellData = cellData;
		cellInstance.transform.position = new Vector2(x * 0.65f, y * 0.65f);
		cellInstance.transform.SetParent(parent.transform); 
		gridReference.CellArray[x, y] = cellInstance.GetComponent<Cell>();
		if (!IsCellPositionSetOnBorder(x, y))
		{
			cellInstance.layer = LayerMask.NameToLayer("Usable");
			TileSpritePainterTool.DrawSpriteOnCell(gridReference.CellArray[x, y], gridData.cellSpriteList[0]);
		}
		else
		{
			cellInstance.layer = LayerMask.NameToLayer("Default");
			TileSpritePainterTool.DrawSpriteOnCell(gridReference.CellArray[x, y], gridData.cellSpriteList[1]);
		}
	}

	public bool IsCellPositionSetOnBorder(int x,int y)
    {
		bool condition = false;
        if (x == 0 || y == 0 || x == width - 1 || y == heigth - 1)
		{
			condition = true;
        }
        else
        {
			condition = false;
        }
		return condition;
    }


	public void Start()
	{
		Init(); 
		CreateGrid(ReferenceManager.gridReference);
		//ActorSpawner.SpawnActorAtCell(ReferenceManager.gridReference.CellArray[MathTool.GetMedianValue(width), MathTool.GetMedianValue(width)]);
	}
}


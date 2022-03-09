using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDistanceCalculator : MonoBehaviour
{
    Cell originCell;
    List<Cell> diagonalList = new List<Cell>();
    List<Cell> lateralList = new List<Cell>();


    public static void GetCalculatedDistance(Cell cell)
    {
        for (int i = 0; i < 4; i++)
        {
            var angle = 45 * i;
            var direction = MathTool.GetRotatedVectorPosition(cell.transform.up, angle);
            var ray = Physics2D.Raycast(cell.transform.position, direction, 1);
            Debug.DrawRay(cell.transform.position, direction, Color.red, 100);
            Debug.Log("Ray casted!");
        }
    }

    //Raycast in all 8 directions (Up,Down,Left,Right,Diagonal's)
    //Send those cells to a list
    public static void CastRayFromOriginCell(List<CellData> list, Cell cell)
    {
        var iterations = 360 / 45;
        for (int i = 0; i < iterations; i++)
        {
            var angle = 45 * i;
            var direction = MathTool.GetRotatedVectorPosition(cell.transform.up, angle);
            var ray = Physics2D.Raycast(cell.transform.position, direction, 1);
            if (ray.collider.gameObject.layer == LayerMask.NameToLayer(""))
            {
                var x = ray.collider.gameObject.GetComponent<Cell>().cellData.x;
                var y = ray.collider.gameObject.GetComponent<Cell>().cellData.y;
                list.Add(new CellData(x, y));
            }
        }
    }

    public void IterateThroughFirstExpansionList(List<Cell> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (IsCellOnDiagonal(originCell, list[i]))
            {
                diagonalList.Add(list[i]);
            }
            else
            {
                lateralList.Add(list[i]);
            }
        }
    }

    public static void CalculateAreaExpansionForActions(List<CellData> list, int range)
    {

        List<CellData> diagonalList = new List<CellData>();
        List<CellData> lateralList = new List<CellData>();

        for (int i = 0; i < range; i++)
        {

        }

        for (int i = 0; i < list.Count; i++)
        {
            if ((list[i].x == 1 || list[i].x == -1) || (list[i].y == 1 || list[i].y == -1))
            {
                diagonalList.Add(list[i]);
            }
            else
            {
                lateralList.Add(list[i]);
            }
        }
    }

    public void IterateThroughCellsList()
    {

    }

    public int GetHorizontalOffsetDistance(Cell origin, Cell target)
    {
        var subtraction = target.cellData.x - origin.cellData.x;
        return subtraction;
    }
    public int GetVerticalOffsetDistance(Cell origin, Cell target)
    {
        var subtraction = target.cellData.y - origin.cellData.y;
        return subtraction;
    }

    public bool IsCellOnDiagonal(Cell origin,Cell target)
    {
        bool condition = false;
        if((GetHorizontalOffsetDistance(origin,target) == -1 || GetHorizontalOffsetDistance(origin,target) == 1) && (GetVerticalOffsetDistance(origin, target) == -1 || GetVerticalOffsetDistance(origin, target) == 1))
        {
            condition = true;
        }
        else
        {
            condition = false;
        }
        return condition;
    }



    // For Debuging Purposes:
    public void DrawBoxCastInTwoDimensions(Camera camera,Vector2 origin,int size)
    {
        var correctPosition = RaycastTool.SetOriginRaycastOnCenter(origin);
        var iterationSize = size * 3;
        for (int i = 0; i < iterationSize; i++)
        {
            for (int j = 0; j < iterationSize; j++)
            {
                var adjustedPosition = new Vector2(correctPosition.x - j * 0.64f, correctPosition.y - i * 0.64f);
                var rayOrigin = new Vector3(adjustedPosition.x, adjustedPosition.y, camera.nearClipPlane);
                var rayDirection = new Vector3(adjustedPosition.x, adjustedPosition.y, camera.farClipPlane);
                var rayHit = Physics2D.Raycast(rayOrigin, rayOrigin - rayDirection, 5.0f);
                if(rayHit.collider.gameObject.layer == LayerMask.NameToLayer("Usable"))
                {
                    if(rayHit.collider.gameObject.GetComponent<Cell>().cellData.isOccupied != true)
                    {
                        Debug.Log("Is hit?");
                        rayHit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
                    }
                }
            }
        }
    }

    public void SetCellToOcupied(Camera camera, Vector2 origin, int size)
    {
        var correctPosition = RaycastTool.SetOriginRaycastOnCenter(origin);
        var adjustedPosition = new Vector2(correctPosition.x - 0.64f, correctPosition.y - 0.64f);
        var rayOrigin = new Vector3(adjustedPosition.x, adjustedPosition.y, camera.nearClipPlane);
        var rayDirection = new Vector3(adjustedPosition.x, adjustedPosition.y, camera.farClipPlane);
        var rayHit = Physics2D.Raycast(rayOrigin, rayOrigin - rayDirection, 5.0f);
        if (rayHit.collider.gameObject.layer == LayerMask.NameToLayer("Usable"))
        {
            if (rayHit.collider.gameObject.GetComponent<Cell>().cellData.isOccupied != true)
            {
                rayHit.collider.gameObject.GetComponent<Cell>().cellData.isOccupied = true;
            }
        }
    }
}
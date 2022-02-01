using System.Collections;
using UnityEngine;

public class CellDisplayTool : MonoBehaviour
{
    public Camera baseCamera;
    public GameObject cellDisplayObject;
    public LayerMask UsableMask;
    public string Celltag;


    public void Init()
    {
        cellDisplayObject.SetActive(true);
    }
    public void DisplayCellHighlighted()
    {
        if (RaycastTool.IsHitted(baseCamera, UsableMask, Celltag))
        {
            var cellHighlightedObject = RaycastTool.GetCellObject();
            cellDisplayObject.transform.position = cellHighlightedObject.transform.position;
        }
    }
    public void Start()
    {
        Init();
    }
    public void Update()
    {
        DisplayCellHighlighted();
    }
}



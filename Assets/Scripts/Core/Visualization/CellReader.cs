using System.Collections;
using UnityEngine;

namespace Assets.Scripts.General
{
    public class CellReader : MonoBehaviour
    {
        public GameObject HighlightedCell;
        public CellDisplayTool cellDisplayTool;

        public void Init()
        {
            cellDisplayTool = new CellDisplayTool(HighlightedCell);
        }

        public void ReadCell()
        {
            cellDisplayTool.HighlightCellUnderCursor();
        }

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ReadCell();
            }
        }



    }
}
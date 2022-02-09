using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public static class RaycastTool
{
    public static RaycastHit2D raycastHit;
    private static GameObject hittedGO;

    public static GameObject GetCellObject()
    {
        if(raycastHit.collider.gameObject != null)
        {
            hittedGO = raycastHit.collider.gameObject;
        }
        return hittedGO;
    }

    public static bool IsHitted(Camera camera,LayerMask mask)
    {
        bool isHitted;
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        raycastHit = Physics2D.Raycast(ray.origin, ray.direction, 10);
        if(raycastHit.collider != null && raycastHit.collider.gameObject.layer == LayerMask.NameToLayer("Usable"))
        {
            isHitted = true;
        }
        else
        {
            isHitted = false;
        }
        return isHitted;
    }


}


using System;
using System.Collections.Generic;
using UnityEngine;

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

    //Mouse Position on Screen
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

    //From One position to Another on Orthogonal plane (2D)
    public static bool IsHitted(Vector2 origin,Vector2 direction,float radius)
    {
        bool isHitted;
        raycastHit = Physics2D.Raycast(origin, direction, radius);
        if (raycastHit.collider != null && raycastHit.collider.gameObject.CompareTag(""))
        {
            isHitted = true;
        }
        else
        {
            isHitted = false;
        }
        return isHitted;
    }

    public static Vector3 SetOriginRaycastOnCenter(Vector3 mousePosition)
    {
        Vector3 adjustedPosition = new Vector3(mousePosition.x + 0.64f, mousePosition.y + 0.64f, mousePosition.z);

        return adjustedPosition;
    }
}


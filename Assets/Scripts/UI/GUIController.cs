using System.Collections;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public static Camera baseCamera;
    public static LayerMask usableMask;

    public void Start()
    {
        baseCamera = FindObjectOfType<Camera>();
        usableMask = LayerMask.NameToLayer("Usable");
    }


}
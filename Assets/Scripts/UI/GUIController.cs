using System.Collections;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public static Camera baseCamera;
    public static string cellTag;

    public void Start()
    {
        baseCamera = FindObjectOfType<Camera>();
        cellTag = "Usable";
    }


}
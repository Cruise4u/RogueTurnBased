using System.Collections;
using UnityEngine;

namespace Assets.Scripts.General
{
    public class GUIManager : MonoBehaviour
    {
        public static Camera baseCamera;

        public void Start()
        {
            baseCamera = FindObjectOfType<Camera>();
        }
    }
}
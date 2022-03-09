using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class GridData : ScriptableObject
{
    public int width;
    public int widthMargin;
    public int height;
    public int heightMargin;
    public GameObject cellPrefab;
    public List<Sprite> cellSpriteList;
}


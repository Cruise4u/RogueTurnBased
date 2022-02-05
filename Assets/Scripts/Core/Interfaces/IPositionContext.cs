using System.Collections;
using UnityEngine;

public interface IPositionContext : ICommandContext
{
    int x { get;set; }
    int y { get; set; }
    void Move(int x,int y, bool isInstantMovement);
}
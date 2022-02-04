using System.Collections;
using UnityEngine;

public interface IPositionContext : ICommandContext
{
    int x { get; }
    int y { get; }
    void Move(IGridContext gridReference, bool isInstantMovement);
}
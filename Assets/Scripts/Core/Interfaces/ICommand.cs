using UnityEditor;
using UnityEngine;

public interface ICommand
{
    void Execute(ICommandReference reference);
}

public interface ICommandReference
{

}

public interface IPositionReference : ICommandReference
{
    int x { get; set; }
    int y { get; set; }
    void Move(IReferenceGrid referenceGrid);
}
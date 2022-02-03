using System.Collections;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public MoveCommand move;

    public void Start()
    {
        move = new MoveCommand();




    }

    public void ExecuteCommandOfType(ICommand command)
    {
        switch (command)
        {
            case MoveCommand:
                move.Execute(GetComponent<ActorMovement>());
                break;
        }
    }

}

public class MoveCommand : ICommand
{
    private Transform transform;
    private IReferenceGrid referenceGrid;

    public MoveCommand()
    {

    }

    public void Execute(ICommandReference reference)
    {
        var positionReference = reference as IPositionReference;
        transform.position = referenceGrid.CellArray[positionReference.x, positionReference.y].transform.position;

    }
}


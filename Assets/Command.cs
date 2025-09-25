using UnityEngine;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class SwitchToNightCommand : ICommand
{
    private GameObject[] dayObjects;
    private GameObject[] nightObjects;

    public SwitchToNightCommand(GameObject[] dayObjects, GameObject[] nightObjects)
    {
        this.dayObjects = dayObjects;
        this.nightObjects = nightObjects;
    }

    public void Execute()
    {
        foreach (var obj in dayObjects)
        {
            obj.SetActive(false);
        }
        foreach (var obj in nightObjects)
        {
            obj.SetActive(true);
        }
    }

    public void Undo()
    {
        foreach (var obj in nightObjects)
        {
            obj.SetActive(false);
        }
        foreach (var obj in dayObjects)
        {
            obj.SetActive(true);
        }
    }
}


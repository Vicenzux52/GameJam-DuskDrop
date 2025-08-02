using System.ComponentModel;
using UnityEngine;

public class Buff : GenericTower
{
    [field: SerializeField, Description()] public int buffType { get; protected set; }
    [field: SerializeField, Description("Does the buff provided by this tower reset after every eclipse")] bool doesReset = false;
    int timesUsed = 0;
    new void Start()
    {
        base.Start();
    }
    public override void Run()
    {
        if (BuffController.Self == null)
        {
            Debug.LogError("BuffController is not initialized.");
            return;
        }
        BuffController.Self.AddBuff(buffType);
        timesUsed++;
    }
    public override void Restart()
    {
        if (doesReset)
        {
            for (int i = 0; i < timesUsed; i++)
            {
                BuffController.Self.RemoveBuff(buffType);
            }
            timesUsed = 0;
        }
    }
}

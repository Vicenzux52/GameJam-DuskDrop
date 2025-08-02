using UnityEngine;

public class Animal : GenericTower
{
    int amountSpawned;
    public override void Initialize()
    {
        base.Initialize();
    }
    public override void Run()
    {
        Spawn();
    }
    public override void Spawn()
    {
        Debug.Log("nnnnnnnn");
    }
}

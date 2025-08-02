using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Tree : GenericTower
{
    GameObject tree;
    new void Start()
    {
        base.Start();
    }
    public override void Run()
    {
        Spawn();
    }
    public override void Spawn()
    {
        Debug.Log("nnnnnnnn");
        if(tree == null) tree = Instantiate(UnitPrefab,spawnpoint.transform.position,Quaternion.identity);
    }
    public override void Restart()
    {
        if (tree != null) Destroy(tree, 2);
    }
}

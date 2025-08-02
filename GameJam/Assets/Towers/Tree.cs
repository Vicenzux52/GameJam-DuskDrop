using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Tree : GenericTower
{
    List<GameObject> treeList = new List<GameObject>();
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
        //treeList.Add(Instantiate(UnitPrefab, , ));
    }
    public override void Restart()
    {
        Debug.Log("Tree Restart");
        // Logic to restart the tree tower
        foreach (var tree in treeList)
        {
            Destroy(tree);
        }
        treeList.Clear();
    }
}

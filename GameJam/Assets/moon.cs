using System.Collections.Generic;
using UnityEngine;

public class moon : MonoBehaviour
{
    List<GenericTower> torres = new List<GenericTower>();
    float next;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Torre"))
        {
            torres.Add(collision.gameObject.GetComponent<GenericTower>());
            Debug.Log("add"+collision.gameObject.GetComponent<GenericTower>().TowerName);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Torre"))
        {
            GenericTower temp = collision.gameObject.GetComponent<GenericTower>();
            temp.Restart();
            if (torres.Contains(temp))
                torres.Remove(temp);
        }
    }
    void Start()
    {
        Nexus.Self.AddSelf(this);
    }
    public void CombatStart()
    {
        next = Time.time + 3;
    }
    void Update()
    {
        if (Time.time >= next)
        {
            next = Time.time + 3;
            foreach (var item in torres)
            {
                item.Run();
            }
        }
    }
}

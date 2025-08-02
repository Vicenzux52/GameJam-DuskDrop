using NUnit.Framework.Internal.Commands;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector]public int damage;
    float speed = 2f;
    [SerializeField]GameObject target;
    public void Set(int damage, GameObject target)
    {
        this.damage = damage;
        this.target = target;
    }
    void Update()
    {
        if (target == null) Destroy(this.gameObject);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}

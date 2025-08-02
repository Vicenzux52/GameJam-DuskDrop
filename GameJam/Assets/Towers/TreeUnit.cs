using Unity.Mathematics;
using UnityEngine;

public class TreeUnit : GenericUnit
{
    [SerializeField] GameObject target = null;
    [SerializeField] GameObject bulletPrefab;
    void OnCollisionEnter(Collision collision)
    {
        if (target == null && collision.gameObject.CompareTag("Enemy"))
        {
            target = collision.gameObject;
            if (cd != null)StopCoroutine(cd);
            Attack();
        }
    }
    protected override void Attack()
    {
        if (target != null) SpawnAttack();
        cd = Cooldown();
        StartCoroutine(cd);
    }
    void SpawnAttack()
    {
        if (damage == 0) return;
        GameObject temp = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        if (temp.TryGetComponent<Bullet>(out Bullet bullet))
        {
            float atk = damage;
            if (BuffController.Self != null) atk = damage * BuffController.Self.buffs[0];
            bullet.Set((int)damage,target);
        }
        else
        {
            Debug.LogError("Bullet component not found on the prefab.");
        }
    }
}

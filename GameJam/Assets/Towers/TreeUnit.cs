using Unity.VisualScripting;
using UnityEngine;

public class TreeUnit : GenericUnit
{
    [SerializeField] GameObject bulletPrefab;
    protected override void Attack()
    {
        ChooseTarget();
        if (target != null) SpawnAttack();
        cd = Cooldown();
        StartCoroutine(cd);
    }
    void SpawnAttack()
    {
        if (damage == 0) return;
        GameObject temp = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(140, 140, 140);
        if (temp.TryGetComponent<Bullet>(out Bullet bullet))
        {
            float atk = damage;
            if (BuffController.Self != null) atk = damage * BuffController.Self.buffs[0];
            bullet.Set((int)damage, target);
        }
        else
        {
            Debug.LogError("Bullet component not found on the prefab.");
        }
    }
    new void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        if(collision.gameObject.CompareTag("Enemy"))if (cd == null) Attack();
    }
}

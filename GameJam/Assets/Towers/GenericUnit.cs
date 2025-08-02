using System.Collections;
using UnityEngine;

public class GenericUnit : MonoBehaviour
{
    [field: SerializeField] protected string unitName = "GenericUnit";
    [field: SerializeField] protected float damage;
    [field: SerializeField] protected float attackSpeed;
    [field: SerializeField] protected float range;
    protected IEnumerator cd;
    protected virtual void Initiate()
    {
        if (damage <= 0)
        {
            damage = 1;
        }
        if (attackSpeed <= 0)
        {
            attackSpeed = 1;
        }
        if (range <= 0)
        {
            range = 1;
        }
    }
    protected virtual void Attack()
    {
        Debug.Log(unitName + " Attack");
    }
    protected virtual IEnumerator Cooldown()
    {
        float speed = attackSpeed;
        if (BuffController.Self != null) speed *= BuffController.Self.buffs[1];
        yield return new WaitForSeconds(1 / speed);
        Attack();
    }

#if UNITY_EDITOR
    public bool debugInitiliaze = false;
    public bool debugAttack = false;
    void Update()
    {
        if (debugInitiliaze)
        {
            Initiate();
            debugInitiliaze = false;
        }
        if (debugAttack)
        {
            if (cd != null) StopCoroutine(cd);
            Attack();
            debugAttack = false;
        }
    }
#endif
}

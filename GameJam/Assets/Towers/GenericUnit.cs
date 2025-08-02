using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenericUnit : MonoBehaviour
{
    [field: SerializeField] protected string unitName = "GenericUnit";
    [field: SerializeField] protected float damage;
    [field: SerializeField] protected float attackSpeed;
    [field: SerializeField] protected float range;
    [SerializeField]protected GameObject target;
    protected List<GameObject> EnemyList = new List<GameObject>();
    protected IEnumerator cd=null;
    protected virtual void Start()
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
    protected void ChooseTarget()
    {
        if (target != null) return;
        if (EnemyList.Count == 0) return;
        do
        {
            if (EnemyList.ElementAt(0) == null) EnemyList.RemoveAt(0);
            else target=EnemyList.ElementAt(0);
        } while (EnemyList.Count>0 && target == null);
    }
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyList.Add(collision.gameObject);
            
        }
    }
    protected void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (EnemyList.Contains(collision.gameObject))
            {
                EnemyList.Remove(collision.gameObject);
            }
        }
    }
    /* void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (!EnemyList.Contains(collision.gameObject))
            {
                EnemyList.Add(collision.gameObject);
                
            }
        }
    } */
#if UNITY_EDITOR
    public bool debugAttack = false;
    protected void Update()
    {
        if (debugAttack)
        {
            if (cd != null) StopCoroutine(cd);
            Attack();
            debugAttack = false;
        }
    }
#endif
}

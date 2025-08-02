using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnimalUnit : GenericUnit
{
    [field: SerializeField] int life = 1;
    [field: SerializeField] protected float speed = 1f;
    bool enGarde = false;
    Enemy enemy;
    new void Start()
    {
        base.Start();
        if (speed <= 0)
        {
            speed = 1;
        }
        if (life <= 0)
        {
            life = 1;
        }
    }

    protected override void Attack()
    {
        ChooseTarget();
        if (target != null)
        {
            Debug.Log("attack anim");
            float atk = damage;
            if (BuffController.Self != null) atk = damage * BuffController.Self.buffs[0];
            enemy.Harm((int)atk);
        }
        cd = Cooldown();
        StartCoroutine(cd);
    }

    new void Update()
    {
        base.Update();
        if (target != null)
        {
            if ((transform.position - target.transform.position).magnitude < 2)
            {
                if (!enGarde)
                {
                    enGarde = true;
                    if (enemy != null)
                    {
                        enemy.enGarde = true;
                        enemy.combatTarget = this;
                    }
                    Attack();
                    enemy.Attack();
                }
                return;
            }
            else { enGarde = false; }
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        }
        else
        {
            ChooseTarget();
        }
    }
    public void Harm(int damage)
    {
        life -= damage;
        if (life < 1)
        {
            if (enemy != null)
            {
                enemy.enGarde = false;
                enemy.combatTarget = null;
            }
            Destroy(gameObject);
        }
    }
    new void ChooseTarget()
    {
        base.ChooseTarget();
        if (target != null) enemy = target.GetComponent<Enemy>();
    }
}

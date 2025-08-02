using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public string enemyDescription;
    [SerializeField] int life = 1;
    [SerializeField] float damage;
    [SerializeField] float attackSpeed;
    [SerializeField] float speed;
    [SerializeField] GameObject target;
    public bool enGarde = false;
    public AnimalUnit combatTarget;
    protected IEnumerator cd;
    void Start()
    {
        if (life <= 0)
        {
            life = 1;
        }
        if (damage <= 0)
        {
            damage = 1;
        }
        if (attackSpeed <= 0)
        {
            attackSpeed = 1;
        }
        if (speed <= 0)
        {
            speed = 1;
        }
        if (Nexus.Self != null) target = Nexus.Self.gameObject;
    }
    void Update()
    {
        if (enGarde && combatTarget != null)
        {
            return;
        }
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Harm(collision.gameObject.transform.parent.GetComponent<Bullet>().damage);
            Destroy(collision.gameObject);
        }
    }
    public void Harm(int damage)
    {
        life -= damage;
        if (life < 1) Destroy(this.gameObject);
    }
    public void Attack()
    {
        
        if (combatTarget != null) combatTarget.Harm((int)damage);
        cd = Cooldown();
        StartCoroutine(cd);
    }
    protected virtual IEnumerator Cooldown()
    {
        float speed = attackSpeed;
        yield return new WaitForSeconds(1 / speed);
        Attack();
    }
}

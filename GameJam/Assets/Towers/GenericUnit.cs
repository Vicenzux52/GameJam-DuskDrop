using UnityEngine;

public class GenericUnit : MonoBehaviour
{
    float damage;
    float attackSpeed;
    float range;
    public virtual void Initiate()
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
    
}

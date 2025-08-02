using UnityEngine;

public class Nexus : MonoBehaviour
{
    public static Nexus Self { get; private set; }
    [SerializeField] int life = 10;
    void Awake()
    {
        if (Self == null)
        {
            Self = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void Harm(int damage)
    {
        life -= damage;
        if (life < 1)
        {
            //GAMEOVER
        }
    }
}

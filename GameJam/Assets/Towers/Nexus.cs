using UnityEngine;

public class Nexus : MonoBehaviour
{
    public static Nexus Self { get; private set; }
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
}

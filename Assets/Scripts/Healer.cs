using UnityEngine;

public class Healer : MonoBehaviour, ICharacter
{
    public void Move()
    {
        Debug.Log("Healer moves gracefully across the battlefield.");
    }

    public void Attack()
    {
        Debug.Log("Healer casts a weak magic bolt.");
    }

    public void TakeDamage(int amount)
    {
        Debug.Log($"Healer takes {amount} damage and tries to heal quickly.");
    }

    void Start()
    {
        Move();
        Attack();
        TakeDamage(15);
    }
}

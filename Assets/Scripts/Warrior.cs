using UnityEngine;

public class Warrior : MonoBehaviour, ICharacter
{
    public void Move()
    {
        Debug.Log("Warrior charges forward!");
    }

    public void Attack()
    {
        Debug.Log("Warrior swings a heavy sword!");
    }

    public void TakeDamage(int amount)
    {
        Debug.Log($"Warrior takes {amount} damage, but stands strong.");
    }

    void Start()
    {
        Move();
        Attack();
        TakeDamage(20);
    }
}

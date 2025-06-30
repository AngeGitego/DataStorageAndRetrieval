using UnityEngine;

public class Thief : MonoBehaviour, ICharacter
{
    public void Move()
    {
        Debug.Log("Thief sneaks through the shadows.");
    }

    public void Attack()
    {
        Debug.Log("Thief throws a dagger from the dark!");
    }

    public void TakeDamage(int amount)
    {
        Debug.Log($"Thief takes {amount} damage and vanishes in smoke.");
    }

    void Start()
    {
        Move();
        Attack();
        TakeDamage(10);
    }
}

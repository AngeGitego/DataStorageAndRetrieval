using UnityEngine;
using UnityEngine.Events;

public class HealthManager : MonoBehaviour
{
    public float health = 10f;
    public UnityEvent OnDeath;

    void Update()
    {
        TakeDamage();
    }

    void TakeDamage()
    {
        health -= Time.deltaTime;

        if (health <= 0f)
        {
            OnDeath?.Invoke();
            enabled = false; // Prevent further damage
        }
    }
}

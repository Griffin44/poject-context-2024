using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 0;

    public UnityEvent OnHealthUpdated = new UnityEvent();
    public UnityEvent OnDeath = new UnityEvent();

    public void TakeDamage(int value) {
        health -= value;
        OnHealthUpdated.Invoke();
        if (health <= 0)
        {
            OnDeath.Invoke();
        }
    }
}

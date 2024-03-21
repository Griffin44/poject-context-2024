using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private Animator dogAnimator;

    public void Die() {
        dogAnimator.SetBool("IsDead", true);
    }
}

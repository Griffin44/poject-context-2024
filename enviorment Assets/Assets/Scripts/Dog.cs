using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private Animator dogAnimator;

    public void Die() {
        print("dog should be dead");
        dogAnimator.SetBool("IsDead", true);
    }
}

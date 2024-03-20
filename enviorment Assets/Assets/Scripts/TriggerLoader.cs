using UnityEngine;
using UnityEngine.Events;

public class TriggerLoader : MonoBehaviour
{
    public UnityEvent OnObjectTrigger = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            OnObjectTrigger.Invoke();
        }
    }
}

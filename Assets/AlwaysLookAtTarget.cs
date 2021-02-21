using UnityEngine;

public class AlwaysLookAtTarget : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        transform.LookAt(Target);
    }
}

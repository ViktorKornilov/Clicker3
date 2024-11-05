using UnityEngine;
using UnityEngine.Events;

public class Cookie : MonoBehaviour
{
    public UnityEvent onClick;

    void OnMouseDown()
    {
        onClick.Invoke();
    }
}
using UnityEngine;
using UnityEngine.Events;

public class Cookie : MonoBehaviour
{
    public UnityEvent onClick;

    void Update()
    {
        if (transform.localScale.x > 1f)
        {
            transform.localScale -= Vector3.one * 2 * Time.deltaTime;
        }
    }

    void OnMouseDown()
    {
        transform.localScale = Vector3.one * 1.5f;
        onClick.Invoke();
    }
}
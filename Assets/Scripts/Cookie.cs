using UnityEngine;
using UnityEngine.Events;

public class Cookie : MonoBehaviour
{
	public UnityEvent onClick;

	void Update()
	{
		if (transform.localScale.x > 1f)
		{
			transform.localScale -= Vector3.one * 0.01f;
		}

	}

	void OnMouseDown()
	{
		transform.localScale = Vector3.one * 1.5f;
		onClick.Invoke();
	}
}
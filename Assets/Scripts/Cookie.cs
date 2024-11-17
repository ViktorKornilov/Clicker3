using UnityEngine;
using UnityEngine.Events;

public class Cookie : MonoBehaviour
{
	public GameManager manager;
	public UnityEvent onClick;
	public Sprite[] nextCookie;
	public int[] clickGoal;
	public SpriteRenderer renderer;
	int skinIndex;

	void Update()
	{
		if (transform.localScale.x > 1f)
		{
			transform.localScale -= Vector3.one * 0.01f;
		}


		if (skinIndex < clickGoal.Length && manager.clicks > clickGoal[skinIndex])
		{
			renderer.sprite = nextCookie[skinIndex++];
			gameObject.SetActive(false);
			gameObject.SetActive(true);
		}


	}

	void OnMouseDown()
	{
		transform.localScale = Vector3.one * 1.5f;
		onClick.Invoke();
	}
}
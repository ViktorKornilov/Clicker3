using TMPro;
using UnityEngine;

public class Worker : MonoBehaviour
{
	public string name;
	public int count;
	public int price;
	public int cps;

	public TMP_Text countText;
	public TMP_Text priceText;

	void Update()
	{
		countText.text = count.ToString();
		priceText.text = "price:" + price;
	}

	void Start()
	{
		Load();
	}

	public void Buy()
	{
		if (GameManager.clicks < price) return;

		GameManager.clicks -= price;
		count++;
		Save();
	}

	void Save()
	{
		PlayerPrefs.SetInt(name, count);
	}

	void Load()
	{
		count = PlayerPrefs.GetInt(name);
	}
}
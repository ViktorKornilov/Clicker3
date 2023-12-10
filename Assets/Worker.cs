using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Worker : MonoBehaviour
{
	public string name;
	public int count;
	public int price;
	public int cps;

	public TMP_Text countText;
	public TMP_Text priceText;
	public Button button;

	void Update()
	{
		countText.text = count.ToString();
		priceText.text = "price:" + price;

		var canClick = GameManager.clicks >= price;
		button.interactable = canClick;
	}

	void Start()
	{
		InvokeRepeating("Work",1f,1f);
		Load();
	}

	public void Buy()
	{
		if (GameManager.clicks < price) return;

		GameManager.clicks -= price;
		price = (int)(price * 1.4f);
		count++;
		Save();
	}

	void Work()
	{
		GameManager.clicks += count * cps;
	}

	void Save()
	{
		PlayerPrefs.SetInt(name, count);
		PlayerPrefs.SetInt(name + "price",price);
	}

	void Load()
	{
		count = PlayerPrefs.GetInt(name);
		price = PlayerPrefs.GetInt(name + "price",price);
	}
}
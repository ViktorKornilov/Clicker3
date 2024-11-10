using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int clicks;

    public TMP_Text grandmaCountText;
    public TMP_Text clicksText;
    int grandmaCount;
    int grandmaPrice;

    public float clickTimer;

    void Start()
    {
        Load();
    }

    void Update()
    {
        clickTimer += Time.deltaTime;
        if (clickTimer >= 1)
        {
            AddClick();
            clickTimer = 0;
        }

        clicksText.text = clicks.ToString();
    }

    void OnApplicationQuit()
    {
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt("clicks", clicks);
        PlayerPrefs.SetInt( "grandmaCount", grandmaCount);
        PlayerPrefs.SetInt( "grandmaPrice", grandmaPrice);
    }

    void Load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
        grandmaCount = PlayerPrefs.GetInt("grandmaCount");
        grandmaPrice = PlayerPrefs.GetInt("grandmaPrice");
    }


    public void AddClick()
    {
        clicks++;
    }

    public void BuyGrandma()
    {
        grandmaCount++;
        grandmaCountText.text = grandmaCount.ToString();
    }
}
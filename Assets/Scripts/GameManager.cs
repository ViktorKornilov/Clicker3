using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int clicks;

    public TMP_Text grandmaCountText;
    public TMP_Text clicksText;
    public TMP_Text cpsText;
    int grandmaCount;
    public int grandmaPrice = 10;
    public int cps;
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
            clicks += cps;
            clickTimer = 0;
        }

        // Update UI
        clicksText.text = clicks.ToString("N0");
        cpsText.text = $"CPS: {cps}";
    }

    void OnApplicationQuit()
    {
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt("clicks", clicks);
        PlayerPrefs.SetInt("cps", cps);
        PlayerPrefs.SetInt( "grandmaCount", grandmaCount);
        PlayerPrefs.SetInt( "grandmaPrice", grandmaPrice);
    }

    void Load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
        cps = PlayerPrefs.GetInt("cps");
        grandmaCount = PlayerPrefs.GetInt("grandmaCount");
        grandmaPrice = PlayerPrefs.GetInt("grandmaPrice",grandmaPrice);
    }


    public void AddClick()
    {
        clicks++;
    }

    public void BuyGrandma()
    {
        grandmaCount++;
        cps += 1;
        grandmaCountText.text = grandmaCount.ToString();
    }
}
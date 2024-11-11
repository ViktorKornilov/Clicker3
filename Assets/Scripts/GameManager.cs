using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public int clicks;
    public int grandmas;
    public int grandmaPrice;
    public float clickTimer;
    public Button upgradeButton;
    public int clickPower = 1;

    void Start()
    {
        Load();
    }

    void Update()
    {
        // UPDATE UI
        clicksText.text = clicks.ToString();

        // TIMER
        clickTimer += Time.deltaTime;

        if (clickTimer > 1f)
        {
            clicks += grandmas;
            clickTimer = 0;
        }
    }

    void OnApplicationQuit()
    {
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt("clicks",clicks);
    }

    void Load()
    {
        clicks = PlayerPrefs.GetInt("clicks");
    }

    public void AddClick()
    {
        clicks += clickPower;
    }

    public void BuyGrandma()
    {
        if (clicks < grandmaPrice) return;

        clicks -= grandmaPrice;
        grandmas++;
        grandmaPrice *= 2;

        Save();
    }

    public void BuyUpgrade()
    {
        if (clicks < 50) return;
        clicks -= 50;
        clickPower *= 2;

        upgradeButton.interactable = false;
    }
}
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public int clicks;
    public int grandmas;
    public int grandmaPrice;
    public float clickTimer;

    void Start()
    {
        clicks = PlayerPrefs.GetInt("clicks");
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
        PlayerPrefs.SetInt("clicks",clicks);
    }

    public void AddClick()
    {
        clicks++;
    }

    public void BuyGrandma()
    {
        if (clicks < grandmaPrice) return;

        clicks -= grandmaPrice;
        grandmas++;
        grandmaPrice *= 2;
    }
}
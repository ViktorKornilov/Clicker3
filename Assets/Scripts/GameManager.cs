using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public int clicks;
    public int grandmas;
    public int grandmaPrice;
    public float clickTimer;

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
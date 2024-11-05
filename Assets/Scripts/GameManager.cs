using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int clicks;

    public TMP_Text grandmaCountText;
    public TMP_Text clicksText;
    int grandmaCount;



    public void AddClick()
    {
        clicks++;
        clicksText.text = clicks.ToString();
    }

    public void BuyGrandma()
    {
        grandmaCount++;
        grandmaCountText.text = grandmaCount.ToString();
    }
}
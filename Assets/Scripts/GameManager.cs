using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    public int clicks;

    void Update()
    {
        clicksText.text = clicks.ToString();
    }

    public void AddClick()
    {
        clicks++;
    }
}
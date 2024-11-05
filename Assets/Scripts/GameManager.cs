using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text grandmaCountText;
    int grandmaCount;

    public void BuyGrandma()
    {
        grandmaCount++;
        grandmaCountText.text = grandmaCount.ToString();
    }
}
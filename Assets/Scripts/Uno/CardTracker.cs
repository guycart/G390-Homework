using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTracker : MonoBehaviour
{
    public Text handTrackerText;

    public Text playStackTrackerText;

    public Text winText;

    // Start is called before the first frame update
    private void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    public void UpdatePlayerHandText(string text) => handTrackerText.text = text;

    public void UpdatePlayStackText(string text) => playStackTrackerText.text = text;

    public void UpdateWinText() => winText.text = "You won, good job beating yourself.";

    public void UdpateAllText(string UpdatePlayerHandText, string stackText)
    {
        handTrackerText.text = playerHandText;
        playStackTrackerText.text = stackText;
    }
}

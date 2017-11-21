using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardsScript : MonoBehaviour {

    public GameObject rewardPanel;
    public GameObject videoPanel;

    public Text moneys;
    int currentCash = 500;
    int rewardMoney = 50;
    void Start () {
        
    }
    

    void Update () {
        
    }
    public void ClickStartButton()
    {
        rewardPanel.SetActive(true);
    }
    public void CloseButtonFunc()
    {
        rewardPanel.SetActive(false);
    }
    public void RewardedVideoPanelOnClick()
    {
        videoPanel.SetActive(true);
    }
    public void RewardedVideoClose()
    {
        videoPanel.SetActive(false);
        currentCash += 2 * rewardMoney;
        moneys.text = currentCash.ToString();
    }
}

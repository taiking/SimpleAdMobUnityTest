using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class RewardedScript : MonoBehaviour
{
    private RewardedAd rewardedAd;

    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        Debug.Log("aaaaaaaaaaaaa");
    }

    public void OnClick()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3010029359415397/9326334640";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3010029359415397/4697035240";
#else
            string adUnitId = "unexpected_platform";
#endif
        this.rewardedAd = new RewardedAd(adUnitId);
        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
        Debug.Log("dddddddddddddddddd");
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        rewardedAd.Show();
        Debug.Log("eeeeeeeeeeee");
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        Debug.Log("ffffffffff");
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        Debug.Log("ggggggggggggggg");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        Debug.Log("hjjjjjjjjjjjj");
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        Debug.Log("qqqqqqqqqqqqq");
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        Debug.Log("iiiiiiiiiiiiiiii");
    }
}
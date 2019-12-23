using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class RewardedScript : MonoBehaviour
{
    private RewardBasedVideoAd rewardBasedVideo;

    public void OnClick()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3010029359415397/9326334640";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3010029359415397/4697035240";
#else
            string adUnitId = "unexpected_platform";
#endif
        this.rewardBasedVideo = RewardBasedVideoAd.Instance;
        rewardBasedVideo.OnAdLoaded += HandleRewardBasedVideoLoaded;
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardBasedVideo.LoadAd(request, adUnitId);
    }

    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        rewardBasedVideo.Show();
    }

}
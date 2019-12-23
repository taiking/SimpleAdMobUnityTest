using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class RewardedScript : MonoBehaviour
{
    private RewardBasedVideoAd rewardBasedVideo;

    public void OnClick()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/1712485313";
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
using GoogleMobileAds.Api;
using UnityEngine;
using System;

public class InterstitialScript : MonoBehaviour
{
    private InterstitialAd interstitial;

    public void OnClick()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3010029359415397/6508599618";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3010029359415397/5031866416";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        this.interstitial.OnAdLoaded += HandleOnAdLoaded;
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        this.interstitial.Show();
    }
}

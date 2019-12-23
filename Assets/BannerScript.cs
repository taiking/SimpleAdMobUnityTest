using GoogleMobileAds.Api;
using UnityEngine;

public class BannerScript : MonoBehaviour 
{
    private BannerView bannerView;

    public void OnClick()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3010029359415397/7064785775";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3010029359415397/1722697861";
#else
            string adUnitId = "unexpected_platform";
#endif
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
    }
}

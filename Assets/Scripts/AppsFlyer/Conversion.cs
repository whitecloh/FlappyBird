using System.Collections.Generic;
using UnityEngine;
using AppsFlyerSDK;
using UnityEngine.UI;

public class Conversion : MonoBehaviour, IAppsFlyerConversionData
{
	[SerializeField]
	private Text _conversion;

    void Start()
    {
        AppsFlyer.initSDK("ZLigGqGzDdxGMT7QBPjsMG", null, this);
        AppsFlyer.startSDK();
    }

    public void onConversionDataSuccess(string conversionData)
    {
        AppsFlyer.AFLog("onConversionDataSuccess", conversionData);
        Dictionary<string, object> conversionDataDictionary = AppsFlyer.CallbackStringToDictionary(conversionData);

            _conversion.text = "Conversion Data: " + conversionData;
    }

    public void onConversionDataFail(string error)
    {
        AppsFlyer.AFLog("onConversionDataFail", error);
    }

    public void onAppOpenAttribution(string attributionData)
    {
        AppsFlyer.AFLog("onAppOpenAttribution", attributionData);
        Dictionary<string, object> attributionDataDictionary = AppsFlyer.CallbackStringToDictionary(attributionData);
    }

    public void onAppOpenAttributionFailure(string error)
    {
        AppsFlyer.AFLog("onAppOpenAttributionFailure", error);
    }
}

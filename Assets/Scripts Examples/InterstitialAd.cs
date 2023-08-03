using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
 
public class InterstitialAd : MonoBehaviour/*, *IUnityAdsLoadListener, IUnityAdsShowListener*/
{
    //[SerializeField] string _androidAdUnitId = "Interstitial_Android";
    //[SerializeField] string _iOsAdUnitId = "Interstitial_iOS";
    //string _adUnitId;
    //private UiAdNoWebManager _uiAdNoWebManager;
    //private int _sceneIndex;
    //private MainLevelManager _mainLevelManager;

    //private int AdWillPlay;
    //void Awake()
    //{
    //    // Get the Ad Unit ID for the current platform:
    //    _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
    //        ? _iOsAdUnitId
    //        : _androidAdUnitId;
        
    //        LoadAd();
        
    //    _uiAdNoWebManager = GameObject.Find("UIAdNoWebConection").GetComponent<UiAdNoWebManager>();
    //    _mainLevelManager = GameObject.Find("MainLevelManager").GetComponent<MainLevelManager>();
    //     _sceneIndex = SceneManager.GetActiveScene().buildIndex;
    //}

    //private void Start()
    //{
    //    if (_mainLevelManager.AdsDisabled == false)
    //    {
    //        AdWillPlay = PlayerPrefs.GetInt("InterstitialAd");
    //        int restartsToAd = PlayerPrefs.GetInt("RestartsToAd");
            
    //            //LoadAd();

    //        if (AdWillPlay > 0 && _sceneIndex > 1 || restartsToAd <= 0 && _sceneIndex > 1)
    //        {
    //            if (Application.internetReachability != NetworkReachability.NotReachable)
    //            {
    //                PlayerPrefs.SetInt("InterstitialAd", 0);
    //                PlayerPrefs.SetInt("RestartsToAd", 10);
    //                ShowAd();
    //            }
    //            else
    //            {
    //                _uiAdNoWebManager.ShowNoNetInfo();
    //                Time.timeScale = 0;
    //                PlayerPrefs.SetInt("RestartsToAd", 3);
    //            }
    //        }
    //    }
    //}
    //// Load content to the Ad Unit:
    //public void LoadAd()
    //{
    //    // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
    //    //Debug.Log("Loading Ad: " + _adUnitId);
    //    Advertisement.Load(_adUnitId, this);
    //}

    //// Show the loaded content in the Ad Unit:
    //public void ShowAd()
    //{
    //    // Note that if the ad content wasn't previously loaded, this method will fail
    //    Debug.Log("Showing Ad: " + _adUnitId);
    //    Time.timeScale = 0;
    //    Advertisement.Show(_adUnitId, this);
        
    //}

    //// Implement Load Listener and Show Listener interface methods: 
    //public void OnUnityAdsAdLoaded(string adUnitId)
    //{
    //    // Optionally execute code if the Ad Unit successfully loads content.
    //}

    //public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    //{
    //    Debug.Log($"Error loading Ad Unit: {adUnitId} - {error.ToString()} - {message}");
    //    Time.timeScale = 1;
    //    // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
    //}

    //public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    //{
    //    Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
    //    Time.timeScale = 1;
    //    // Optionally execute code if the Ad Unit fails to show, such as loading another ad.
    //}

    //public void OnUnityAdsShowStart(string adUnitId) { }
    //public void OnUnityAdsShowClick(string adUnitId) { }
    //public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState) 
    //{
    //    Time.timeScale = 1;
    //}
}

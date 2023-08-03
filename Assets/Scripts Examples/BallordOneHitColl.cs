using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallordOneHitColl : MonoBehaviour
{
    //[SerializeField] private UIPanelManager _uIManager;
    //[SerializeField] private Material _redBollardMaterial;
    //[SerializeField] private CameraPriorityManager _cameraPrioManager;

    //private void Awake()
    //{
    //    OnAwakeAutoFinder();
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag =="Player")
    //    {
    //        if (PlayerPrefs.GetInt("VibrationSettings") == 0)
    //        {
    //            Handheld.Vibrate();
    //        }
    //        _cameraPrioManager.TopDownView();
    //        var _rb = collision.gameObject.GetComponent<Rigidbody>();
    //        _rb.constraints = RigidbodyConstraints.FreezeAll;
    //        StartCoroutine(BallordColorPulse(this.gameObject));
    //    }
    //}

    //private IEnumerator BallordColorPulse(GameObject gameObject)
    //{
    //    Renderer [] gameObjects = gameObject.GetComponentsInChildren<Renderer>();
    //    foreach (Renderer element in gameObjects)
    //    {
    //        var mats = new Material[element.materials.Length];
    //        for (int i =0; i<element.materials.Length; i++)
    //        {
    //            mats[i] = _redBollardMaterial;
    //        }

    //        element.materials = mats;
    //    }
      
    //    bool CoroutineIsRunning = false;

    //    if(CoroutineIsRunning == false)
    //    {
    //        CoroutineIsRunning = true;
    //        yield return new WaitForSeconds (1f);
    //        _uIManager.UIGameOverPanelActivator();
    //        CoroutineIsRunning = false;
    //        StopCoroutine("BallordColorPulse");
    //    }
    //}

    //private void OnAwakeAutoFinder()
    //{
    //    if (_uIManager == null)
    //    {
    //        _uIManager = GameObject.Find("UIPanelManager").GetComponent<UIPanelManager>();
    //    }
    //    if (_cameraPrioManager == null)
    //    {
    //        _cameraPrioManager = GameObject.Find("CameraPriorityManager").GetComponent<CameraPriorityManager>();
    //    }
    //}
}

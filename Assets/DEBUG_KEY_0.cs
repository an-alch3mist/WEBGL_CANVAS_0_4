using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DEBUG_KEY_0 : MonoBehaviour
{


    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            StopAllCoroutines();
            StartCoroutine(STIMULATE());
            //
        }
    }



    public TMPro.TextMeshPro tm;


    IEnumerator STIMULATE()
    {
        #region frame_rate

        QualitySettings.vSyncCount = 2;

        yield return null;
        yield return null;
        #endregion


        tm.text = "#:30";




        yield return null;
    }






}

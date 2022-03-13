using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CANVAS_EVENT_LISTENER_ : MonoBehaviour
{




    public TMPro.TMP_InputField tm_in_store;
    // store
    public void BUTTON_0()
    {
        Debug.Log("button_0");

        System.IO.File.WriteAllText(Application.persistentDataPath + "/" + tm_in_0.text, tm_in_store.text);

        
        // WEBGL
        Application.ExternalEval("_JS_FileSystem_Sync();");
        
    }




    public TMPro.TMP_InputField tm_in_0;
    public TMPro.TMP_InputField tm_in_1;
    public TMPro.TMP_InputField tm_in_2;


    // exist
    public void BUTTON_1()
    {
        Debug.Log(System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_0.text));

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_0.text)) { tm_in_1.text = "true"; }
        else                                                                            { tm_in_1.text = "false"; }

    }


    // load
    public void BUTTON_2()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_0.text))
        {
            tm_in_2.text = System.IO.File.ReadAllText(Application.persistentDataPath + "/" + tm_in_0.text);

        }
        else
        {
            tm_in_2.text = "path not exist";
        }

    }



    /*
            string file_name = "somthng_1.txt";

            if (_store || !System.IO.File.Exists(Application.persistentDataPath + "/" + file_name))
            {


                string str =
    @"
    ----
        [DllImport(__Internal)]
        private static extern void SyncFiles();
        //
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            SyncFiles();
        }
    //
    ----
    ";



                System.IO.File.WriteAllText(Application.persistentDataPath + "/" + file_name, str);

                Application.ExternalEval("_JS_FileSystem_Sync();");

                Debug.Log("stored");
            }

            if(_load)
            {
                string str = System.IO.File.ReadAllText(Application.persistentDataPath + "/" + file_name);
                tm.text = str;

                Debug.Log("loaded");
            }

    */

}

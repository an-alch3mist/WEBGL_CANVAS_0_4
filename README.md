```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CANVAS_EVENT_LISTENER_ : MonoBehaviour
{

    public TMPro.TMP_InputField tm_in_0;
    // store
    public void BUTTON_0()
    {
        Debug.Log("button_0");

        System.IO.File.WriteAllText(Application.persistentDataPath + "/" + tm_in_1.text, tm_in_0.text);

        
        // WEBGL
        Application.ExternalEval("_JS_FileSystem_Sync();");
        
    }



    public TMPro.TMP_InputField tm_in_1;
    public TMPro.TMP_InputField tm_in_2;
    public TMPro.TMP_InputField tm_in_3;


    // exist
    public void BUTTON_1()
    {
        Debug.Log(System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_1.text));

        if (System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_1.text)) { tm_in_2.text = "true"; }
        else                                                                            { tm_in_2.text = "false"; }

    }


    // load
    public void BUTTON_2()
    {
        if (System.IO.File.Exists(Application.persistentDataPath + "/" + tm_in_1.text))
        {
            tm_in_3.text = System.IO.File.ReadAllText(Application.persistentDataPath + "/" + tm_in_1.text);

        }
        else
        {
            tm_in_3.text = "path not exist";
        }

    }


}

```

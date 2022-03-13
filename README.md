```cs

// store
public void WriteAllText(string path , string str)
{
    Debug.Log("button_0");

    System.IO.File.WriteAllText(Application.persistentDataPath + "/" + path, str);
    Application.ExternalEval("_JS_FileSystem_Sync();");
}
```

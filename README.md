```cs

// store
public void WriteAllText(string path , string str)
{
    //
    System.IO.File.WriteAllText(Application.persistentDataPath + "/" + path, str);
    Application.ExternalEval("_JS_FileSystem_Sync();");
}
```

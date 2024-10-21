#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;


public class AssetBundler : MonoBehaviour
{
    
    public static string outputPath = "Assets/";

    [MenuItem("Assets/Build Asset Bundles")]
    static void BuildAssetBundle()
    {        
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        Debug.Log("SUCCESS, CHECK OUTPUT PATH");
    }
}
#endif
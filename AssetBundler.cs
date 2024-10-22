#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class AssetBundler : MonoBehaviour
{
    [MenuItem("Assets/Build Asset Bundles #b")]
    static void BuildAssetBundle()
    {   
        // create output path
        string outputPath = "Assets/Bundles";
        Directory.CreateDirectory(outputPath);
        BuildPipeline.BuildAssetBundles(outputPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        Debug.Log($"Build successfully, check {outputPath}");

        // log asset bundles list
        foreach (string bundle in AssetDatabase.GetAllAssetBundleNames())
        {
            Debug.Log($"Asset bundle: {bundle}");
        }
    }
}
#endif
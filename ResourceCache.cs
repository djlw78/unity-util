using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ResourceCache
{
    static Dictionary<string, Object> cachedObjects = new Dictionary<string, Object>();

    public static GameObject Create(string prefabName)
    {
        if (!cachedObjects.ContainsKey(prefabName))
        {
            cachedObjects[prefabName] = Resources.Load(prefabName);
        }

        return (GameObject)Object.Instantiate(cachedObjects[prefabName]);
    }
}

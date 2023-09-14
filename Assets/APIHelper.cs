using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class APIHelper : MonoBehaviour
{
    [SerializeField] private Material _material;

    public async void GetNewImageAsync()
    {
        string category = "nature";
        Texture2D texture = new Texture2D(2, 2);
        
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("https://picsum.photos/200/300");

        www.SendWebRequest();
        Debug.Log("Wait 3 seconds");
        await Task.Delay(TimeSpan.FromSeconds(3));

        if (www.result == UnityWebRequest.Result.Success)
        {
            texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
        else
        {
            Debug.LogError("Error: " + www.error);
        }
        _material.mainTexture = texture;
    }
}
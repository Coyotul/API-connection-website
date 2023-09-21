using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class APIHelper : MonoBehaviour
{
    [SerializeField] private Material _material;

    //Get new image through API and apply it to object's material
    public async void GetNewImageAsync()
    {
        string category = "nature";
        Texture2D texture = new Texture2D(2, 2);
        
        //Get reference to the website
        UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture("https://picsum.photos/200/300");

        //Send request to website
        webRequest.SendWebRequest();
        //Wait 3 seconds for request
        Debug.Log("Wait 3 seconds");
        await Task.Delay(TimeSpan.FromSeconds(3));

        //If the result of the request was a success then download it
        if (webRequest.result == UnityWebRequest.Result.Success)
        {
            texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
        }
        else
        {
            Debug.LogError("Error: " + webRequest.error);
        }
        
        //Apply texture to object's material
        _material.mainTexture = texture;
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GetImage : MonoBehaviour
{
    [SerializeField] private APIHelper _apiHelper;
    
    //get new image when the object is clicked
    private void OnMouseDown()
    {
        //Change Image
        _apiHelper.GetNewImageAsync();
    }
}

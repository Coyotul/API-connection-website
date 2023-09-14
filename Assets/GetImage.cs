using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class GetImage : MonoBehaviour
{
    [SerializeField] private APIHelper _apiHelper;
    private void OnMouseDown()
    {
        //Change Image
        _apiHelper.GetNewImageAsync();
    }
}

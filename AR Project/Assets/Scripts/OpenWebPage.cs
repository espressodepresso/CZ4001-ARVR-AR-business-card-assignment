using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWebPage : MonoBehaviour
{
    public string pageurl;

    public void OpenURL()
    {
        Application.OpenURL(pageurl);
    }
}

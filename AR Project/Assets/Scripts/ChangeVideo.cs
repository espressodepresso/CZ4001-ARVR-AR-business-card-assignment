using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeVideo : MonoBehaviour
{

    public GameObject cube;
    private List<string> videoList = new List<string> {"climbing_1","climbing_2","climbing_3","climbing_4","climbing_5"};
    public void nextVideo()
    {
        var curClip = cube.gameObject.GetComponent<VideoPlayer>().clip.ToString().Split()[0];
        int nextIndex = videoList.FindIndex(videoList => videoList.Contains(curClip))+1; 
        if (nextIndex==videoList.Count){nextIndex=0;}
        var newclip = Resources.Load<VideoClip>(videoList[nextIndex]);
        cube.gameObject.GetComponent<VideoPlayer>().clip = newclip;
    }
    public void prevVideo()
    {
        Debug.Log("CLICK");
        var curClip = cube.gameObject.GetComponent<VideoPlayer>().clip.ToString().Split()[0];
        int nextIndex = videoList.FindIndex(videoList => videoList.Contains(curClip))-1; 
        if (nextIndex==-1){nextIndex=(videoList.Count)-1;}
        var newclip = Resources.Load<VideoClip>(videoList[nextIndex]);
        cube.gameObject.GetComponent<VideoPlayer>().clip = newclip;
    }
}

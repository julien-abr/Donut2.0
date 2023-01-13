using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class TimelineManager : MonoBehaviour
{
    #region Singleton
    public static TimelineManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    #endregion

    [Serializable]
    public struct Timelines
    {
        public string name;
        public GameObject timelineObj;
    }

    public List<Timelines> cinematics = new List<Timelines>();

    private void Start()
    {
        StartCoroutine(Test("Snowmobile", 2f));
        StartCoroutine(Test("FlyingBirds", 0.5f));
        StartCoroutine(Test("ImmersiveCam", 0f));
    }

    public void PlayCinematic(string cinematicName)
    {
        for(int i = 0; i < cinematics.Count; i++)
        {
            if(cinematics[i].name == cinematicName)
            {
                cinematics[i].timelineObj.GetComponent<PlayableDirector>().Play();
                return;
            }
        }
    }
    private IEnumerator Test(string cinematic, float duration)
    {
        yield return new WaitForSeconds(duration);
        PlayCinematic(cinematic);
    }
}

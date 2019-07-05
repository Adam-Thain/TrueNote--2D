using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region public properties

    public AudioSource theMusic;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    #endregion

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        instance = this;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public void NoteHit()
    {
        Debug.Log("Hit");
    }

    /// <summary>
    /// 
    /// </summary>
    public void NoteMissed()
    {
        Debug.Log("Missed");
    }
}

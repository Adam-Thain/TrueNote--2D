using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{
    [Header("Beats Per Minute")]
    public float beatTempo;

    public bool hasStarted;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        
        if (!hasStarted)
        {
            /*
            if (Input.anyKeyDown)
            {
                hasStarted = true;
            }
            */
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}

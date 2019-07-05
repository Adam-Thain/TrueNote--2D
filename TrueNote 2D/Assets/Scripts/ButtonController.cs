using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;

    public Sprite defaualtImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            theSR.sprite = defaualtImage;
        }
    }
}

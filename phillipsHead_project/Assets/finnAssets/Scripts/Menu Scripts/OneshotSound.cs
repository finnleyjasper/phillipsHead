using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneshotSound : MonoBehaviour
{
    public AudioSource sfx;

    private void Start()
    {
        sfx.playOnAwake = false;
    }
}

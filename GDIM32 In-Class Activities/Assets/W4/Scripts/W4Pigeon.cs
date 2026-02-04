using System;
using UnityEngine;

public class W4Pigeon : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Animator _animator;

    // REMOVE these references to other objects!
    // we're going to alert them via EVENT instead!!

    // HERE, add an event to tell other objects that the pigeon coo'd!
    public delegate void EmptyDelegate ();
    public event EmptyDelegate Cooo;

    // don't change the code in this method!
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Coo();
        }
    }

    private void Coo ()
    {
        Debug.Log("squack!");

        // do pigeon stuff
        _audio.Play();
        _animator.SetTrigger("wiggle");

        // HERE, you'll want to REMOVE the code to "tell seagulls", "tell UI", and "tell VFX"
        Cooo?.Invoke();
        
    //     // tell seagulls
    //     foreach(W4Seagull seagull in _seagulls)
    //     {
    //         seagull.HandlePigeonCoo();
    //     }

    //     // tell UI
    //     _ui.HandlePigeonCoo();

    //     // tell VFX
    //     _vfx.HandlePigeonCoo();
    // }
}
}

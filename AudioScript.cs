using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip hop, jump, land, eat, lose, win;
    static AudioSource AudioSrc;
    void Start()
    {
        hop = Resources.Load<AudioClip>("RabbitsHole");
        jump = Resources.Load<AudioClip>("jump");
        land = Resources.Load<AudioClip>("land");
        eat = Resources.Load<AudioClip>("eatCarrot");
        lose = Resources.Load<AudioClip>("lose");
        win = Resources.Load<AudioClip>("win");

        AudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "hop":
                AudioSrc.PlayOneShot(hop);
                break;
            case "jump":
                AudioSrc.PlayOneShot(jump);
                break;
            case "land":
                AudioSrc.PlayOneShot(land);
                break;
            case "eat":
                AudioSrc.PlayOneShot(eat);
                break;
            case "lose":
                AudioSrc.PlayOneShot(lose);
                break;
            case "win":
                AudioSrc.PlayOneShot(win);
                break;
        }

    }
}

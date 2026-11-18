using UnityEngine;

public class Footsteps : MonoBehaviour
{
    Rigidbody2D rb;

    public AudioSource Walk;

    public float soundThreshold = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Walk = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(rb.linearVelocityX) > soundThreshold)
        {
            if (!Walk.isPlaying) Walk.Play();
        }
        else
        {
            if (Walk.isPlaying) Walk.Pause();
        }
    }
}

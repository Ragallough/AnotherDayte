using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class OpenDoor : MonoBehaviour
{
    bool open = false;

    public GameObject player;
    public GameObject Indicator;

    public PlayerInput playerInput;

    public Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        open = false;
    }

    void OnTriggerEnter(Collider other)
    {
        open = true;
        Debug.Log("open true");

        Indicator.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        open = false;
        Debug.Log("open false");

        Indicator.SetActive(false);
    }

    public void OnInteract()
    {
        Debug.Log("interacting");

        if (open == true)
        {
            player.GetComponent<Transform>().position = playerPosition;
            Debug.Log("opened door");
        }
    }
}

using UnityEngine;

public class InteractionBox : MonoBehaviour
{
    //all of the interaction boxes will be activatable by pressing 'e'
    //therefore, I want to make it so that only one box is active at a time

    public GameObject Dialogue;
    public GameObject Indicator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //on player enter set dialogue flowchart to active
    private void OnTriggerEnter(Collider other)
    {
        if (Dialogue != null)
        {
            if (other.gameObject.CompareTag("Player") && !Dialogue.activeInHierarchy && !Indicator.activeInHierarchy)
            {
                Dialogue.SetActive(true);
                Indicator.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (Dialogue != null)
        {
            if (other.gameObject.CompareTag("Player") && Dialogue.activeInHierarchy && Indicator.activeInHierarchy)
            {
                Dialogue.SetActive(false);
                Indicator.SetActive(false);
            }
        }

    }

}


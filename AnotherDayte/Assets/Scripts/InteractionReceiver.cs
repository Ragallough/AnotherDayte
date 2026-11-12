using StarterAssets;
using UnityEngine;

public class InteractionReceiver : MonoBehaviour
{
    public FirstPersonController playerController;
    public StarterAssetsInputs starterInputs;
    public GameObject interactionIndicator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GetComponent<FirstPersonController>();
        starterInputs = GetComponent<StarterAssetsInputs>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    public void StopMovement()
    {
        if (playerController != null)
        {
            if (playerController.isActiveAndEnabled)
            {
                starterInputs.cursorLocked = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                playerController.enabled = false;
            }
            if (interactionIndicator.activeInHierarchy)
            {
                interactionIndicator.SetActive(false);
            }
        }
    }

    public void EnableMovement()
    {
        if (playerController != null)
        {
            if (!playerController.isActiveAndEnabled)
            {
                playerController.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                //Debug.Log(Cursor.visible);
                starterInputs.cursorLocked = true;
            }
            if(!interactionIndicator.activeInHierarchy)
            {
                interactionIndicator.SetActive(true);
            }
        }
    }
        // Update is called once per frame
        void Update()
    {
        //Debug.Log(Cursor.visible);
    }
}

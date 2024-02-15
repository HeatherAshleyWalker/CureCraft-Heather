using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class pause : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    void Awake()
    {

        if (canvasGroup == null)
        {
            Debug.LogError("CanvasGroup object not found");
        }

        canvasGroup = GetComponent<CanvasGroup>();

    }

    void Update()
    {
        // Toggle pause menu visibility when Escape key is pressed
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (canvasGroup != null)
            {
                if (canvasGroup.interactable)
                {
                    canvasGroup.interactable = false;
                    canvasGroup.blocksRaycasts = false;
                    canvasGroup.alpha = 0f;
                    Time.timeScale = 0f;
                }
                else
                {
                    canvasGroup.interactable = true;
                    canvasGroup.blocksRaycasts = true;
                    canvasGroup.alpha = 1f;
                    Time.timeScale = 1f;
                }
            }
        }
    }
}

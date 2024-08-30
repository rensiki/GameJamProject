using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public CanvasGroup optionPanel;  
    public void SetOptionPanelOpaque()
    {
        if (optionPanel != null)
        {
            optionPanel.alpha = 1;  
            optionPanel.interactable = true;  
            optionPanel.blocksRaycasts = true;  
        }
    }
}

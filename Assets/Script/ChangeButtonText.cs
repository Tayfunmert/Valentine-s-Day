using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour
{
    public Button yourButton; // Verweis auf Ihren Button im Inspector
    public TextMeshProUGUI buttonText; // Verweis auf das TextMeshProUGUI-Element auf dem Button
    private int clickCount = 0;

    private void Start()
    {
        // Fügen Sie einen Listener zum Button-Klick-Ereignis hinzu
        yourButton.onClick.AddListener(ChangeButtonTextMethod);
    }
    public void Update()
    {
        switch(clickCount){
            case 1: buttonText.text = "Are you sure?"; break;
            case 2: buttonText.text = "Really sure?"; break;
            case 3: buttonText.text = "Think again!"; break;
            case 4: buttonText.text = "Last chance!"; break;
            case 5: buttonText.text = "Surely not?"; break;
            case 6: buttonText.text = "You might regrett this"; break;
            case 7: buttonText.text = "Give it another thought!"; break;
            case 8: buttonText.text = "Are you absolutely certain?"; break;
            case 9: buttonText.text = "This could be a mistake!"; break;
            case 10: buttonText.text = "Have a heart!"; break;
            case 11: buttonText.text = "Don't be so cold!"; break;
            case 12: buttonText.text = "Change of heart?"; break;
            case 13: buttonText.text = "Wouldn't you reconsider?"; break;
            case 14: buttonText.text = "Is that your final answer?"; break;
            case 15: buttonText.text = "You're breaking my heart ;("; break;
        }
    }

    void ChangeButtonTextMethod()
    {
        // Ändern Sie den Text jedes Mal, wenn der Button gedrückt wird
        clickCount++;
        // buttonText.text = "Button wurde " + clickCount + " mal geklickt";
    }
}

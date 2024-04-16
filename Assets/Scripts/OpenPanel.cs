using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    
    public GameObject playPanel;
    public GameObject settingsPanel;

    void Start(){

        playPanel.SetActive(false);

        settingsPanel.SetActive(false);
        
    }

    public void OpenPlayPanel(){

        playPanel.SetActive(true);

    }

    public void OpenSettingsPanel(){

        settingsPanel.SetActive(true);

    }

    public void ClosePlayPanel(){
        
        playPanel.SetActive(false);

    }

    public void CloseSettingsPanel(){
        
        settingsPanel.SetActive(false);

    }
}

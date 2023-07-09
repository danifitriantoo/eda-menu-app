using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MainMenuController : MonoBehaviour
{

    CutsceneTransition cutsceneTransition = new CutsceneTransition();

    void Start()
    {
        
    }

    public void OnPlayButton() {
        cutsceneTransition.changeScene(1,false);
    }
 
    public void OnSettingButton() {
        cutsceneTransition.changeScene(5,false);
    }
 
    public void OnExitButton() {
        Application.Quit();
    }
}
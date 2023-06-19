using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance;

    private void Awake()
    {
        instance = this; 
    }
    public enum Scene
    {
        Start,
        CreateCharacter,
        Overview
    }
    //Use it with ".LoadScene(Scenesmanager.Scene.ExampleScene"
    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Overview.ToString());
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Start.ToString());
        Charakters.Loc.Clear();
    }
    public void LoadCharakterCreation()
    {
        SceneManager.LoadScene(Scene.CreateCharacter.ToString());
    }

}

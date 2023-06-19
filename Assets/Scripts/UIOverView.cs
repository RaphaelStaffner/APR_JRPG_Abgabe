using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOverView : MonoBehaviour
{
    [SerializeField] Button _backToMainMenu;
    [SerializeField] Button _ToCharcterCreation;
    // Start is called before the first frame update
    void Start()
    {
        _backToMainMenu.onClick.AddListener(BackToMainMenu);
        _ToCharcterCreation.onClick.AddListener(ToCharacterCreation);
    }
    private void BackToMainMenu()
    {
        ScenesManager.instance.LoadMainMenu();
    }
    private void ToCharacterCreation()
    {
        ScenesManager.instance.LoadCharakterCreation();
    }
    // Update is called once per frame
    void Update()
    {

    }
}

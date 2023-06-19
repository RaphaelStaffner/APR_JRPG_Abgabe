using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button _startNewGame;
    // Start is called before the first frame update
    void Start()
    {
        _startNewGame.onClick.AddListener(StartNewGame);   
    }
    private void StartNewGame()
    {
        ScenesManager.instance.LoadCharakterCreation();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

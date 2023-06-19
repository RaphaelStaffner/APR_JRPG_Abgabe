using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class UICharaterCreation : MonoBehaviour
{
    public Image charakterpicture;
    public TextMeshProUGUI NameOfCharakter;
    public TextMeshProUGUI CharakterRole;
    public TextMeshProUGUI CharakterLevel;
    public TMP_InputField CharakterName;
    [SerializeField] Button _continue;
    [SerializeField] TMP_Dropdown _Roles;
    public int Level;

    private void Awake()
    {
        List<string> RolesForCreation = new List<string>() { "Knight", "Rogue", "Tank", "Wizard" };
        _Roles.ClearOptions();
        _Roles.AddOptions(RolesForCreation);
    }
    // Start is called before the first frame update
    void Start()
    {
        Level= 5;
        _continue.onClick.AddListener(Continue);

        
        NameOfCharakter.text = "Name: ";
        CharakterRole.text = "Rolle: ";
        CharakterLevel.text = "Level: " + Level;
        
    }

    private void Continue()
    {
        string NameOftheCharakter = "Nothing";
        if (CharakterName.text.Equals("") || CharakterName.text == null)
        {
            NameOftheCharakter = "Günther";
        }
        else
        {
            NameOftheCharakter = CharakterName.text;
        }
        Charakters test = new Charakters(name: NameOftheCharakter, role: _Roles.options[_Roles.value].text, level: Level, exp: 100, expneeded: 200);
        Debug.Log(_Roles.value.ToString());
        Charakters.Loc.Add(test);
        
        ScenesManager.instance.LoadNewGame();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}

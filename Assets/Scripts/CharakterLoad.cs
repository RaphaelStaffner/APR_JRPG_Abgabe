using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharakterLoad : MonoBehaviour
{
    public Image charakterpicture;
    public TextMeshProUGUI NameOfCharakter;
    public TextMeshProUGUI CharakterRole;
    public TextMeshProUGUI CharakterLevel;
    public TextMeshProUGUI CharakterHP;
    public TextMeshProUGUI CharakterMana;
    public int CharakterID;
    


    // Start is called before the first frame update
    void Awake()
    {
        if (CharakterID >= Charakters.Loc.Count) {
            Debug.Log("Charakter " + CharakterID + "not found");
        }
        else{
            NameOfCharakter.text = "Name: " + Charakters.Loc[CharakterID].CharacterName;
            CharakterRole.text = "Rolle: " + Charakters.Loc[CharakterID].role;
            CharakterLevel.text = "Level: " + Charakters.Loc[CharakterID].level;
            CharakterHP.text = "Leben: " + Charakters.Loc[CharakterID].currentHP + "/" + Charakters.Loc[CharakterID].HP;
            CharakterMana.text = "Mana: " + Charakters.Loc[CharakterID].currentMP + "/" + Charakters.Loc[CharakterID].MP;
        }
       

        Debug.Log("Amount of Charakters: " + Charakters.Loc.Count);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

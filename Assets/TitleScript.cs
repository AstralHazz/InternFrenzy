using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using TMPro;
public class TitleScript : MonoBehaviour
{
    public TMP_Text textTitle;
    public int quests;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        textTitle = GetComponent<TMP_Text>();
        quests = DialogueQuests.NarrativeData.completedQuestsNum;

        if (DialogueQuests.NarrativeData.completedQuestsNum == 1)
            textTitle.text = "You completed " + DialogueQuests.NarrativeData.completedQuestsNum + " quest!";
        else if (DialogueQuests.NarrativeData.completedQuestsNum > 1 || DialogueQuests.NarrativeData.completedQuestsNum < 1)
            textTitle.text = "You completed " + DialogueQuests.NarrativeData.completedQuestsNum + " quests!";
    }
}
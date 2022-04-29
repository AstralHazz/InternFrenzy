using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestsCompleted : MonoBehaviour
{
    public GameObject checkObject;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = DialogueQuests.NarrativeData.completedQuestsNum;

        if (score > 13) // well done
        {
            if (this.gameObject.name == "WellDone Check")
            {
                Debug.Log("Well Done");
                this.gameObject.SetActive(false);
            }
        }
        else if (score < 7) // we failed
        {
            if (this.gameObject.name == "WeFailed Check")
            {
                Debug.Log("We Failed");
                this.gameObject.SetActive(false);
            }
        }
        else if (score >= 7 || score <= 13) // mediocre
        {
            if (this.gameObject.name == "Mediocre Check")
            {
                Debug.Log("Mediocre");
                this.gameObject.SetActive(false);
            }
        }
    }
}

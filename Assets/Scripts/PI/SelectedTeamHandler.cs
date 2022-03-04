using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectedTeamHandler : MonoBehaviour
{
    [SerializeField]
    Party team;

    [SerializeField]
    List<Image> activePartyImages;

    [SerializeField]
    Button finishSelectionButton;

    public void AddMemberToActiveParty(Character newMember)
    {
        team.AddActiveCharater(newMember);

        int chosenMemberCount = 0;
        for (int i = 0; i < team.ActiveParty.Length; i++)
        {
            if (team.ActiveParty[i] == null)
            {
                Color noAlpha = activePartyImages[i].color;
                noAlpha.a = 0.0f;
                activePartyImages[i].color = noAlpha;
            }
            else
            {
                activePartyImages[i].color = Color.white;
                activePartyImages[i].sprite = team.ActiveParty[i].Image;
                chosenMemberCount++;
            }
        }

        if (chosenMemberCount >= team.ActiveParty.Length)
            finishSelectionButton.interactable = true;
        else
            finishSelectionButton.interactable = false;
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}

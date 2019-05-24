using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationHandler : MonoBehaviour
{

    public AudioSource AudioSource;

    public AudioClip Wind;
    
    public Animator MainAni;
    public Animator GameSetupAni;
    public Animator CharacterAni;
 
  
//Main Menu to Game Setup and back    
    public void FightPressed ()

    {
        AudioSource.clip = Wind;
        MainAni.SetInteger("FightClicked", 1);
        GameSetupAni.SetInteger("FightClicked", 1);
        AudioSource.Play();  
    }

    public void BackPressed()
    
    {
        MainAni.SetInteger("FightClicked", 0);
        GameSetupAni.SetInteger("FightClicked", 0);
    }
    
    
    //Game Setup to Character Selection and back
    
    public void CharacterSelectPressed()
    
    {
        GameSetupAni.SetInteger("ToCharacterSelect", 1);
        CharacterAni.SetInteger("ToCharacterSelect", 1);      
    }
    
    public void BackToSetupPressed()
    
    {
        GameSetupAni.SetInteger("ToCharacterSelect", 0);
        CharacterAni.SetInteger("ToCharacterSelect", 0);      
    }
}


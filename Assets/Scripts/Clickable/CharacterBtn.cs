using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBtn : MonoBehaviour
{
    public Image CharBtn;
    public Canvas CharSelect;
    public Image doc;
    public Image peng;
    public SpriteRenderer characterRenderer;
    public Animator animator;

    public void ChangeCharacter()
    {
        CharSelect.gameObject.SetActive(true);
    }

    public void SelectCharacter(Image i)
    {
        RectTransform CharBtnrect = CharBtn.GetComponent<RectTransform>();
        RectTransform rect = i.GetComponent<RectTransform>();
        CharBtnrect.sizeDelta = rect.sizeDelta;
        CharBtn.sprite = i.sprite;
        characterRenderer.sprite = i.sprite;
        switch (i.name.ToString())
        {
            case "Peng":
                animator.SetInteger("CharacterIndex", 1);
                break;
            case "Doc":
                animator.SetInteger("CharacterIndex", 2);
                break;
        }
        CharSelect.gameObject.SetActive(false);
    }
}

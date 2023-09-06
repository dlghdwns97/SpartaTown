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
    public void Selectdoc()
    {
        RectTransform CharBtnrect = CharBtn.GetComponent<RectTransform>();
        RectTransform docrect = doc.GetComponent<RectTransform>();
        CharBtnrect.sizeDelta = docrect.sizeDelta;
        CharBtn.sprite = doc.sprite;
        characterRenderer.sprite = doc.sprite;
        animator.SetInteger("CharacterIndex", 2);
        CharSelect.gameObject.SetActive(false);
    }
    public void Selectpeng()
    {
        RectTransform CharBtnrect = CharBtn.GetComponent<RectTransform>();
        RectTransform pengrect = peng.GetComponent<RectTransform>();
        CharBtnrect.sizeDelta = pengrect.sizeDelta;
        CharBtn.sprite = peng.sprite;
        characterRenderer.sprite = peng.sprite;
        animator.SetInteger("CharacterIndex", 1);
        CharSelect.gameObject.SetActive(false);
    }
    public void SelectCharacter()
    {

    }
}

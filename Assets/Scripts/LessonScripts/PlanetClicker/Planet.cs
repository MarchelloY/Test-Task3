using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Planet : MonoBehaviour,
    IPointerClickHandler,
    IPointerEnterHandler,
    IPointerExitHandler
{
    [SerializeField] private Image image;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnPlanetClick?.Invoke();
        image.DOColor(Color.clear, 0.3f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.transform.DOScale(Vector3.one * 1.1f, 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.transform.DOScale(Vector3.one, 0.3f);
    }

    private event Action OnPlanetClick;

    public void Setup(Sprite sprite, Action onClickCallback)
    {
        image.color = Color.white;
        image.sprite = sprite;
        OnPlanetClick = onClickCallback;
    }
}
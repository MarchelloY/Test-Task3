using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyItem : MonoBehaviour,
    IPointerClickHandler,
    IPointerEnterHandler,
    IPointerExitHandler,
    IDragHandler,
    IEndDragHandler
{
    [SerializeField] private Image image;

    private float _cost;
    
    private event Action OnPlanetClick;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        OnPlanetClick?.Invoke();
        //image.DOColor(Color.clear, 0.3f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.transform.DOScale(Vector3.one * 1.1f, 0.3f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.transform.DOScale(Vector3.one, 0.3f);
    }
    
    public void Setup(Sprite sprite, Action onClickCallback, float cost)
    {
        image.sprite = sprite;
        OnPlanetClick = onClickCallback;
        _cost = cost;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        image.transform.position = pos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var posCursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

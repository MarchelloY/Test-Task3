using DG.Tweening;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    [SerializeField] private Camera camera;
    private Vector3 _offset;

    private void OnMouseDown()
    {
        var pos = camera.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        _offset = transform.position - pos;

        transform.DOScale(Vector3.one * 1.5f, 0.3f);
    }

    private void OnMouseDrag()
    {
        var pos = camera.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        pos += _offset;

        transform.position = pos;
    }

    private void OnMouseEnter()
    {
        transform.DOScale(Vector3.one * 1.2f, 0.3f);
    }

    private void OnMouseExit()
    {
        transform.DOScale(Vector3.one, 0.3f);
    }

    private void OnMouseOver()
    {
        transform.Rotate(Time.deltaTime * 90f * Vector3.forward);
    }

    private void OnMouseUp()
    {
        transform.DOScale(Vector3.one * 1.2f, 0.3f);
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Click");
    }
}
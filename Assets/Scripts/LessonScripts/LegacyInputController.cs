using DG.Tweening;
using UnityEngine;

public class LegacyInputController : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private Transform aimTransform;
    [SerializeField] private GameObject bulletPrefab;

    private bool _jump;
    private bool _shot;

    private void Update()
    {
        var pos = cubeTransform.position;
        pos.x = Input.GetAxis("Horizontal");
        cubeTransform.position = pos;

        if (Input.GetButtonDown("Jump") && !_jump)
        {
            var jumpSequence = DOTween.Sequence();
            jumpSequence.Append(cubeTransform.DOJump(pos, 1f, 1, 0.3f));
            _jump = true;
            jumpSequence.OnComplete(() => _jump = false);
        }

        if (!Input.GetKey(KeyCode.W))
        {
            aimTransform.gameObject.SetActive(false);
            return;
        }

        aimTransform.gameObject.SetActive(true);

        var dir = Input.GetAxis("Mouse X");
        pos = aimTransform.position;
        pos.x += dir * Time.deltaTime * 5f;

        pos.x = Mathf.Clamp(pos.x, -1f, 1f);

        aimTransform.position = pos;

        if (!Input.GetMouseButton(0) || _shot) return;

        var obj = Instantiate(bulletPrefab, aimTransform.position, Quaternion.identity);
        _shot = true;

        var shotSequence = DOTween.Sequence();
        shotSequence.Append(obj.transform.DOMoveZ(10f, 1f));
        shotSequence.OnComplete(() =>
        {
            Destroy(obj);
            _shot = false;
        });
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��v���A�t��
/// </summary>
public class CameraScript : MonoBehaviour
{
    /// <summary>
    /// �ϥΦ��Ϫ��j�p�ӾA�t��v���� orthographicSize
    /// </summary>
    [SerializeField] SpriteRenderer _background;
    private float _halfBackgroundBoundSizeY;

    // Start is called before the first frame update
    void Start()
    {
        _halfBackgroundBoundSizeY = _background.bounds.size.y / 2;

        _fitFullWidth();
    }

    /// <summary>
    /// �����M�����A�t
    /// </summary>
    private void _autoFit()
    {
        float ScreenRatio = (float)Screen.width / (float)Screen.height;
        float TargetRatio = _background.bounds.size.x / _background.bounds.size.y;

        if (ScreenRatio >= TargetRatio)
        {
            _fitFullHeight();
        }
        else
        {
            float DifferenceInSize = TargetRatio / ScreenRatio;

            Camera.main.orthographicSize = _halfBackgroundBoundSizeY * DifferenceInSize;
        }
    }

    /// <summary>
    /// �����A�t�A�e�ץi��|�Q����A�Φh�X��
    /// </summary>
    private void _fitFullHeight()
    {
        Camera.main.orthographicSize = _halfBackgroundBoundSizeY;
    }

    /// <summary>
    /// �e�׾A�t�A���ץi��|�Q����A�Φh�X��
    /// </summary>
    private void _fitFullWidth()
    {
        float OrthoSize = _background.bounds.size.x * Screen.height / Screen.width * 0.5f;

        Camera.main.orthographicSize = OrthoSize;
    }
}
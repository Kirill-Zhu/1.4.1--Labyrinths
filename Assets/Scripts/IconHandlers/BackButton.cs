using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BackButton : MonoBehaviour
{

    public float Spacing = 200;

    private Animator _animator;
    private bool _isEnabled = true;
    [Inject]
    [SerializeField] private HomeButton _homeButton;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        SetStandartPos();
    }
    public void EnableBackButton()
    {
        if (_animator != null&&!_isEnabled)
        {
            _animator.SetTrigger("Enable");
            _isEnabled = true;
        }
    }
    public void DisableBackButton()
    {
        if(_animator!=null&&_isEnabled)
        {
            _animator.SetTrigger("Disable");
            _isEnabled=false;
        }
    }
    public void SetStandartPos()
    {
        GetComponent<RectTransform>().SetPositionAndRotation(_homeButton.GetComponent<RectTransform>().position + new Vector3(-Spacing, 0), Quaternion.identity);
    }
}

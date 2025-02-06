using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Unity.VisualScripting;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletPivot;
    [SerializeField]
    private Animator _weaponAnimator;

    [SerializeField]
    private int _maxBulletNumber = 20;
    [SerializeField]
    private int _cartridgeBulletsNumber = 5;
    private int _totalBulletsNumber = 0;
    private int _currentBulletsNumber = 0;
    private Text _bulletsText;
    private GetWeapon _getWeapon;

    private void RemoveWeapon()
    {
        _getWeapon.RemoveWeapon();
        _getWeapon = null;
    }
  public void Shoot()
  {
    if(_currentBulletsNumber == 0)
    {
      if (_totalBulletsNumber == 0)
      {
            RemoveWeapon();
      }
      return;
    }
    _weaponAnimator.Play("Shoot", -1, 0f);
    GameObject.Instantiate(_bullet, _bulletPivot.position, _bulletPivot.rotation);
    _currentBulletsNumber--;
    UpdateBulletsText();
  }
  public void PickUpWeapon(GetWeapon getWeapon)
  {
    _getWeapon = getWeapon;
    _totalBulletsNumber = _maxBulletNumber;
    Reload();
    _weaponAnimator.Play("GetWeapon");
    UpdateBulletsText();
  }

  public void Reload()
  {
    if (_currentBulletsNumber == _cartridgeBulletsNumber || _totalBulletsNumber == 0)
     {
             return;
     }

     int bulletsNeeded = _cartridgeBulletsNumber - _currentBulletsNumber;

     if (_totalBulletsNumber >= _cartridgeBulletsNumber)
     {
        _currentBulletsNumber = bulletsNeeded;
     }
     else if (_totalBulletsNumber > 0)
     {
       _currentBulletsNumber = _totalBulletsNumber;
     }
     _totalBulletsNumber -= _currentBulletsNumber;
     UpdateBulletsText();
     _weaponAnimator.Play("Reload");
  }

  private void UpdateBulletsText()
  
  {
    if (_bulletsText == null)
    {
        _bulletsText = _getWeapon.GetComponent<UIController>().BulletsText;
    }
    _bulletsText.text = _currentBulletsNumber + "/" + _totalBulletsNumber;
  }

  
}

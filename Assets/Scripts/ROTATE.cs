using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float _rotateSpeed = 5;
    [SerializeField]
    private bool _isRotating = true;
    
    public bool IsRotating
    {
        get {return _isRotating;}
        set {_isRotating = value;}
    }

   
    void Update()
    {
       RotateWeapon();
    }

    private void RotateWeapon()
    {
        if (_isRotating)
        {
        gameObject.transform.Rotate(0f, _rotateSpeed * Time.deltaTime, 0f);
        }
    }
}

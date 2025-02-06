using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
   [SerializeField]
   private GameObject _bulletUI;

   [SerializeField]
   private Text _bulletsText;
   public Text BulletsText
   {
     get{return _bulletsText;}
   }

   public void ShowBulletUI(bool show)
   {
     _bulletUI.SetActive(show);
   }
}


using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    
   private static int _hp = 10;
   [SerializeField] private Text _hpText;

    public static void ReduceHp(int value) 
    {
        _hp -= value;
    }
    
    private void Update() 
    {
        if (_hp <= 0)
        {
            Win();
        }
        _hpText.text = "BossHp = " + _hp.ToString();
    }

    private void Win()
    {
        Debug.Log("You Win");
    }

}

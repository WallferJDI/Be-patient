using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public  class PlayerPref : MonoBehaviour
{
    [SerializeField] private Text _dayInfo;
    [SerializeField] private Text _moneyInfo;
    [SerializeField] private Text _stateInfo;
    private static float _moneyCash = 200;
    private static float _moneyCard = 200;
    private static int _day;
    private  string _state;
    
    public static int Day { get { return _day; } set { _day = value; } }
    public static float MoneyCard { get { return _moneyCard; } set { _moneyCard = value; } }
    private void Update()
    {
        _moneyInfo.text = $"�������: {_moneyCash}� | �����: {_moneyCard}�";
        _dayInfo.text = $"���� {_day}";
        _stateInfo.text = _state;
    }

}

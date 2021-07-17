
using UnityEngine;
using System.Collections;

public class AttackButton : MonoBehaviour
{
    [SerializeField] private GameObject _AttackButton;
    public void OnClickButton()
    {
        Boss.ReduceHp(1);
        _AttackButton.SetActive(false);
        StartCoroutine(ButtonActive());
    }

    IEnumerator ButtonActive()
    {
        yield return new WaitForSeconds(6);
        _AttackButton.SetActive(true);
        StopCoroutine(ButtonActive());

    }
}

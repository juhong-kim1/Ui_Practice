using UnityEngine;
using System.Collections;

public class GameOverWindow : GenericWindow
{
    public GameObject score;


    private void Start()
    {
        score.SetActive(false);
        gameObject.SetActive(false);
    }

    //private IEnumerator CoRoutine()
    //{
    //    yield return 

    //}

}

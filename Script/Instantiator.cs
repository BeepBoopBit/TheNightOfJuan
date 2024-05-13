using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine.UI;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject _enemy;
    public Transform _player;
    private int numberOfClones = 0;
    public int maxNumberOfClones = 10;
    
    // to be implemented
    // spawn mobs dependent on the time
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        // implement grace period
        // timer before spawning another object
        if (numberOfClones < maxNumberOfClones)
        {
            Vector2 position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
            ++numberOfClones;
            GameObject temp = Instantiate(_enemy, position, Quaternion.identity);
            temp.GetComponent<AIDestinationSetter>().target= _player;
            Debug.Log(numberOfClones);
        }
    }
}

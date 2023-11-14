using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> gameObjectsTarget;
    public List<GameObject> gameObjectsPoint;
    [SerializeField] private Transform parentListObjTaget;
    [SerializeField] private Transform parentListObjPoint;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        foreach (Transform tr in parentListObjTaget)
        {
            gameObjectsTarget.Add(tr.gameObject);
        }
        foreach (Transform tr in parentListObjPoint)
        {
            gameObjectsPoint.Add(tr.gameObject);
        }
    }

    public void RemoveObject(GameObject obj)
    {
        gameObjectsPoint.Remove(obj);
        if (canCheck)
        {
            if (gameObjectsPoint.Count == 0)
            {
                GameManager.Instance.CheckLevelUp();
                canCheck = false;
            }
        }
    }
    
    public void RemoveObjectTarget(GameObject obj)
    {
        gameObjectsTarget.Remove(obj);
    }
}

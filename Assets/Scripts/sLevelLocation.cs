using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sLevelLocation : MonoBehaviour
{
    [SerializeField] private TextMeshPro levelCountLabel;
    [SerializeField] private BoxCollider boxDetector;

    private int levelCount;
    private sSceneController sceneController;
    private sMascotController mascot;

    private void Start()
    {
        //get scene controller reference
        sceneController = FindFirstObjectByType<sSceneController>();

        //get Mascot Reference
        mascot = FindFirstObjectByType<sMascotController>();

        //setting the level count from the scene controller
        levelCount = sceneController.GetCurrentLevel();
    }

    //Sets the level number on the 3D viewports
    public void SetLevelCount(int count)
    {
        levelCountLabel.text = count.ToString();
        levelCount = count;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        if(collision.gameObject.CompareTag("Mascot"))
        {
            if(sceneController.GetCurrentLevel()>1)
            {
                sceneController.NewLevelReached();
                Debug.Log("New Level");
            }
            Debug.Log("Level 1");
        }
    }
}
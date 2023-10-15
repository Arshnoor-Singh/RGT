using UnityEngine;
using UnityEngine.Splines;

public class sMascotController : MonoBehaviour
{
    [SerializeField] private SplineAnimate mascotSplineAnimate;
    
    //Variable for Character Speed on Spline
    public float movementSpeed = 20;

    private SplineContainer currentSpline;
    private SplineContainer nextSpline;

    private void Awake()
    {
        //mascotSplineAnimate.Pause();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentSpline = mascotSplineAnimate.Container;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function will be called by the SceneController when the player will have to move
    public void MoveMascot()
    {
        mascotSplineAnimate.Play();
    }

    public void ChangeMascotSpline()
    {
        mascotSplineAnimate.Container = nextSpline;
    }
}

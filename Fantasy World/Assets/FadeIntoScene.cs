using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeIntoScene : MonoBehaviour
{
    public string nextLevel;
    public CanvasGroup overlay;
    // Set this to the Canvas Object in the Editor
    public float transitionSpeed;
    // May want to slow down the transition, set this to below 1 to slow
    private bool warping = false;

    private void Awake()
    {
        overlay.alpha = 0;
    }
    void Update()
    {
        if (BedCheck.hitBed == true || warping == true)
        // If the Player has set the Door Trigger or you are already warping
        {
            warping = true;// Note you are now warping
            overlay.alpha = overlay.alpha + Time.deltaTime * transitionSpeed; // Gradually change the Opacity each time this is run
        }
        if (overlay.alpha >= 1) // if its fully opaque
        {
            SceneManager.LoadScene(nextLevel); // Change Scene
        }
    }

}
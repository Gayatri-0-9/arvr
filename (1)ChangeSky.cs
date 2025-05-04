using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSky : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string currentscenename;
    string dayscenename = "day";
    string nightscenename = "night";
    void Start()
    {
        currentscenename = SceneManager.GetActiveScene().name;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentscenename == dayscenename)
            {
                SceneManager.LoadScene(nightscenename);
            }
            if (currentscenename == nightscenename)
            {
                SceneManager.LoadScene(dayscenename);
            }
        }
    }
}
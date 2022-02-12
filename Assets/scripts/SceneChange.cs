using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
     Ray ray;
     RaycastHit hit;
 
     void Update()
     {
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))
         {
             if (hit.collider.name == "d21") 
             {
                 SceneManager.LoadScene("play1");
             }
             if (hit.collider.name == "d22") 
             {
                 SceneManager.LoadScene("play1");
             }
             if (hit.collider.name == "d3") 
             {
                 SceneManager.LoadScene("play2");
             }
             if (hit.collider.name == "d41") 
             {
                 SceneManager.LoadScene("play3");
             }
             if (hit.collider.name == "d42") 
             {
                 SceneManager.LoadScene("play3");
             }
             if (hit.collider.name == "d51") 
             {
                 SceneManager.LoadScene("play4");
             }
             if (hit.collider.name == "d52") 
             {
                 SceneManager.LoadScene("play4");
             }
         }
     }
 }

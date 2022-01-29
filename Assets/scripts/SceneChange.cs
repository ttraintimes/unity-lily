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
             if (hit.collider.name == "d2") 
             {
                 SceneManager.LoadScene("play1");
             }
             if (hit.collider.name == "d2(1)") 
             {
                 SceneManager.LoadScene("play1");
             }
             if (hit.collider.name == "d3") 
             {
                 SceneManager.LoadScene("play2");
             }
             if (hit.collider.name == "d4") 
             {
                 SceneManager.LoadScene("play3");
             }
             if (hit.collider.name == "d4(1)") 
             {
                 SceneManager.LoadScene("play3");
             }
             if (hit.collider.name == "d5") 
             {
                 SceneManager.LoadScene("play4");
             }
             if (hit.collider.name == "d5(1)") 
             {
                 SceneManager.LoadScene("play4");
             }
         }
     }
 }

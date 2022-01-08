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
             if (hit.collider.name == "planet1") 
             {
                 SceneManager.LoadScene("BODYBOX");
             }
         }
     }
 }

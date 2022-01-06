using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class CountDown : MonoBehaviour {
 
	public GameObject timeLabel;//时间显示UI
	public int sumTime;//总时间 单位 秒
 
    public GameObject gameOver;//显示的图片
 
	void Start () {
		StartCoroutine ("countDown");
	}
	
 
	public IEnumerator countDown()
	{
	
		while (sumTime>=0) {
 
			if (sumTime >0) {
				timeLabel.GetComponent<Text> ().text = sumTime.ToString ();
				yield return new WaitForSeconds (1);
				sumTime--;
 
			}
			if (sumTime<=10) {
				
                gameOver.SetActive(true);//显示图片
			}
				
			else if(sumTime==0){
					gameOver.SetActive(false);
		
			yield break;
 	}
		
 
 
		}
	
	
	}
}
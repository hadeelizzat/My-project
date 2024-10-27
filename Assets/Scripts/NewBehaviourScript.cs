using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
      void Start()
    {
      //assignment1
      while (true){
        int randomNo=Random.Range(1,21);
      if(randomNo==5) continue;
      else if (randomNo==15) break;
        Debug.Log(randomNo);
      
      }
      //assignment2
      string[] array ={"cat","dog","car","pizza","hat","fish","tree","monkey","ball","brid"};
      string funnySentence="";
      int counter=0;
      while(counter<7){
      int index= Random.Range(0,10);
      funnySentence+=" "+array[index];
      counter++;
      }
      Debug.Log(funnySentence);

      
  
    }

}

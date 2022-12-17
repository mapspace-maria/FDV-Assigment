using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

   public Player player;
   public Renderer[] rd;
   
   private void Start()
   {
     player.OnMovement += MoveParallax;
   }

    private void MoveParallax(Vector3 movebg)

    {
        for(int i = 0; i < rd.Length; i++)
        {
                rd[i].material.SetTextureOffset("_MainTex", rd[i].material.GetTextureOffset("_MainTex") + (0.001f * (Vector2) movebg) / (i+0.05f));
        }

    }
        
    }

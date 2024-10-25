using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using life;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;
 
namespace minecrafttools{
    //Llamada para inicializar items y rasgos 
    [ModEntry]
    class Main : MonoBehaviour{
        #region
        public static Main instance;
        #endregion
        internal static Harmony harmony;
        //cada funcion se la llama aqui para inicializarla
        void Awake(){
         Debug.Log($"{Mod.Info.Name} loaded!");
         Debug.Log("Mod Made by ModMaker");
         TraitGroup.init();
         Traits.init();
         Items.init();
        }
    }
}

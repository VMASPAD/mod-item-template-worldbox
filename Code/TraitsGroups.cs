using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;
 
namespace minecrafttools
{
    class TraitGroup
    {
 
 
        public static void init()
        {
        //Generated by ModMaker
 
        }
        //Agrega las imagenes de forma interna para poder acceder desde el juego
        private static void addTraitGroupToLocalizedLibrary(string id, string name)
        {
            string language = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "language") as string;
            Dictionary<string, string> localizedText = Reflection.GetField(LocalizedTextManager.instance.GetType(), LocalizedTextManager.instance, "localizedText") as Dictionary<string, string>;
            localizedText.Add("trait_group_" + id, name);
        }
    }
}

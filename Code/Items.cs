using System;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;

namespace minecrafttools
{
    class Items
    {
        public static void init()
        {
 
          craftitems();
     
             //ESPADA DE MADERA
          ItemAsset WOODENSWORD = AssetManager.items.clone("WOODENSWORD", "sword");
          WOODENSWORD.id = "WOODENSWORD";
          WOODENSWORD.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
            //Los que digan que si solo tienen que cambiar el valor despues del = y el f significa porcentaje (%) luego si quieren agregar mas tienen que seguir la misma estructura
            WOODENSWORD.materials = List.Of<string>(new string[]{"wood"});
          WOODENSWORD.base_stats[S.fertility] = 0.0f;//SI
          WOODENSWORD.base_stats[S.max_children] = 0f; //SI
          WOODENSWORD.base_stats[S.max_age] = 0f;//SI
          WOODENSWORD.base_stats[S.attack_speed] = 0; //SI
          WOODENSWORD.base_stats[S.damage] = 4; //SI
          WOODENSWORD.base_stats[S.speed] = 0f; //SI
            WOODENSWORD.base_stats[S.health] = 0; //SI
            WOODENSWORD.base_stats[S.accuracy] = 0f; //SI
            WOODENSWORD.base_stats[S.range] = 0; //SI
            WOODENSWORD.base_stats[S.armor] = 0; //SI
            WOODENSWORD.base_stats[S.scale] = 0.0f; //SI
            WOODENSWORD.base_stats[S.dodge] = 0f; //SI
            WOODENSWORD.base_stats[S.targets] = 0f; //SI
            WOODENSWORD.base_stats[S.critical_chance] = 0.0f; //SI
            WOODENSWORD.base_stats[S.knockback] = 0.0f; //SI
            WOODENSWORD.base_stats[S.knockback_reduction] = 0.0f; //SI
            WOODENSWORD.base_stats[S.intelligence] = 0; //SI
            WOODENSWORD.base_stats[S.warfare] = 0; //SI
            WOODENSWORD.base_stats[S.diplomacy] = 0; //SI
            WOODENSWORD.base_stats[S.stewardship] = 0; //SI
            WOODENSWORD.base_stats[S.opinion] = 0f; //SI
            WOODENSWORD.base_stats[S.loyalty_traits] = 0f; //SI
            WOODENSWORD.base_stats[S.cities] = 0; //SI
            WOODENSWORD.base_stats[S.zone_range] = 0; //SI
            WOODENSWORD.equipment_value = 100;//SI
            WOODENSWORD.quality = ItemQuality.Normal;//SI
            //Los NO no los cambien a menos que aparezca un mensaje de lo que se debe cambiar
            WOODENSWORD.path_slash_animation = "effects/slashes/slash_sword";//NO
            WOODENSWORD.tech_needed = "weapon_sword";//NO Se supone la tecnologia necesaria
            WOODENSWORD.equipmentType = EquipmentType.Weapon;//NO Tipo de armadura
            WOODENSWORD.name_class = "item_class_weapon";//NO Clase de item
            WOODENSWORD.action_special_effect = new WorldAction(NoneRegularAction);//NO Effecto de ataque Especial
            WOODENSWORD.action_attack_target = new AttackAction(NoneAttackSomeoneAction);//NO Effecto de ataque
            AssetManager.items.list.AddItem(WOODENSWORD);//Añade el item
            Localization.addLocalization("item_WOODENSWORD", "MINECRAFT WODDEN SWORD");//NO
            addWeaponsSprite(WOODENSWORD.id, WOODENSWORD.materials[0]);//NO


            //Luego veran que el sistema se repite en cada item ya que solo hay que declarar los mismo o diferentes valores
            //De todas formas esta en cada uno explorar lo que se puede hacer

            //ESPADA DE PIEDRA
            ItemAsset stonesword = AssetManager.items.clone("stonesword", "sword");
          stonesword.id = "stonesword";
          stonesword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          stonesword.materials = List.Of<string>(new string[]{"stone"});
          stonesword.base_stats[S.fertility] = 0.0f;
          stonesword.base_stats[S.max_children] = 0f;
          stonesword.base_stats[S.max_age] = 0f;
          stonesword.base_stats[S.attack_speed] = 0;
          stonesword.base_stats[S.damage] = 10;
          stonesword.base_stats[S.speed] = 0f;
          stonesword.base_stats[S.health] = 0;
          stonesword.base_stats[S.accuracy] = 0f;
          stonesword.base_stats[S.range] = 0;
          stonesword.base_stats[S.armor] = 0;
          stonesword.base_stats[S.scale] = 0.0f;
          stonesword.base_stats[S.dodge] = 0f;
          stonesword.base_stats[S.targets] = 0f;
          stonesword.base_stats[S.critical_chance] = 0.0f;
          stonesword.base_stats[S.knockback] = 0.0f;
          stonesword.base_stats[S.knockback_reduction] = 0.0f;
          stonesword.base_stats[S.intelligence] = 0;
          stonesword.base_stats[S.warfare] = 0;
          stonesword.base_stats[S.diplomacy] = 0;
          stonesword.base_stats[S.stewardship] = 0;
          stonesword.base_stats[S.opinion] = 0f;
          stonesword.base_stats[S.loyalty_traits] = 0f;
          stonesword.base_stats[S.cities] = 0;
          stonesword.base_stats[S.zone_range] = 0;
          stonesword.equipment_value = 200;
          stonesword.quality = ItemQuality.Normal;
          stonesword.path_slash_animation = "effects/slashes/slash_sword";
          stonesword.tech_needed = "weapon_sword";
          stonesword.equipmentType = EquipmentType.Weapon;
          stonesword.name_class = "item_class_weapon";
          stonesword.action_special_effect = new WorldAction(NoneRegularAction);
          stonesword.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
          AssetManager.items.list.AddItem(stonesword);
          Localization.addLocalization("item_stonesword", "stone sword from minecraft");
          addWeaponsSprite(stonesword.id, stonesword.materials[0]);
 
  //ESPADA DE HIERRO
          ItemAsset ironsword = AssetManager.items.clone("ironsword", "sword");
          ironsword.id = "ironsword";
          ironsword.name_templates = Toolbox.splitStringIntoList(new string[]
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"
          });
          ironsword.materials = List.Of<string>(new string[]{"iron"});
          ironsword.base_stats[S.fertility] = 0.0f;
          ironsword.base_stats[S.max_children] = 0f;
          ironsword.base_stats[S.max_age] = 0f;
          ironsword.base_stats[S.attack_speed] = 0;
          ironsword.base_stats[S.damage] = 20;
          ironsword.base_stats[S.speed] = 0f;
          ironsword.base_stats[S.health] = 0;
          ironsword.base_stats[S.accuracy] = 0f;
          ironsword.base_stats[S.range] = 0;
          ironsword.base_stats[S.armor] = 0;
          ironsword.base_stats[S.scale] = 0.0f;
          ironsword.base_stats[S.dodge] = 0f;
          ironsword.base_stats[S.targets] = 0f;
          ironsword.base_stats[S.critical_chance] = 0.0f;
          ironsword.base_stats[S.knockback] = 0.0f;
          ironsword.base_stats[S.knockback_reduction] = 0.0f;
          ironsword.base_stats[S.intelligence] = 0;
          ironsword.base_stats[S.warfare] = 0;
          ironsword.base_stats[S.diplomacy] = 0;
          ironsword.base_stats[S.stewardship] = 0;
          ironsword.base_stats[S.opinion] = 0f;
          ironsword.base_stats[S.loyalty_traits] = 0f;
          ironsword.base_stats[S.cities] = 0;
          ironsword.base_stats[S.zone_range] = 0;
          ironsword.equipment_value = 400;
          ironsword.quality = ItemQuality.Rare;
          ironsword.path_slash_animation = "effects/slashes/slash_sword";
          ironsword.tech_needed = "weapon_production";
          ironsword.equipmentType = EquipmentType.Weapon;
          ironsword.name_class = "item_class_weapon";
          ironsword.action_special_effect = new WorldAction(NoneRegularAction);
          ironsword.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
          AssetManager.items.list.AddItem(ironsword);
          Localization.addLocalization("item_ironsword", "iron sword from minecraft");
          addWeaponsSprite(ironsword.id, ironsword.materials[0]);
//ARMADURA DE HIERRO CASCO
          ItemAsset ic = AssetManager.items.clone("IronChestPlate", "_equipment");
          ic.id = "IronChestPlate";
          ic.base_stats[S.armor] = 17;
          ic.base_stats[S.dodge] = 5f;
          ic.base_stats[S.knockback_reduction] = 5f;
          ic.equipment_value = 400;
          ic.quality = ItemQuality.Rare;
          ic.tech_needed = "armor_production";
          ic.equipmentType = EquipmentType.Armor;
          ic.name_class = "item_class_armor";
          AssetManager.items.list.AddItem(ic);
          Localization.addLocalization("item_IronChestPlate", "iron chestplate");
//ARMADURA DE HIERRO PETO
          ItemAsset ir = AssetManager.items.clone("IronHelmet", "_equipment");
          ir.id = "IronHelmet";
          ir.base_stats[S.armor] = 17;
          ir.equipment_value = 400;
          ir.quality = ItemQuality.Rare;
          ir.tech_needed = "armor_production";
          ir.equipmentType = EquipmentType.Helmet;
          ir.name_class = "item_class_armor";
          AssetManager.items.list.AddItem(ir);
          Localization.addLocalization("item_IronHelmet", "iron helmet");
//ARMADURA DE HIERRO BOTAS
          ItemAsset ib = AssetManager.items.clone("IronBoots", "_equipment");
          ib.id = "IronBoots";
          ib.base_stats[S.armor] = 17;
          ib.equipment_value = 400;
          ib.quality = ItemQuality.Rare;
          ib.tech_needed = "armor_production";
          ib.equipmentType = EquipmentType.Boots;
          ib.name_class = "item_class_boots";
          AssetManager.items.list.AddItem(ib);
          Localization.addLocalization("item_IronBoots", "iron boots");

//ESPADA DE DIAMANTE
          ItemAsset dis = AssetManager.items.clone("DiamondSword", "sword");
          dis.id = "DiamondSword";
          dis.name_templates = Toolbox.splitStringIntoList(new string []
          {
        "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"     
          });
          dis.materials = List.Of<string>(new string []{"mythril"});
          dis.base_stats[S.damage] = 70;
          dis.base_stats[S.knockback] = 5f;
          dis.equipmentType = EquipmentType.Weapon;
          dis.equipment_value = 500;
          dis.quality = ItemQuality.Epic;
          dis.path_slash_animation = "effects/slashes/slash_sword";
          dis.name_class = "item_class_weapon";
          dis.tech_needed = "weapon_production";
          AssetManager.items.list.AddItem(dis);
          Localization.addLocalization("item_DiamondSword", "DiamondSword");
          addWeaponsSprite(dis.id, dis.materials[0]);

          ItemAsset die = AssetManager.items.clone("DiamondChestPlate","_equipment");
          die.id = "DiamondChestPlate";
          die.base_stats[S.armor] = 20;
          die.base_stats[S.knockback_reduction] = 20f;
          die.equipment_value = 500;
          die.quality = ItemQuality.Epic;
          die.tech_needed = "armor_production";
          die.equipmentType = EquipmentType.Armor;
          die.name_class = "item_class_armor";
          AssetManager.items.list.AddItem(die);
          Localization.addLocalization("item_DiamondChestPlate", "DiamondChestPlate");

          ItemAsset diaHelment = AssetManager.items.clone("DiamondHelmet", "_equipment");
          diaHelment.id = "DiamondHelmet";
          diaHelment.base_stats[S.armor] = 20;
          diaHelment.equipment_value = 500;
          diaHelment.quality = ItemQuality.Epic;
          diaHelment.tech_needed = "armor_production";
          diaHelment.equipmentType = EquipmentType.Helmet;
          diaHelment.name_class = "item_class_helmet";
          AssetManager.items.list.AddItem(diaHelment);
          Localization.addLocalization("item_DiamondHelmet", "DiamondHelmet");

          ItemAsset diaBoots = AssetManager.items.clone("DiamondBoots", "_equipment");
          diaBoots.id = "DiamondBoots";
          diaBoots.base_stats[S.armor] = 20;
          diaBoots.equipment_value = 500;
          diaBoots.quality = ItemQuality.Epic;
          diaBoots.tech_needed = "armor_production";
          diaBoots.equipmentType = EquipmentType.Boots;
          diaBoots.name_class = "item_class_boots";
          AssetManager.items.list.AddItem(diaBoots);
          Localization.addLocalization("item_DiamondBoots", "DiamondBoots");

//TRIDENTE
          ItemAsset trident = AssetManager.items.clone("trident", "bow");
          trident.id = "trident";
          trident.projectile = "trident";
          trident.name_templates = Toolbox.splitStringIntoList(new string []
          {
          "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          trident.materials = List.Of<string>(new string []{"mythril"});
          trident.base_stats[S.damage] = 80;
          trident.base_stats[S.range] = 20;
          trident.base_stats[S.attack_speed] = 12;
          trident.equipment_value = 900;
          trident.quality = ItemQuality.Legendary;
          trident.equipmentType = EquipmentType.Weapon;
          trident.path_slash_animation = "effects/slashes/slash_bow";
          trident.tech_needed = "weapon_production";
          AssetManager.items.list.AddItem(trident);
          Localization.addLocalization("item_trident", "trident");
          addWeaponsSprite(trident.id, trident.materials[0]);

          ItemAsset Mace = AssetManager.items.clone("Mace", "hammer");
          Mace.id = "Mace";
          Mace.name_templates = Toolbox.splitStringIntoList(new string[]
          {
           "sword_name#30",
          "sword_name_king#3",
          "weapon_name_city",
          "weapon_name_kingdom",
          "weapon_name_culture",
          "weapon_name_enemy_king",
          "weapon_name_enemy_kingdom"    
          });
          Mace.materials = List.Of<string>(new string []{"steel"});
          Mace.base_stats[S.damage] = 100;
          Mace.base_stats[S.speed] = -10f;
          Mace.base_stats[S.attack_speed] = -10;
          Mace.base_stats[S.damage_range] = 20f;
          Mace.equipment_value = 900;
          Mace.quality = ItemQuality.Legendary;
          Mace.equipmentType = EquipmentType.Weapon;
          Mace.path_slash_animation = "effects/slashes/slash_hammer";
          Mace.tech_needed = "weapon_production";
          AssetManager.items.list.AddItem(Mace);
          Localization.addLocalization("item_Mace", "Mace");
          addWeaponsSprite(Mace.id, Mace.materials[0]);

 
      
 //Funcion para que las civilizaciones puedan craftear las armas
          static void craftitems() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");

          ProjectileAsset trident = new ProjectileAsset();
          trident.id = "trident";
          trident.texture = "trident";
          trident.trailEffect_enabled = true;
          trident.look_at_target = true;
          trident.parabolic = false;
          trident.looped = true;
          trident.speed = 18f;
          trident.texture_shadow = "pr_freeze_orb";
          trident.sound_launch = "event:/SFX/WEAPONS/WeaponFreezeOrbStart";
          trident.sound_impact = "event:/SFX/WEAPONS/WeaponFreezeOrbLand";
          AssetManager.projectiles.add(trident);
 
 
        
 
         }
 
        }
        public static bool NoneAttackSomeoneAction(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneRegularAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneGetAttackedAction(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneDeathAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
        
 
            }
            //Añade los sprite de las armas
            static void addWeaponsSprite(string id, string material)
            {
              var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
              var sprite = Resources.Load<Sprite>("Weapons/w_" + id + "_" + material);
              dictItems.Add(sprite.name, sprite);
            }
        }
    }

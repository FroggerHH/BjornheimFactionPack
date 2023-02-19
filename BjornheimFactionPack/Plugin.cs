using BepInEx;
using HarmonyLib;
using ItemManager;
using PieceManager;

namespace BjornheimFactionPack
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        #region values
        private const string ModName = "BjornheimFactionPack", ModVersion = "0.0.19", ModGUID = "com.Frogger." + ModName;
        private static readonly Harmony harmony = new(ModGUID);
        public static Plugin _self;
        #endregion

        private void Awake()
        {
            _self = this;

            #region baners
            BuildPiece.ConfigurationEnabled = false;
            #region banner1
            /*BuildPiece banner1 = new("scribex", "Banner1");
            banner1.Name
                .English("Balrogs Banner")
                .Russian("Знамя Балрогов")
                .Romanian("Balrogs Banner");
            banner1.Description
                .English("Balrogs Banner")
                .Russian("Знамя Балрогов")
                .Romanian("Balrogs Banner");
            banner1.RequiredItems.Add("Wood", 6, true);
            banner1.RequiredItems.Add("Raspberry", 5, true);
            banner1.RequiredItems.Add("MushroomYellow", 2, true);
            banner1.RequiredItems.Add("Coal", 1, true);
            banner1.Crafting.Set(PieceManager.CraftingTable.Workbench);
            banner1.Category.Add(BuildPieceCategory.Furniture);
            MaterialReplacer.RegisterGameObjectForShaderSwap(banner1.Prefab, MaterialReplacer.ShaderType.UseUnityShader);*/
            #endregion 
            #region banner2
            BuildPiece banner2 = new("scribex", "Banner2");
            banner2.Name
                .English("Blidhr Artificers Banner")
                .Russian("Знамя Блидхрских мастеров");
            banner2.Description
                .English("Blidhr Artificers Banner")
                .Russian("Знамя Блидхрских мастеров");
            banner2.RequiredItems.Add("Wood", 6, true);
            banner2.RequiredItems.Add("Blueberries", 5, true);
            banner2.RequiredItems.Add("MushroomYellow", 2, true);
            banner2.RequiredItems.Add("Coal", 1, true);
            banner2.Crafting.Set(PieceManager.CraftingTable.Workbench);
            banner2.Category.Add(BuildPieceCategory.Furniture);
            MaterialReplacer.RegisterGameObjectForShaderSwap(banner2.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region banner3
            BuildPiece banner3 = new("scribex", "Banner3");
            banner3.Name
                .English("Hounds of Hel Banner")
                .Russian("Знамя Берсерков Ньерда");
            banner3.Description
                .English("Njord's Berserkers Banner")
                .Russian("Знамя Берсерков Ньерда");
            banner3.RequiredItems.Add("Wood", 6, true);
            banner3.RequiredItems.Add("BoneFragments", 5, true);
            banner3.RequiredItems.Add("Bloodbag", 2, true);
            banner3.RequiredItems.Add("Coal", 1, true);
            banner3.Crafting.Set(PieceManager.CraftingTable.Workbench);
            banner3.Category.Add(BuildPieceCategory.Furniture);
            MaterialReplacer.RegisterGameObjectForShaderSwap(banner3.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region banner4
            BuildPiece banner4 = new("scribex", "Banner4");
            banner4.Name
                .English("Eyes of Fenrir Banner")
                .Russian("Знамя Глаз Фенрира")
                .Romanian("Ochii lui Fenrir Banner");
            banner4.Description
                .English("Eyes of Fenrir Banner")
                .Russian("Знамя Глаз Фенрира")
                .Romanian("Ochii lui Fenrir Banner");
            banner4.RequiredItems.Add("Wood", 6, true);
            banner4.RequiredItems.Add("BoneFragments", 5, true);
            banner4.RequiredItems.Add("Blueberries", 1, true);
            banner4.RequiredItems.Add("Coal", 2, true);
            banner4.Crafting.Set(PieceManager.CraftingTable.Workbench);
            banner4.Category.Add(BuildPieceCategory.Furniture);
            MaterialReplacer.RegisterGameObjectForShaderSwap(banner4.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region banner5
            BuildPiece banner5 = new("scribex", "Banner5");
            banner5.Name
                .English("Ravens Banner")
                .Russian("Знамя Воронов")
                .Romanian("Corbii Banner");
            banner5.Description
                .English("Ravens Banner")
                .Russian("Знамя Воронов")
                .Romanian("Corbii Banner");
            banner5.RequiredItems.Add("Wood", 6, true);
            banner5.RequiredItems.Add("MushroomYellow", 5, true);
            banner5.RequiredItems.Add("Ooze", 1, true);
            banner5.RequiredItems.Add("Coal", 2, true);
            banner5.Crafting.Set(PieceManager.CraftingTable.Workbench);
            banner5.Category.Add(BuildPieceCategory.Furniture);
            MaterialReplacer.RegisterGameObjectForShaderSwap(banner5.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #endregion

            #region Capes
            #region cape1
            /*Item cape1 = new("scribex", "Cape1");
            cape1.Name
                .English("Balrogs Cape")
                .Russian("Плащ Балрогов")
                .Romanian("Mantia lui Balrog");
            cape1.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape1.CraftAmount = 1;
            cape1.RequiredItems.Add("Silver", 2);
            cape1.RequiredItems.Add("LoxPelt", 2);
            cape1.RequiredItems.Add("Bloodbag", 5);
            cape1.RequiredItems.Add("MushroomYellow", 2);
            cape1.RequiredUpgradeItems.Add("Silver", 2);
            cape1.RequiredUpgradeItems.Add("LoxPelt", 2);
            //cape1.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape1.Prefab, MaterialReplacer.ShaderType.UseUnityShader);*/
            #endregion
            #region cape2
            Item cape2 = new("scribex", "Cape2");
            cape2.Name
                .English("Hounds of Hel Cape")
                .Russian("Плащ Берсерков Ньерда");
            cape2.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape2.CraftAmount = 1;
            cape2.RequiredItems.Add("Silver", 2);
            cape2.RequiredItems.Add("LoxPelt", 6);
            cape2.RequiredItems.Add("Coal", 2);
            cape2.RequiredItems.Add("Bloodbag", 5);
            cape2.RequiredUpgradeItems.Add("Silver", 1);
            cape2.RequiredUpgradeItems.Add("LoxPelt", 3);
            //cape2.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape2.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape3
            Item cape3 = new("scribex", "Cape3");
            cape3.Name
                .English("Eyes of Fenrir Cape")
                .Russian("Плащ Глаз Фенрира")
                .Romanian("Ochii pelerinei Fenrir");

            cape3.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape3.CraftAmount = 1;
            cape3.RequiredItems.Add("Silver", 2);
            cape3.RequiredItems.Add("LoxPelt", 6);
            cape3.RequiredItems.Add("Mushroom", 2);
            cape3.RequiredItems.Add("BoneFragments", 5);
            cape3.RequiredUpgradeItems.Add("Silver", 1);
            cape3.RequiredUpgradeItems.Add("LoxPelt", 3);
            //cape3.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape3.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape4
            Item cape4 = new("scribex", "Cape4");
            cape4.Name
                .English("Blidhr Artificers Cape")
                .Russian("Плащ Блидхрских мастеров");
            cape4.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape4.CraftAmount = 1;
            cape4.RequiredItems.Add("Silver", 2);
            cape4.RequiredItems.Add("LoxPelt", 6);
            cape4.RequiredItems.Add("Blueberries", 5);
            cape4.RequiredItems.Add("Coal", 2);
            cape4.RequiredUpgradeItems.Add("Silver", 2);
            cape4.RequiredUpgradeItems.Add("LoxPelt", 3);
            //cape4.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape4.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape5
            Item cape5 = new("scribex", "Cape5");
            cape5.Name
                .English("Ravens Cape")
                .Russian("Воронов плащ")
                .Romanian("Ravens Cape");
            cape5.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape5.CraftAmount = 1;
            cape5.RequiredItems.Add("Silver", 2);
            cape5.RequiredItems.Add("LoxPelt", 6);
            cape5.RequiredItems.Add("Resin", 2);
            cape5.RequiredItems.Add("MushroomYellow", 5);
            cape5.RequiredUpgradeItems.Add("Silver", 1);
            cape5.RequiredUpgradeItems.Add("LoxPelt", 3);
            //cape5.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape5.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape6
            Item cape6 = new("scribex", "Cape6");
            cape6.Name
                .English("Ravens Deer Cape")
                .Russian("Воронов олений плащ")
                .Romanian("Ravens Deer Cape");
            cape6.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape6.CraftAmount = 1;
            cape6.RequiredItems.Add("DeerHide", 4);
            cape6.RequiredItems.Add("BoneFragments", 5);
            cape6.RequiredItems.Add("MushroomYellow", 5);
            cape6.RequiredItems.Add("Resin", 2);
            cape6.RequiredUpgradeItems.Add("DeerHide", 4);
            cape6.RequiredUpgradeItems.Add("BoneFragments", 5);
            //cape6.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape6.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape7
            Item cape7 = new("scribex", "Cape7");
            cape7.Name
                .English("Hounds of Hel Deer Cape")
                .Russian("Олений плащ Берсерков Ньерда")
                .Romanian("Njord's Berserkers Deer Cape");
            cape7.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape7.CraftAmount = 1;
            cape7.RequiredItems.Add("DeerHide", 4);
            cape7.RequiredItems.Add("BoneFragments", 5);
            cape7.RequiredItems.Add("Coal", 2);
            cape7.RequiredItems.Add("Raspberry", 5);
            cape7.RequiredUpgradeItems.Add("DeerHide", 4);
            cape7.RequiredUpgradeItems.Add("BoneFragments", 5);
            //cape7.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape7.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion 
            #region cape8
            /*Item cape8 = new("scribex", "Cape8");
            cape8.Name
                .English("Balrogs Deer Cape")
                .Russian("Олений плащ Балрогов")
                .Romanian("Balrogs Deer Cape");
            cape8.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape8.CraftAmount = 1;
            cape8.RequiredItems.Add("DeerHide", 4);
            cape8.RequiredItems.Add("BoneFragments", 5);
            cape8.RequiredItems.Add("Raspberry", 5);
            cape8.RequiredItems.Add("MushroomYellow", 2); ;
            cape8.RequiredUpgradeItems.Add("DeerHide", 4);
            cape8.RequiredUpgradeItems.Add("BoneFragments", 5);
            //cape8.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape8.Prefab, MaterialReplacer.ShaderType.UseUnityShader);*/
            #endregion
            #region cape9
            Item cape9 = new("scribex", "Cape9");
            cape9.Name
                .English("Blidhr Artificers Deer Cape")
                .Russian("Олений плащ Блидхрских мастеров");
            cape9.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape9.CraftAmount = 1;
            cape9.RequiredItems.Add("DeerHide", 4);
            cape9.RequiredItems.Add("BoneFragments", 5);
            cape9.RequiredItems.Add("Resin", 2);
            cape9.RequiredItems.Add("Blueberries", 5);
            cape9.RequiredUpgradeItems.Add("DeerHide", 4);
            cape9.RequiredUpgradeItems.Add("BoneFragments", 5);
            //cape9.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape9.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape10
            Item cape10 = new("scribex", "Cape10");
            cape10.Name
                .English("Eyes of Fenrir Deer Cape")
                .Russian("Олений плащ Глаз Фенрира")
                .Romanian("Eyes of Fenrir Deer Cape");
            cape10.Crafting.Add(ItemManager.CraftingTable.Workbench, 2);
            cape10.CraftAmount = 1;
            cape10.RequiredItems.Add("DeerHide", 4);
            cape10.RequiredItems.Add("BoneFragments", 10);
            cape10.RequiredItems.Add("Mushroom", 2);
            cape10.RequiredUpgradeItems.Add("DeerHide", 4);
            cape10.RequiredUpgradeItems.Add("BoneFragments", 5);
            //cape10.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape10.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion

            #region cape11
            /*Item cape11 = new("scribex", "Cape11");
            cape11.Name
                .English("Balrogs Raven Cape")
                .Russian("Вороний плащ Балрогов");
            cape11.Crafting.Add("piece_magetable", 1);
            cape11.CraftAmount = 1;
            cape11.RequiredItems.Add("Feathers", 10);
            cape11.RequiredItems.Add("ScaleHide", 5);
            cape11.RequiredItems.Add("Eitr", 20);
            cape11.RequiredItems.Add("Bloodbag", 5);
            cape11.RequiredUpgradeItems.Add("Feathers", 2);
            cape11.RequiredUpgradeItems.Add("ScaleHide", 5);
            cape11.RequiredUpgradeItems.Add("Eitr", 3);
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape11.Prefab, MaterialReplacer.ShaderType.UseUnityShader);*/
            #endregion
            #region cape12
            Item cape12 = new("scribex", "Cape12");
            cape12.Name
                .English("Hounds of Hel Raven Cape")
                .Russian("Вороний плащ Берсерков Ньерда");
            cape12.Crafting.Add("piece_magetable", 1);
            cape12.CraftAmount = 1;
            cape12.RequiredItems.Add("Feathers", 10);
            cape12.RequiredItems.Add("ScaleHide", 5);
            cape12.RequiredItems.Add("Eitr", 20);
            cape12.RequiredItems.Add("Bloodbag", 5);
            cape12.RequiredUpgradeItems.Add("Feathers", 2);
            cape12.RequiredUpgradeItems.Add("ScaleHide", 5);
            cape12.RequiredUpgradeItems.Add("Eitr", 3);

            MaterialReplacer.RegisterGameObjectForShaderSwap(cape12.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape13
            Item cape13 = new("scribex", "Cape13");
            cape13.Name
                .English("Eyes of Fenrir Raven Cape")
                .Russian("Вороний плащ Глаз Фенрира");
            cape13.Crafting.Add("piece_magetable", 1);
            cape13.CraftAmount = 1;
            cape13.RequiredItems.Add("Feathers", 10);
            cape13.RequiredItems.Add("ScaleHide", 5);
            cape13.RequiredItems.Add("Eitr", 20);
            cape13.RequiredItems.Add("Flint", 5);
            cape13.RequiredUpgradeItems.Add("Feathers", 2);
            cape13.RequiredUpgradeItems.Add("ScaleHide", 5);
            cape13.RequiredUpgradeItems.Add("Eitr", 3);
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape13.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape14
            Item cape14 = new("scribex", "Cape14");
            cape14.Name
                .English("Blidhr Artificers Raven Cape")
                .Russian("Вороний плащ Блидхрских мастеров");
            cape14.Crafting.Add("piece_magetable", 1);
            cape14.CraftAmount = 1;
            cape14.RequiredItems.Add("Feathers", 10);
            cape14.RequiredItems.Add("ScaleHide", 5);
            cape14.RequiredItems.Add("Eitr", 20);
            cape14.RequiredItems.Add("Blueberries", 5);
            cape14.RequiredUpgradeItems.Add("Feathers", 2);
            cape14.RequiredUpgradeItems.Add("ScaleHide", 5);
            cape14.RequiredUpgradeItems.Add("Eitr", 3);
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape14.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region cape15
            Item cape15 = new("scribex", "Cape15");
            cape15.Name
                .English("Ravens Raven Cape")
                .Russian("Вороний плащ Воронов");
            cape15.Crafting.Add("piece_magetable", 1);
            cape15.CraftAmount = 1;
            cape15.RequiredItems.Add("Feathers", 10);
            cape15.RequiredItems.Add("ScaleHide", 5);
            cape15.RequiredItems.Add("Eitr", 20);
            cape15.RequiredItems.Add("MushroomYellow", 5);
            cape15.RequiredUpgradeItems.Add("Feathers", 2);
            cape15.RequiredUpgradeItems.Add("ScaleHide", 5);
            cape15.RequiredUpgradeItems.Add("Eitr", 3);
            MaterialReplacer.RegisterGameObjectForShaderSwap(cape15.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #endregion

            #region Shields
            #region shield1
            /*Item shield1 = new("scribex", "Shield1");
            shield1.Name
                .English("Balrogs Shield")
                .Russian("Щит Балрогов")
                .Romanian("Balrogs Shield");
            shield1.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield1.CraftAmount = 1;
            shield1.RequiredItems.Add("FineWood", 10);
            shield1.RequiredItems.Add("Iron", 8);
            shield1.RequiredItems.Add("Bloodbag", 5);
            //shield1.RequiredItems.Add("Resin", 2);
            shield1.RequiredUpgradeItems.Add("FineWood", 10);
            shield1.RequiredUpgradeItems.Add("Iron", 4);
            shield1.RequiredUpgradeItems.Add("Chain", 2);
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield1.Prefab, MaterialReplacer.ShaderType.VegetationShader);*/
            #endregion
            #region shield2
            Item shield2 = new("scribex", "Shield2");
            shield2.Name
                .English("Hounds of Hel Shield")
                .Russian("Щит Берсерков Ньерда");
            shield2.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield2.CraftAmount = 1;
            shield2.RequiredItems.Add("FineWood", 10);
            shield2.RequiredItems.Add("Iron", 8);
            shield2.RequiredItems.Add("Coal", 2);
            shield2.RequiredItems.Add("Bloodbag", 5);
            shield2.RequiredUpgradeItems.Add("FineWood", 10);
            shield2.RequiredUpgradeItems.Add("Iron", 4);
            //shield2.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield2.Prefab, MaterialReplacer.ShaderType.VegetationShader);
            #endregion
            #region shield3
            Item shield3 = new("scribex", "Shield3");
            shield3.Name
                .English("Eyes of Fenrir Shield")
                .Russian("Щит Глаз Фенрира")
                .Romanian("Ochii lui Fenrir Shield");
            shield3.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield3.CraftAmount = 1;
            shield3.RequiredItems.Add("FineWood", 10);
            shield3.RequiredItems.Add("Iron", 8);
            shield3.RequiredItems.Add("BoneFragments", 5);
            //shield3.RequiredItems.Add("Mushroom", 2);
            shield3.RequiredUpgradeItems.Add("FineWood", 10);
            shield3.RequiredUpgradeItems.Add("Iron", 4);
            shield3.RequiredUpgradeItems.Add("Chain", 2);
            //shield3.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield3.Prefab, MaterialReplacer.ShaderType.VegetationShader);
            #endregion
            #region shield4
            Item shield4 = new("scribex", "Shield4");
            shield4.Name
                .English("Blidhr Artificers Shield")
                .Russian("Щит Блидхрских мастеров")
                .Romanian("Scutul șerpilor lui Loki");
            shield4.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield4.CraftAmount = 1;
            shield4.RequiredItems.Add("FineWood", 10);
            shield4.RequiredItems.Add("Iron", 8);
            shield4.RequiredItems.Add("Blueberries", 5);
            //shield4.RequiredItems.Add("MushroomYellow", 2);
            shield4.RequiredUpgradeItems.Add("FineWood", 10);
            shield4.RequiredUpgradeItems.Add("Iron", 4);
            shield4.RequiredUpgradeItems.Add("Chain", 2);
            //shield4.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield4.Prefab, MaterialReplacer.ShaderType.VegetationShader);
            #endregion
            #region shield5
            Item shield5 = new("scribex", "Shield5");
            shield5.Name
                .English("Ravens Shield")
                .Russian("Щит Воронов")
                .Romanian("Scutul Corbilor");
            shield5.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield5.CraftAmount = 1;
            shield5.RequiredItems.Add("FineWood", 10);
            shield5.RequiredItems.Add("Iron", 8);
            shield5.RequiredItems.Add("MushroomYellow", 5);
            //shield5.RequiredItems.Add("Resin", 2);
            shield5.RequiredUpgradeItems.Add("FineWood", 10);
            shield5.RequiredUpgradeItems.Add("Iron", 4);
            shield5.RequiredUpgradeItems.Add("Chain", 2);
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield5.Prefab, MaterialReplacer.ShaderType.VegetationShader);
            #endregion
            //blackMetal
            #region ShieldBlackBarlorgs
            /*Item shield6 = new("scribex", "ShieldBlackBarlorgs");
            shield6.Name
                .English("Barlorgs BlackMetal Shield")
                .Russian("Щит из чёрного металла Балрогов")
                .Romanian("Barlorgs BlackMetal Shield");
            shield6.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield6.CraftAmount = 1;
            shield6.RequiredItems.Add("FineWood", 10);
            shield6.RequiredItems.Add("BlackMetal", 8);
            shield6.RequiredItems.Add("Chain", 5);
            shield6.RequiredItems.Add("Bloodbag", 5);
            shield6.RequiredUpgradeItems.Add("FineWood", 10);
            shield6.RequiredUpgradeItems.Add("BlackMetal", 4);
            shield6.RequiredUpgradeItems.Add("Chain", 2);
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield6.Prefab, MaterialReplacer.ShaderType.UseUnityShader);*/
            #endregion
            #region ShieldBlackNjord
            Item shield7 = new("scribex", "ShieldBlackNjord");
            shield7.Name
                .English("Hounds of Hel BlackMetal Shield")
                .Russian("Щит из чёрного металла Берсерков Ньерда")
                .Romanian("Njord's Berserkers BlackMetal Shield");
            shield7.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield7.CraftAmount = 1;
            shield7.RequiredItems.Add("FineWood", 10);
            shield7.RequiredItems.Add("BlackMetal", 8);
            shield7.RequiredItems.Add("Chain", 5);
            shield7.RequiredItems.Add("Bloodbag", 5);
            shield7.RequiredUpgradeItems.Add("FineWood", 10);
            shield7.RequiredUpgradeItems.Add("BlackMetal", 4);
            shield7.RequiredUpgradeItems.Add("Chain", 2);
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield7.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldBlackFenrri
            Item shield8 = new("scribex", "ShieldBlackFenrri");
            shield8.Name
                .English("Eyes of Fenrir BlackMetal Shield")
                .Russian("Щит из чёрного металла Глаз Фенрира")
                .Romanian("Eyes of Fenrir BlackMetal Shield");
            shield8.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield8.CraftAmount = 1;
            shield8.RequiredItems.Add("FineWood", 10);
            shield8.RequiredItems.Add("BlackMetal", 8);
            shield8.RequiredItems.Add("Chain", 5);
            shield8.RequiredItems.Add("BoneFragments", 5);
            shield8.RequiredUpgradeItems.Add("FineWood", 10);
            shield8.RequiredUpgradeItems.Add("BlackMetal", 4);
            shield8.RequiredUpgradeItems.Add("Chain", 2);
            //shield8.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield8.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldBlackLokisse
            Item shield9 = new("scribex", "ShieldBlackLokisse");
            shield9.Name
                .English("Blidhr Artificers BlackMetal Shield")
                .Russian("Щит из чёрного металла Блидхрских мастеров");
            shield9.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield9.CraftAmount = 1;
            shield9.RequiredItems.Add("FineWood", 10);
            shield9.RequiredItems.Add("BlackMetal", 8);
            shield9.RequiredItems.Add("Chain", 5);
            shield9.RequiredItems.Add("Blueberries", 5);
            shield9.RequiredUpgradeItems.Add("FineWood", 10);
            shield9.RequiredUpgradeItems.Add("BlackMetal", 4);
            shield9.RequiredUpgradeItems.Add("Chain", 2);
            //shield9.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield9.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldBlackRavens
            Item shield10 = new("scribex", "ShieldBlackRavens");
            shield10.Name
                .English("Ravens BlackMetal Shield")
                .Russian("Щит из чёрного металла Воронов")
                .Romanian("Ravens BlackMetal Shield");
            shield10.Crafting.Add(ItemManager.CraftingTable.Forge, 2);
            shield10.CraftAmount = 1;
            shield10.RequiredItems.Add("FineWood", 10);
            shield10.RequiredItems.Add("BlackMetal", 8);
            shield10.RequiredItems.Add("Chain", 5);
            shield10.RequiredItems.Add("MushroomYellow", 5);
            shield10.RequiredUpgradeItems.Add("FineWood", 10);
            shield10.RequiredUpgradeItems.Add("BlackMetal", 4);
            shield10.RequiredUpgradeItems.Add("Chain", 2);
            //shield10.Snapshot();
            MaterialReplacer.RegisterGameObjectForShaderSwap(shield10.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion

            //Carapace
            #region ShieldCarapace2
            Item ShieldCarapace2 = new("scribex", "ShieldCarapace2");
            ShieldCarapace2.Name
                .English("Blidhr Artificers Carapace Shield")
                .Russian("Панцирный щит мастеров Блидхра");
            ShieldCarapace2.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            ShieldCarapace2.CraftAmount = 1;
            ShieldCarapace2.RequiredItems.Add("Carapace", 20);
            ShieldCarapace2.RequiredItems.Add("ScaleHide", 3);
            ShieldCarapace2.RequiredItems.Add("Eitr", 10);
            ShieldCarapace2.RequiredItems.Add("Blueberries", 5);
            ShieldCarapace2.RequiredUpgradeItems.Add("Carapace", 10);
            ShieldCarapace2.RequiredUpgradeItems.Add("ScaleHide", 1);
            ShieldCarapace2.RequiredUpgradeItems.Add("Eitr", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(ShieldCarapace2.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldCarapace3
            Item ShieldCarapace3 = new("scribex", "ShieldCarapace3");
            ShieldCarapace3.Name
                .English("Hounds of Hel Carapace Shield")
                .Russian("Панцирный щит Гончих Ада");
            ShieldCarapace3.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            ShieldCarapace3.CraftAmount = 1;
            ShieldCarapace3.RequiredItems.Add("Carapace", 20);
            ShieldCarapace3.RequiredItems.Add("ScaleHide", 3);
            ShieldCarapace3.RequiredItems.Add("Eitr", 10);
            ShieldCarapace3.RequiredItems.Add("Bloodbag", 5);
            ShieldCarapace3.RequiredUpgradeItems.Add("Carapace", 10);
            ShieldCarapace3.RequiredUpgradeItems.Add("ScaleHide", 1);
            ShieldCarapace3.RequiredUpgradeItems.Add("Eitr", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(ShieldCarapace3.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldCarapace4
            Item ShieldCarapace4 = new("scribex", "ShieldCarapace4");
            ShieldCarapace4.Name
                .English("Eyes of Fenrir Carapace Shield")
                .Russian("Панцирный щит Глаз Фенрира");
            ShieldCarapace4.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            ShieldCarapace4.CraftAmount = 1;
            ShieldCarapace4.RequiredItems.Add("Carapace", 20);
            ShieldCarapace4.RequiredItems.Add("ScaleHide", 3);
            ShieldCarapace4.RequiredItems.Add("Eitr", 10);
            ShieldCarapace4.RequiredItems.Add("BoneFragments", 5);
            ShieldCarapace4.RequiredUpgradeItems.Add("Carapace", 10);
            ShieldCarapace4.RequiredUpgradeItems.Add("ScaleHide", 1);
            ShieldCarapace4.RequiredUpgradeItems.Add("Eitr", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(ShieldCarapace4.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region ShieldCarapace5
            Item ShieldCarapace5 = new("scribex", "ShieldCarapace5");
            ShieldCarapace5.Name
                .English("Ravens Carapace Shield")
                .Russian("Панцирный щит Воронов");
            ShieldCarapace5.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            ShieldCarapace5.CraftAmount = 1;
            ShieldCarapace5.RequiredItems.Add("Carapace", 20);
            ShieldCarapace5.RequiredItems.Add("ScaleHide", 3);
            ShieldCarapace5.RequiredItems.Add("Eitr", 10);
            ShieldCarapace5.RequiredItems.Add("MushroomYellow", 5);
            ShieldCarapace5.RequiredUpgradeItems.Add("Carapace", 10);
            ShieldCarapace5.RequiredUpgradeItems.Add("ScaleHide", 1);
            ShieldCarapace5.RequiredUpgradeItems.Add("Eitr", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(ShieldCarapace5.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion

            #endregion

            #region Hood
            #region HelmetMage2
            Item HelmetMage2 = new("scribex", "HelmetMage2");
            HelmetMage2.Name
                .English("Blidhr Artificers Eitr-Hood")
                .Russian("Сшитый из Эйтра капюшон Блидхрских мастеров");
            HelmetMage2.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            HelmetMage2.CraftAmount = 1;
            HelmetMage2.RequiredItems.Add("LinenThread", 16);
            HelmetMage2.RequiredItems.Add("Eitr", 20);
            HelmetMage2.RequiredItems.Add("Iron", 2);
            HelmetMage2.RequiredItems.Add("Blueberries", 5);
            HelmetMage2.RequiredUpgradeItems.Add("LinenThread", 9);
            HelmetMage2.RequiredUpgradeItems.Add("Eitr", 10);
            HelmetMage2.RequiredUpgradeItems.Add("Iron", 1);
            MaterialReplacer.RegisterGameObjectForShaderSwap(HelmetMage2.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region HelmetMage3
            Item HelmetMage3 = new("scribex", "HelmetMage3");
            HelmetMage3.Name
                .English("Hounds of Hel Eitr-Hood")
                .Russian("Сшитый из Эйтра капюшон Псов Ада");
            HelmetMage3.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            HelmetMage3.CraftAmount = 1;
            HelmetMage3.RequiredItems.Add("LinenThread", 16);
            HelmetMage3.RequiredItems.Add("Eitr", 15);
            HelmetMage3.RequiredItems.Add("Iron", 2);
            HelmetMage3.RequiredItems.Add("Bloodbag", 5);
            HelmetMage3.RequiredUpgradeItems.Add("LinenThread", 9);
            HelmetMage3.RequiredUpgradeItems.Add("Eitr", 8);
            HelmetMage3.RequiredUpgradeItems.Add("Iron", 1);
            MaterialReplacer.RegisterGameObjectForShaderSwap(HelmetMage3.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region HelmetMage4
            Item HelmetMage4 = new("scribex", "HelmetMage4");
            HelmetMage4.Name
                .English("Eyes of Fenrir Eitr-Hood")
                .Russian("Сшитый из Эйтра капюшон Глаз Фенрира");
            HelmetMage4.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            HelmetMage4.CraftAmount = 1;
            HelmetMage4.RequiredItems.Add("LinenThread", 16);
            HelmetMage4.RequiredItems.Add("Eitr", 15);
            HelmetMage4.RequiredItems.Add("Iron", 2);
            HelmetMage4.RequiredItems.Add("BoneFragments", 5);
            HelmetMage4.RequiredUpgradeItems.Add("LinenThread", 9);
            HelmetMage4.RequiredUpgradeItems.Add("Eitr", 10);
            HelmetMage4.RequiredUpgradeItems.Add("Iron", 1);
            MaterialReplacer.RegisterGameObjectForShaderSwap(HelmetMage4.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region HelmetMage5
            Item HelmetMage5 = new("scribex", "HelmetMage5");
            HelmetMage5.Name
                .English("Ravens Eitr-Hood")
                .Russian("Сшитый из Эйтра капюшон Воронов");
            HelmetMage5.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            HelmetMage5.CraftAmount = 1;
            HelmetMage5.RequiredItems.Add("LinenThread", 16);
            HelmetMage5.RequiredItems.Add("Eitr", 15);
            HelmetMage5.RequiredItems.Add("Iron", 2);
            HelmetMage5.RequiredItems.Add("MushroomYellow", 5);
            HelmetMage5.RequiredUpgradeItems.Add("LinenThread", 9);
            HelmetMage5.RequiredUpgradeItems.Add("Eitr", 8);
            HelmetMage5.RequiredUpgradeItems.Add("Iron", 1);
            MaterialReplacer.RegisterGameObjectForShaderSwap(HelmetMage5.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #endregion

            #region Robe
            #region MageChest2
            Item MageChest2 = new("scribex", "MageChest2");
            MageChest2.Name
                .English("Blidhr Artificers Eitr-weave robe")
                .Russian("Сшитое из Эйтра одеяние Блидхрских мастеров");
            MageChest2.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            MageChest2.CraftAmount = 1;
            MageChest2.RequiredItems.Add("LinenThread", 20);
            MageChest2.RequiredItems.Add("Eitr", 20);
            MageChest2.RequiredItems.Add("ScaleHide", 10);
            MageChest2.RequiredItems.Add("Blueberries", 10);
            MageChest2.RequiredUpgradeItems.Add("LinenThread", 10);
            MageChest2.RequiredUpgradeItems.Add("Eitr", 10);
            MageChest2.RequiredUpgradeItems.Add("ScaleHide", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(MageChest2.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region MageChest3
            Item MageChest3 = new("scribex", "MageChest3");
            MageChest3.Name
                .English("Hounds of Hel Eitr-weave robe")
                .Russian("Сшитое из Эйтра одеяние Псов Ада");
            MageChest3.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            MageChest3.CraftAmount = 1;
            MageChest3.RequiredItems.Add("LinenThread", 20);
            MageChest3.RequiredItems.Add("Eitr", 20);
            MageChest3.RequiredItems.Add("ScaleHide", 10);
            MageChest3.RequiredItems.Add("Bloodbag", 10);
            MageChest3.RequiredUpgradeItems.Add("LinenThread", 10);
            MageChest3.RequiredUpgradeItems.Add("Eitr", 10);
            MageChest3.RequiredUpgradeItems.Add("ScaleHide", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(MageChest3.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region MageChest4
            Item MageChest4 = new("scribex", "MageChest4");
            MageChest4.Name
                .English("Eyes of Fenrir Eitr-weave robe")
                .Russian("Сшитое из Эйтра одеяние Глаз Фенрира");
            MageChest4.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            MageChest4.CraftAmount = 1;
            MageChest4.RequiredItems.Add("LinenThread", 20);
            MageChest4.RequiredItems.Add("Eitr", 20);
            MageChest4.RequiredItems.Add("ScaleHide", 10);
            MageChest4.RequiredItems.Add("BoneFragments", 10);
            MageChest4.RequiredUpgradeItems.Add("LinenThread", 10);
            MageChest4.RequiredUpgradeItems.Add("Eitr", 10);
            MageChest4.RequiredUpgradeItems.Add("ScaleHide", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(MageChest4.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #region MageChest5
            Item MageChest5 = new("scribex", "MageChest5");
            MageChest5.Name
                .English("Ravens  Eitr-weave robe")
                .Russian("Сшитое из Эйтра одеяние Воронов");
            MageChest5.Crafting.Add(ItemManager.CraftingTable.BlackForge, 2);
            MageChest5.CraftAmount = 1;
            MageChest5.RequiredItems.Add("LinenThread", 20);
            MageChest5.RequiredItems.Add("Eitr", 20);
            MageChest5.RequiredItems.Add("ScaleHide", 10);
            MageChest5.RequiredItems.Add("MushroomYellow", 10);
            MageChest5.RequiredUpgradeItems.Add("LinenThread", 10);
            MageChest5.RequiredUpgradeItems.Add("Eitr", 10);
            MageChest5.RequiredUpgradeItems.Add("ScaleHide", 5);
            MaterialReplacer.RegisterGameObjectForShaderSwap(MageChest5.Prefab, MaterialReplacer.ShaderType.UseUnityShader);
            #endregion
            #endregion

            harmony.PatchAll();
        }
    }
}
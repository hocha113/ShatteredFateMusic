using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace ShatteredFateMusic
{
	public class SFMusic : Mod
	{
		//TODO...
	}

    public abstract class SceneMusicLoaden : ModSceneEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => !ModLoader.HasMod("ShatteredFate");
    }

    public class BloodMoonMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/BloodMoon");
        public override bool IsSceneEffectActive(Player player) => Main.bloodMoon;
    }

    public class BrainMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/BrainOfCthulhu");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.BrainofCthulhu);
    }

    public class EOWMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/EaterOfWorlds");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.EaterofWorldsHead);
    }

    public class EyeMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/EyeOfCthulhu");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.EyeofCthulhu);
    }

    public class MushroomMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/GlowingMushroomBiome");
        public override bool IsSceneEffectActive(Player player) => player.ZoneGlowshroom;
    }

    public class KingSlimeMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/KingSlime");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.KingSlime);
    }

    public class QueenBeeMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/QueenBee");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.QueenBee);
    }

    public class QueenSlimeMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/QueenSlime");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.QueenSlimeBoss);
    }

    public class SkeletronMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/Skeletron");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.SkeletronHead);
    }

    public class SkeletronPrimeMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/SkeletronPrime");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.SkeletronPrime);
    }

    public class SnowLegionMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/SnowLegion");
        public override bool IsSceneEffectActive(Player player) => Main.invasionType == InvasionID.SnowLegion;
    }

    public class CorruptionMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TheCorruption");
        public override bool IsSceneEffectActive(Player player) => player.ZoneCorrupt;
    }

    public class CrimsonMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TheCrimson");
        public override bool IsSceneEffectActive(Player player) => player.ZoneCrimson;
    }

    public class DestroyerMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TheDestroyer");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.TheDestroyer);
    }

    public class HallowMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TheHallow");
        public override bool IsSceneEffectActive(Player player) => player.ZoneHallow;
    }

    public class TwinsMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TheTwins");
        public override bool IsSceneEffectActive(Player player) => (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism));
    }

    public class TorchGodMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/TorchGod");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.TorchGod);
    }

    public class WOFMusic : SceneMusicLoaden
    {
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/Vanilla/WallOfFlesh");
        public override bool IsSceneEffectActive(Player player) => NPC.AnyNPCs(NPCID.WallofFlesh);
    }
}

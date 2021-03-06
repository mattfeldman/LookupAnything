﻿using StardewValley;

namespace Pathoschild.LookupAnything.Framework.Data
{
    /// <summary>Constant values hardcoded by the game.</summary>
    internal class ConstantData
    {
        /*********
        ** Accessors
        *********/
        /****
        ** Farm animals
        ****/
        /// <summary>The number of friendship points per level for a farm animal.</summary>
        /// <remarks>Derived from <see cref="FarmAnimal.dayUpdate"/>.</remarks>
        public int AnimalFriendshipPointsPerLevel { get; set; }

        /// <summary>The maximum number of friendship points for a farm animal.</summary>
        /// <remarks>Derived from <see cref="FarmAnimal.dayUpdate"/>.</remarks>
        public int AnimalFriendshipMaxPoints { get; set; }

        /// <summary>The maximum happiness points for a farm animal.</summary>
        /// <remarks>Derived from <see cref="FarmAnimal.dayUpdate"/>.</remarks>
        public int AnimalMaxHappiness { get; set; }

        /****
        ** NPCs
        ****/
        /// <summary>The names of villagers with social data (e.g. birthdays or gift tastes).</summary>
        public string[] AsocialVillagers { get; set; }

        /****
        ** Players
        ****/
        /// <summary>The maximum experience points for a skill.</summary>
        /// <remarks>Derived from <see cref="Farmer.checkForLevelGain"/>.</remarks>
        public int PlayerMaxSkillPoints { get; set; }

        /// <summary>The experience points needed for each skill level.</summary>
        /// <remarks>Derived from <see cref="Farmer.checkForLevelGain"/>.</remarks>
        public int[] PlayerSkillPointsPerLevel { get; set; }

        /****
        ** Time
        ****/
        /// <summary>The number of days in each season.</summary>
        public int DaysInSeason { get; set; }

        /// <summary>The fractional rate at which fences decay (calculated as minutes divided by this value).</summary>
        /// <remarks>Derived from <see cref="Fence.minutesElapsed"/>.</remarks>
        public float FenceDecayRate { get; set; }
    }
}

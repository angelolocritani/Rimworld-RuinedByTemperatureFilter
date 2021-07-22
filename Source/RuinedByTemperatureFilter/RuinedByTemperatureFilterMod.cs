using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using RimWorld;
using UnityEngine;
using Verse;

namespace RuinedByTemperatureFilter
{
    public class RuinedByTemperatureFilterMod : Mod
    {
        public RuinedByTemperatureFilterMod(ModContentPack content) : base(content) { }
    }
    public class SpecialThingFilterWorker_RuinedByTemperature : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t) => CanEverMatch(t.def) && t.TryGetComp<CompTemperatureRuinable>().Ruined;

        public override bool CanEverMatch(ThingDef def) => def.IsEgg && def.HasComp(typeof(CompTemperatureRuinable));

      
    }

    public class SpecialThingFilterWorker_NotRuinedByTemperature : SpecialThingFilterWorker
    {
        public override bool Matches(Thing t) => CanEverMatch(t.def) && !t.TryGetComp<CompTemperatureRuinable>().Ruined;

        public override bool CanEverMatch(ThingDef def) => def.IsEgg && def.HasComp(typeof(CompTemperatureRuinable));


    }
}

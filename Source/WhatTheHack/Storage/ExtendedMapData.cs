using Verse;
using WhatTheHack.Buildings;

namespace WhatTheHack.Storage;

public class ExtendedMapData : IExposable
{
    public Building_RogueAI rogueAI;

    // Is this getting an id that matches the rogueAI?
    public void ExposeData()
    {
        Scribe_References.Look(ref rogueAI, "rogueAI");
    }
}
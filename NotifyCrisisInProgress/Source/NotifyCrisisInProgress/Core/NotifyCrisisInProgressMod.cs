using Verse;

namespace NotifyCrisisInProgress.Core
{
    // Scaffold, created 2026-08-29. Loads and does nothing else - there is
    // no agreed behaviour for this mod yet, only a name. See
    // ncip-architecture.md in the repo root.
    //
    // RimWorld constructs one instance of this per load, passing the
    // ModContentPack. The log line is the only thing here, and it exists so
    // "did the scaffold actually load" is answerable without guessing.
    public class NotifyCrisisInProgressMod : Mod
    {
        public NotifyCrisisInProgressMod(ModContentPack content) : base(content)
        {
            Log.Message("[NotifyCrisisInProgress] Loaded (scaffold - no behaviour yet).");
        }
    }
}

global using Mod = RealFlamethrowers.Mod;

namespace RealFlamethrowers;

public sealed class Mod : Verse.Mod
{
    public static Mod Instance { get; private set; }
    public Mod(ModContentPack content) : base(content)
    {
        Instance = this;
    }
    public void OnStartup()
    {
        foreach(var patch in Content.Patches)
        {
            var file = System.IO.Path.GetFileNameWithoutExtension(patch.sourceFile);
            Log.Message($"[{nameof(RealFlamethrowers)}] {file} is patched.");
        }
    }
}

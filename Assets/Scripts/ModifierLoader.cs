using UnityEngine;

public static class ModifierLoader
{
    public static float GetSpawnHeight()
    {
        TextAsset txt = Resources.Load<TextAsset>("modifier");
        if (txt == null) return 1f;

        foreach (string line in txt.text.Split('\n'))
        {
            if (line.StartsWith("spawn_height="))
            {
                float.TryParse(line.Split('=')[1], out float value);
                return value;
            }
        }
        return 1f;
    }
}

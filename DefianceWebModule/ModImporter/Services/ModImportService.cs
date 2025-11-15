using System.Text.Json;
using ModImporter.Interfaces;

namespace ModImporter.Services;

public class ModImportService : IModImporter
{
    private readonly string _configFile = "target_folders.json";
    public async Task ImportAsync()
    {
        if (!File.Exists(_configFile))
        {
            Console.WriteLine($"Configuration file '{_configFile}' not found.");
            return;
        }

        var jsonText = await File.ReadAllTextAsync(_configFile);
        var targetFolders = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonText);

        if (targetFolders == null || targetFolders.Count == 0)
        {
            Console.WriteLine("No target folders defined in the configuration file.");
            return;
        }

        // Assumes ModImporter project is at DefianceWebModule/ModImporter/ - kido was here
        var repoRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
        Console.WriteLine($"Detected repository root: {repoRoot}");

        var allFiles = new Dictionary<string, List<string>>();

        foreach (var kvp in targetFolders)
        {
            var category = kvp.Key;
            var relativePath = kvp.Value;

            var absolutePath = Path.Combine(repoRoot, relativePath);

            if (!Directory.Exists(absolutePath))
            {
                Console.WriteLine($"Warning: Folder '{absolutePath}' for category '{category}' does not exist.");
                allFiles[category] = new List<string>();
                continue;
            }


            var files = Directory.GetFiles(absolutePath, "*.xml", SearchOption.AllDirectories).ToList();

            if (category.Equals("ebps", StringComparison.OrdinalIgnoreCase))
            {
                files = files.Where(f => f.Replace('\\', '/').Contains("/races/")).ToList();
            }

            allFiles[category] = files;

            Console.WriteLine($"Found {files.Count} XML files for category '{category}'.");
        }

        // TODO: Convert files to JSON and call backend API
        Console.WriteLine("Scanning complete. Ready for parsing and API call.");
    }
}

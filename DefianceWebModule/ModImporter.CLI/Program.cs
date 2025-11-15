using ModImporter;
using ModImporter.Services;

class Program
{
    static async Task<int> Main(string[] args)
    {
        try
        {
            var importer = new ModImportService();
            await importer.ImportAsync();
            Console.WriteLine("Import completed successfully.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Import failed:");
            Console.WriteLine(ex.Message);
            return -1;
        }
    }
}

using InlineChatApp;

class Program
{
    static async Task Main()
    {
        var processor = new FileProcessor();

        try
        {
            string testFile = "test.csv";

            Console.WriteLine("=== File Processor Demo ===\n");

            // Create test data
            var testData = new List<Dictionary<string, string>>
            {
                new() { { "Name", "Alice" }, { "Age", "30" } },
                new() { { "Name", "Bob" }, { "Age", "25" } },
            };

            await processor.WriteCsvFileAsync(testFile, testData);
            Console.WriteLine($"✓ Created test CSV file");

            var count = await processor.CountLinesAsync(testFile);
            Console.WriteLine($"✓ File has {count} lines");

            var data = await processor.ReadCsvFileAsync(testFile);
            Console.WriteLine($"✓ Read {data.Count} records");

            var json = await processor.ConvertCsvToJsonAsync(testFile);
            Console.WriteLine($"✓ Converted to JSON:\n{json}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

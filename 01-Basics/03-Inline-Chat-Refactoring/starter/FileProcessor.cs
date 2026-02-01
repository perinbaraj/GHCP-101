namespace InlineChatApp;

using System.Text.Json;

/// <summary>
/// Processes CSV and JSON files for data transformation and analysis.
/// </summary>
public class FileProcessor
{
    public async Task<List<Dictionary<string, string>>> ReadCsvFileAsync(string filePath)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        var headers = lines[0].Split(',');
        var data = new List<Dictionary<string, string>>();

        for (int i = 1; i < lines.Length; i++)
        {
            var values = lines[i].Split(',');
            var row = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                row[headers[j]] = values[j];
            }
            data.Add(row);
        }
        return data;
    }

    public async Task WriteCsvFileAsync(string filePath, List<Dictionary<string, string>> data)
    {
        if (data.Count == 0) return;

        var headers = data[0].Keys.ToArray();
        var lines = new List<string> { string.Join(",", headers) };

        foreach (var row in data)
        {
            var values = headers.Select(h => row[h]);
            lines.Add(string.Join(",", values));
        }

        await File.WriteAllLinesAsync(filePath, lines);
    }

    public async Task<int> CountLinesAsync(string filePath)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        return lines.Length;
    }

    public async Task<List<string>> FilterLinesAsync(string filePath, Func<string, bool> predicate)
    {
        var lines = await File.ReadAllLinesAsync(filePath);
        return lines.Where(predicate).ToList();
    }

    public async Task<string> ConvertCsvToJsonAsync(string csvFilePath)
    {
        var data = await ReadCsvFileAsync(csvFilePath);
        return JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
    }
}

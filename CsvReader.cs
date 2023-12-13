// CsvReader.cs
using System.Collections.Generic;
using System.IO;

public class CsvReader
{
    private readonly string _filePath;

    public CsvReader(string filePath)
    {
        _filePath = filePath;
    }

    public IEnumerable<string[]> ReadNextBatch(int batchSize)
    {
        using var reader = new StreamReader(_filePath);
        while (!reader.EndOfStream)
        {
            for (int i = 0; i < batchSize && !reader.EndOfStream; i++)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    yield return line.Split(',');
                }
            }

            yield break;
        }
    }
}

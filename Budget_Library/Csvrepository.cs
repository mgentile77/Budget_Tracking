using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Budget_Library
{
    public static class Csvrepository
    {
        public static List <T> Csv_read <T> (string filename)
        {
            var fileBasePath = AppDomain.CurrentDomain.BaseDirectory;
            var filepath = Path.Combine (fileBasePath, filename + ".csv");
            if (File.Exists (filepath))
            {
                using var reader = new StreamReader(filepath);
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = header => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(header.Header)
                };
                using var csv = new CsvReader(reader, config);
                return csv.GetRecords<T>().ToList();
            }
            return new List<T>();
        }
        public static void Csv_write<T>(List<T> records,string filename, FileMode filemode, bool writeHeader)
        {
            var fileBasePath = AppDomain.CurrentDomain.BaseDirectory;
            var filepath = Path.Combine(fileBasePath, filename + ".csv");
            using var stream = File.Open(filepath, filemode);
            using var writer = new StreamWriter(stream);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = writeHeader
            };
            using var csv = new CsvWriter(writer, config);
            csv.WriteRecords<T>(records);
        }
        public static void savecsv<T>(List<T> records, string filename)
        {
            var fileBasePath = AppDomain.CurrentDomain.BaseDirectory;
            var filepath = Path.Combine(fileBasePath, filename + ".csv");
            Csv_write(records, filename, FileMode.Append, !File.Exists(filepath));
        }
        public static void removecsv<T>(List<T> records, string filename)
        {
            Csv_write(records, filename, FileMode.Truncate, true);
        }
    }
}

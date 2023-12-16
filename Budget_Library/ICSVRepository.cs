namespace Budget_Library
{
    public interface ICSVRepository
    {
        List<T> Csv_read<T>(string filename);
        void removecsv<T>(List<T> records, string filename);
        void savecsv<T>(List<T> records, string filename);
    }
}
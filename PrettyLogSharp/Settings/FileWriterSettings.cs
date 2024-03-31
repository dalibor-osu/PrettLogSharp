namespace PrettyLogSharp.Settings;

public class FileWriterSettings
{
    public bool SaveToFile { get; set; } = true;
    public string SaveDirectoryPath { get; init; } = "./logs/";
    public string LogFileNameFormat { get; init; } = "yyyy-MM-dd";
    public string LogFileTimestampFormat { get; init; } = "yyyy-MM-dd HH:mm:ss:fff";
    public bool KeepLogFileOpen { get; init; } = false;
    public bool UseUtc { get; init; } = false;
}
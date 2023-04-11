using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class BankTransferConfig
{
    public Config config;
    public const string filePath = @"bank_transfer_config.json";
    public BankTransferConfig()
    {
        try
        {
            ReadConfigFile();
        }
        catch (Exception)
        {
            SetDefault();
            WriteConfigFile();
        }
    }

    public Config ReadConfigFile()
    {
        string configJsonData = File.ReadAllText(filePath);
        config = JsonSerializer.Deserialize<Config>(configJsonData);
        return config;
    }

    public void SetDefault()
    {
        Console.WriteLine("default");
    }

    public void WriteConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filePath, jsonString);
    }

    public void UbahBahasa()
    {
        if (config.lang == "en")
        {
            config.lang = "id";
        }
        else if (config.lang == "id")
        {
            config.lang = "en";
        }
    }
}

public class Config
{
    public string lang { get; set; }
    public transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public confirmation confirmation { get; set; }

    public Config() { }

    public Config(string lang, transfer transfer, List<string> methods, confirmation confirmation)
    {
        this.lang = lang;
        this.transfer = transfer;
        this.methods = methods;
        this.confirmation = confirmation;
    }
}

public class transfer
{
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }

    public transfer() { }

    public transfer(int threshold, int low_fee, int high_fee)
    {
        this.threshold = threshold;
        this.low_fee = low_fee;
        this.high_fee = high_fee;
    }
}

public class confirmation
{
    public string en { get; set; }
    public string id { get; set; }

    public confirmation() { }

    public confirmation(string en, string id)
    {
        this.en = en;
        this.id = id;
    }
}
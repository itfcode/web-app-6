// See https://aka.ms/new-console-template for more information
using ITFCodeWA.Data.Health.Documents;
using ITFCodeWA.Helper.DataCollector.Data;
using ITFCodeWA.Helper.DataCollector.Factories;
using ITFCodeWA.Models.Documents;
using Newtonsoft.Json;

Console.WriteLine("ITFCodeWA.Helper.DataCollector: Hello, World!");

var registrators = new List<WeightRegistratorModel>();

var weightData = new Dictionary<DateTimeOffset, decimal>();

foreach (var row in WeightData.Rows.Split("\n"))
{
    var data = row.Trim().Split("\t");

    if (data.Length > 1)
    {
        DateTimeOffset.TryParse(data[0], out DateTimeOffset date);
        decimal.TryParse(data[1], out decimal weight);

        weightData.Add(date, weight);

        Console.WriteLine($"{date} => {weight}");
    }
}

var groupingByYear = weightData.GroupBy(x => x.Key.Year)
    .ToDictionary(x => x.Key, x => x.ToList());

foreach (var yearData in groupingByYear)
{
    Console.WriteLine($"{yearData.Key}");
    var groupingByMonth = yearData.Value.GroupBy(x => x.Key.Month);
    foreach (var monthData in groupingByMonth)
    {
        Console.WriteLine($"\t{monthData.Key}");
        foreach (var item in monthData)
        {
            Console.WriteLine($"\t\t{item.Key}\t{item.Value} ");
        }

        registrators.Add(
            WeightRegistratorModelFactory.Create(
                registrators.Count + 1000, 
                new DateTime(yearData.Key, monthData.Key, 1), 
                monthData.ToDictionary(x=>x.Key, y=>y.Value)));
    }
}

Console.WriteLine($"Registrators Count = {registrators.Count}");

var filePath = @"C:\projects\personal\net6\itfcode.web-app-6\projects\ITFCodeWA.InitialData\Data\Health\Weight\WeightRegistration.json";

if (File.Exists(filePath))
    Console.WriteLine("ФАЙЛ ДАННХ УЖЕ СУЩЕСТВУЕТ");
else
    File.WriteAllText(filePath, JsonConvert.SerializeObject(registrators));

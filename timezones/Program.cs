
using System.Collections.ObjectModel;

//ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();


//foreach (var item in timeZones)
//{

//    if ( item.DisplayName.Contains("Costa Rica"))
//    {
//        Console.WriteLine(item.Id);
//        //Console.WriteLine(item.DisplayName);
//        //Console.WriteLine(item.StandardName);
//    }

//}


sofnomic.timezones.GetUTC GetUTC = new sofnomic.timezones.GetUTC();

Console.WriteLine(GetUTC.getUTC(DateTime.Now));
Console.WriteLine(GetUTC.shortconvert(DateTime.Now));
Console.ReadKey();


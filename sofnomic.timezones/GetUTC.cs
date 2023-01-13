using System;
namespace sofnomic.timezones
{
    public class GetUTC
    {
        public DateTimeOffset getUTC(DateTime date)
        {


            //convert date to timezona of current server without lost timeoffset
            DateTimeOffset timeOffsetOfReceived = new DateTimeOffset(date,
                TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id)
                                          .GetUtcOffset(date));

            //get zone of Costa Rica
            TimeZoneInfo zoneInfo = TimeZoneInfo.FindSystemTimeZoneById(Constants.IDCOSTARICA);

            //converts date received to time zone of Costa Rica
            DateTimeOffset converted = TimeZoneInfo.ConvertTime(timeOffsetOfReceived, zoneInfo);

            return converted;

        }

        public DateTimeOffset offsetUTC(DateTimeOffset date)
        {


            //convert date to timezona of current server without lost timeoffset
            DateTimeOffset timeOffsetOfReceived = new DateTimeOffset(date.UtcDateTime,
                TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id)
                                          .GetUtcOffset(date));

            //get zone of Costa Rica
            TimeZoneInfo zoneInfo = TimeZoneInfo.FindSystemTimeZoneById(Constants.IDCOSTARICA);

            //converts date received to time zone of Costa Rica
            DateTimeOffset converted = TimeZoneInfo.ConvertTime(timeOffsetOfReceived, zoneInfo);

            return converted;

        }

        public DateTimeOffset shortconvert(DateTime date)
        {

            //convert date to timezona of current server without lost timeoffset
            DateTimeOffset timeOffsetOfReceived = new DateTimeOffset(date,
                TimeZoneInfo.FindSystemTimeZoneById(Constants.IDCOSTARICA)
                                          .GetUtcOffset(date));

            return timeOffsetOfReceived;

        }

        public DateTime convertDatetimeOffsetintoDatetime(DateTimeOffset date)
        {
            return date.ToLocalTime().DateTime;
        }
    }
}


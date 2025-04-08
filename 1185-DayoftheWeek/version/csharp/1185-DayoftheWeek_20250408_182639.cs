// Last updated: 08/04/2025, 18:26:39
public class Solution {
    public string DayOfTheWeek(int day, int month, int year) {
        // using 01/01/1971 as a value for day reference (it is a friday)
        // calc the date from 01/01/0000 and 01/01/1971 
        int referenceDays =  ConvertYearToDaysFromTheYearZero(1971); // used to calc offset to find day of week
        int referenceDayOfWeek = 4; // Representing friday as 4 (0 = monday, 6 = sunday)

        int dayFromZero = day - 1;                          // Same leap year calc from func explained there
        dayFromZero += ConvertMonthToDaysFromJanuary(month, (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0));
        dayFromZero += ConvertYearToDaysFromTheYearZero(year);

        int daysFromReference = dayFromZero - referenceDays; // get days from the reference

        int daysFromFriday = daysFromReference % 7;

        int dayOfWeek = (referenceDayOfWeek + daysFromFriday) % 7;

        if (dayOfWeek == 0) return "Monday";
        if (dayOfWeek == 1) return "Tuesday";
        if (dayOfWeek == 2) return "Wednesday";
        if (dayOfWeek == 3) return "Thursday";
        if (dayOfWeek == 4) return "Friday";
        if (dayOfWeek == 5) return "Saturday";
        if (dayOfWeek == 6) return "Sunday";

        return "Failed";
    }

    int ConvertYearToDaysFromTheYearZero(int year)
    {
        // A year is a leap year if it's divisible by 4 except years divisible by 100 unless they are also divisible by 400.
        int leapYears = (year - 1) / 4 - (year - 1) / 100 + (year - 1) / 400;
        return (365 * year) + leapYears;
    }

    int ConvertMonthToDaysFromJanuary(int month, bool isLeapYear)
    {
        int days = 0;

        if (month > 1) days += 31; // if month is january do not add extra days
        if (month > 2) days += isLeapYear ? 29 : 28;
        if (month > 3) days += 31;
        if (month > 4) days += 30;
        if (month > 5) days += 31;
        if (month > 6) days += 30;
        if (month > 7) days += 31;
        if (month > 8) days += 31;
        if (month > 9) days += 30;
        if (month > 10) days += 31;
        if (month > 11) days += 30;

        return days;
    }
}
// Last updated: 18/06/2026, 09:38:59
1public class Solution {
2    public double AngleClock(int hour, int minutes) {
3        // each hour is 360/12 (12 hours on clock) = 30 degrees, each minute is 360/60 (60 minutes per hour) = 6 degrees per minute, hour hand moves an additional. 30/60 = 0.5 degrees per hour (each hour is 30 degrees on the clock)
4        double hourAngle = 30.0 * hour + (minutes * 0.5);
5        double minuteAngle = 6.0 * minutes;
6        double difference = Math.Abs(hourAngle - minuteAngle);
7        return Math.Min(difference, 360 - difference); // take smaller of clockwise/anti-clockwise angles
8    }
9}
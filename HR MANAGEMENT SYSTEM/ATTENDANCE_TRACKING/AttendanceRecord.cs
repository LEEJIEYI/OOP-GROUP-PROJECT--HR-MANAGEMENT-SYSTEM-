using System;

namespace AttendanceApp
{
    public class AttendanceRecord
    {
        public int EmployeeId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public TimeSpan? TotalHoursWorked =>
            CheckOutTime.HasValue ? CheckOutTime.Value - CheckInTime : null;
    }
}

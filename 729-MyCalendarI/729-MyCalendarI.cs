public class MyCalendar {

    struct Booking{
        public int start {get; set;}
        public int end {get; set;}

        public Booking(int Start, int End){
            start = Start;
            end = End;
        }
    }

    // Use custom comparer to see if can be added
    class BookingComparer : IComparer<Booking>{
        public int Compare(Booking b1, Booking b2){
            if (b1.end <= b2.start){ // Does not overlap b1 ends before b1 starts
                return -1;
            }
            if (b1.start < b2.end && b1.end > b2.start){ // Bookings overlap so not added to set
                return 0;
            }
            return 1; // Does not overlap b2 ends before b1 starts
        }
    }

    SortedSet<Booking> bookings;

    public MyCalendar() {
        bookings = new SortedSet<Booking>(new BookingComparer());
    }
    
    public bool Book(int startTime, int endTime) {
        return bookings.Add(new Booking(startTime, endTime));
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(startTime,endTime);
 */
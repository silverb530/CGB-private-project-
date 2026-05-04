using System;
using System.Collections.Generic;

namespace CGB
{
    internal class DataClass
    {
        public class UserInfo
        {
            public string name, id, password, phone, birth;
            public UserInfo() { }
            public UserInfo(string name, string id, string password)
            { this.name = name; this.id = id; this.password = password; }
            public UserInfo(string name, string id, string password, string phone, string birth)
            { this.name = name; this.id = id; this.password = password; this.phone = phone; this.birth = birth; }
        }

        public class MovieInfo
        {
            public string mName, openDate, rating, runningTime, rationing, video, intro;
            public MovieInfo(string name, string date, string rating, string runtime, string rationing, string video, string intro)
            {
                mName = name; openDate = date; this.rating = rating; runningTime = runtime;
                this.rationing = rationing; this.video = video; this.intro = intro;
            }
        }

        public class movieSchedule
        {
            public string start_time, end_time, room;
            public int currentBooking;
            public static int allSeat = 30;
            public List<string> bookedSeats = new List<string>();

            public movieSchedule() { }
            public movieSchedule(string start_time, string end_time, string room, int current)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.room = room;
                this.currentBooking = current;
                GenerateRandomSeats(current, (start_time + room).GetHashCode());
            }

            private void GenerateRandomSeats(int count, int seed)
            {
                var all = new List<string>();
                for (char r = 'A'; r <= 'E'; r++)
                    for (int c = 1; c <= 6; c++)
                        all.Add($"{r}{c}");
                var rnd = new Random(seed);
                int added = 0;
                while (added < count && all.Count > 0)
                {
                    int i = rnd.Next(all.Count);
                    bookedSeats.Add(all[i]);
                    all.RemoveAt(i);
                    added++;
                }
            }

            public void AddBooking(List<string> seats)
            {
                bookedSeats.AddRange(seats);
                currentBooking += seats.Count;
            }

            public int AvailableSeats => allSeat - currentBooking;
        }

        public class bookingInfo
        {
            public string title, id, date, time, room;
            public List<string> seat;
            public bookingInfo() { }
            public bookingInfo(string title, string id, List<string> seat, string date, string time, string room)
            { this.title = title; this.id = id; this.seat = seat; this.date = date; this.time = time; this.room = room; }
        }
    }
}

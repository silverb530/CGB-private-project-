using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGB
{
    internal class DataClass
    {
        public class UserInfo
        {
            public string name;
            public string id;
            public string password;
            public string phone;
            public string birth;

            public UserInfo() { }

            public UserInfo(string name, string id, string password)
            {
                this.name = name;
                this.id = id;
                this.password = password;
            }

            public UserInfo(string name, string id, string password, string phone, string birth)
            {
                this.name = name;
                this.id = id;
                this.password = password;
                this.birth = birth;
                this.phone = phone;
            }
        }


        public class MovieInfo
        {
            public string mName;            // 영화이름
            public string openDate;         // 개봉일자
            public string rating;           // 나이등급
            public string runningTime;      // 러닝타임
            public string rationing;        // 배급
            public string intro;            // 소개
            public string video;            // 예고편


            public MovieInfo(string name, string date, string rating, string runtime, string rationing, string video, string intro)
            {
                this.mName = name;
                this.openDate = date;
                this.rating = rating;
                this.runningTime = runtime;
                this.rationing = rationing;
                this.intro = intro;
                this.video = video;
            }
        }

        public class movieSchedule
        {
            public string start_time;
            public string end_time;
            public string room;
            public static int currentBooking;
            public static int allSeat = 30;

            public movieSchedule() { }
            public movieSchedule(string start_time, string end_time, string room, int current)
            {
                this.start_time = start_time;
                this.end_time = end_time;
                this.room = room;
                currentBooking = current;
            }

            public void addCurrenBooking()
            {
                currentBooking++;
            }

        }

        public class bookingInfo
        {
            public string title;
            public string id;
            public List<string> seat;
            public string date;
            public string time;
            public string room;

            public bookingInfo() { }
            public bookingInfo(string title, string id, List<string> seat, string date, string time, string room)
            {
                this.title = title;
                this.id = id;
                this.seat = seat;
                this.date = date;
                this.time = time;
                this.room = room;
            }
        }
    }
}

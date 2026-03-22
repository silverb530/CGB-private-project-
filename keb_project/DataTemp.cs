using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static keb_project.DataClass;

namespace keb_project
{
    internal class DataTemp
    {
        public static UserInfo currentUser;
        public static List<UserInfo> usersList = new List<UserInfo>();
        public static void initData()
        {
            usersList.Add( new UserInfo("강은비", "kbee", "1234", "01035117802", "1995-05-30"));
        }



        public static List<MovieInfo> movieList = new List<MovieInfo>();
        public static MovieInfo movie1 = new MovieInfo("왕과 사는 남자", "2026.02.04.", "12세 이상 관람", "117분", "(주)쇼박스",
                                        "C:\\Users\\모블\\Desktop\\강은비\\왕과 사는 남자.mp4",
                                        "“나는 이제 어디로 갑니까…” 계유정난이 조선을 뒤흔들고 어린 왕 이홍위는 왕위에서 쫓겨나 유배길에 오른다." +
                                        " “무슨 수를 쓰더라도 그 대감을 우리 광천골로 오게 해야지” 한편, 강원도 영월 산골 마을 광천골의 촌장 엄흥도는" +
                                        " 먹고 살기 힘든 마을 사람들을 위해 청령포를 유배지로 만들기 위해 노력한다. 그러나 촌장이 부푼 꿈으로 맞이한 이는 " +
                                        "왕위에서 쫓겨난 이홍위였다. 유배지를 지키는 보수주인으로서 그의 모든 일상을 감시해야만 하는 촌장은 삶의 의지를 잃어" +
                                        "버린 이홍위가 점점 신경 쓰이는데… 1457년 청령포, 역사가 지우려 했던 이야기. <왕과 사는 남자>");

        public static MovieInfo movie2 = new MovieInfo("브라이드", "2026.03.04.", "청소년 관람불가", "126분", "워너 브러더스 코리아(주)",
                                        "C:\\Users\\모블\\Desktop\\강은비\\브라이드.mp4",
                                        "1930년대 미국, 죽음에서 깨어난 ‘브라이드’(제시 버클리)와 그녀를 사랑하게 된 ‘프랑켄슈타인’(크리스찬 베일). 어느 날, 끔찍한 사건을 저지르고 위험천만한 도주를 시작한다. 세상의 모든 규범을 깨부순 ‘브라이드’와 ‘프랑켄슈타인’의 파격적인 행보는 미국 전역을 뒤흔들고 그들의 운명은 걷잡을 수 없는 방향으로 치닫는데… 그 누구도 예측 불가, 감당 불가! 세상에서 제일 ㅁ#친X 신부 입장!");

        public static MovieInfo movie3 = new MovieInfo("호퍼스", "2026.03.04.", "전제 연령가", "126분", "워너 브러더스 코리아(주)",
                                        "C:\\Users\\모블\\Desktop\\강은비\\브라이드.mp4",
                                        "test");
       
        public static MovieInfo movie4 = new MovieInfo("휴민트", "2026.03.04.", "15세 관람가", "530분", "eb네트워크(주)",
                                        "C:\\Users\\모블\\Desktop\\강은비\\text.mp4",
                                        "test");

        public static void initMovieData()
        {
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
        }


        public static List<String> posterList = new List<String>();
        public static List<String> titleList = new List<String>();
        public static void initPosterData() {
            string path = "C:\\keb_C\\workspace\\keb_project\\Resources\\";
            posterList.Add(path + "1.왕사남.jpg");
            titleList.Add("왕과 사는 남자");
            posterList.Add(path + "2.브라이드.jpg");
            titleList.Add("브라이드");
            posterList.Add(path + "3.호퍼스.jpg");
            titleList.Add("호퍼스");
            posterList.Add(path + "4.휴민트.jpg");
            titleList.Add("휴민트");
        }

        static List<movieSchedule> schedules = new List<movieSchedule>();
        public void initSchedule()
        {
            schedules.Add(new movieSchedule("09:30","11:37","1관",20));
            schedules.Add(new movieSchedule("10:00","12:07","2관",10));
            schedules.Add(new movieSchedule("10:30","12:37","3관",15));
            schedules.Add(new movieSchedule("11:30","13:37","4관",7));
            schedules.Add(new movieSchedule("12:30","14:37","1관",24));
            schedules.Add(new movieSchedule("15:00","17:37","2관",30));
            schedules.Add(new movieSchedule("15:30","18:07","7관",5));

            schedules.Add(new movieSchedule("16:00","18:37","2관",6));
            schedules.Add(new movieSchedule("16:30","17:07","4관",16));
            schedules.Add(new movieSchedule("17:10","19:47","1관",21));
            schedules.Add(new movieSchedule("18:30","21:07","6관",22));
            schedules.Add(new movieSchedule("19:00","21:37","2관",30));
            schedules.Add(new movieSchedule("20:30","23:07","1관",21));


        }
        static Dictionary<DateTime, List<movieSchedule>> ms1 = new Dictionary<DateTime, List<movieSchedule>>();
        public static void scheduleMake()
        {
            DateTime today = DateTime.Today;

            for(int i =1; i<=7; i++)
            {
                ms1.Add(today.AddDays(i), schedules);
            }
        }
        //public static Dictionary<String,List<movieSchedule>> schMap1 = new Dictionary<String,List<movieSchedule>>();

        //public static bookingInfo biObj = new bookingInfo();
        public static List<bookingInfo> bookingList = new List<bookingInfo>();
        public static Dictionary<string, List<bookingInfo>> bookingMap = new Dictionary<string, List<bookingInfo>>();

    }
}

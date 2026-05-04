using System;
using System.Collections.Generic;
using static CGB.DataClass;

namespace CGB
{
    internal class DataTemp
    {
        private static bool _initialized = false;

        public static UserInfo currentUser;
        public static List<UserInfo> usersList = new List<UserInfo>();
        public static List<MovieInfo> movieList = new List<MovieInfo>();
        public static Dictionary<string, Dictionary<string, List<movieSchedule>>> scheduleMap
            = new Dictionary<string, Dictionary<string, List<movieSchedule>>>();
        public static List<bookingInfo> bookingList = new List<bookingInfo>();

        public static void InitAll()
        {
            if (_initialized) return;
            _initialized = true;
            InitUsers();
            InitMovies();
            InitSchedules();
        }

        private static void InitUsers()
        {
            usersList.Add(new UserInfo("강은비", "kbee", "1234", "01035117802", "1995-05-30"));
        }

        private static void InitMovies()
        {
            movieList.Add(new MovieInfo(
                "왕과 사는 남자", "2026.02.04", "12세 이상", "117분", "(주)쇼박스", "",
                "나는 이제 어디로 갑니까… 계유정난이 조선을 뒤흔들고 어린 왕 이홍위는 왕위에서 쫓겨나 유배길에 오른다. " +
                "강원도 영월 산골 광천골의 촌장 엄흥도는 먹고 살기 힘든 마을을 위해 청령포를 유배지로 만들려 노력한다. " +
                "그러나 촌장이 맞이한 이는 왕위에서 쫓겨난 이홍위였다. " +
                "유배지를 지키는 보수주인으로서 그의 모든 일상을 감시해야만 하는 촌장은 삶의 의지를 잃어버린 이홍위가 점점 신경 쓰이는데… " +
                "1457년 청령포, 역사가 지우려 했던 이야기. ─ 왕과 사는 남자"));

            movieList.Add(new MovieInfo(
                "브라이드!", "2026.03.04", "청소년 관람불가", "126분", "워너 브러더스 코리아(주)", "",
                "1930년대 미국, 죽음에서 깨어난 '브라이드'와 그녀를 사랑하게 된 '프랑켄슈타인'. " +
                "어느 날, 끔찍한 사건을 저지르고 위험천만한 도주를 시작한다. " +
                "세상의 모든 규범을 깨부순 두 사람의 파격적인 행보는 미국 전역을 뒤흔들고 " +
                "그들의 운명은 걷잡을 수 없는 방향으로 치닫는데… " +
                "그 누구도 예측 불가, 감당 불가! 세상에서 제일 파격적인 신부 입장!"));

            movieList.Add(new MovieInfo(
                "호퍼스", "2026.03.04", "전체 관람가", "106분", "워너 브러더스 코리아(주)", "",
                "세상을 구한다는 사명을 가진 특별한 영웅들의 이야기. " +
                "평범한 일상과 영웅적 삶 사이에서 갈등하는 그들의 여정. " +
                "우정, 희생, 그리고 진정한 용기의 의미를 되묻는 가족 액션 어드벤처."));

            movieList.Add(new MovieInfo(
                "휴민트", "2026.03.04", "15세 관람가", "130분", "eb네트워크(주)", "",
                "국가정보원 특수요원의 최후 임무. " +
                "위장 침투, 배신, 그리고 진실. " +
                "살아있는 정보전의 세계에서 인간의 한계를 시험받는 요원의 이야기. " +
                "한국형 스파이 스릴러의 새로운 기준을 제시한다."));
        }

        private static void InitSchedules()
        {
            var templates = new List<List<(string start, string end, string room, int cur)>>
            {
                new List<(string,string,string,int)>
                {
                    ("09:30","11:27","1관",8), ("12:00","13:57","2관",15),
                    ("15:30","17:27","3관",20), ("18:00","19:57","1관",24), ("21:00","22:57","4관",6)
                },
                new List<(string,string,string,int)>
                {
                    ("10:00","12:06","2관",12), ("14:00","16:06","5관",28),
                    ("19:00","21:06","3관",5), ("22:00","00:06","6관",18)
                },
                new List<(string,string,string,int)>
                {
                    ("11:00","12:46","3관",10), ("16:00","17:46","1관",22), ("20:00","21:46","2관",30)
                },
                new List<(string,string,string,int)>
                {
                    ("10:30","12:40","4관",15), ("14:30","16:40","5관",7),
                    ("18:30","20:40","6관",20), ("21:30","23:40","4관",3)
                },
            };

            DateTime today = DateTime.Today;
            for (int mi = 0; mi < movieList.Count; mi++)
            {
                string name = movieList[mi].mName;
                scheduleMap[name] = new Dictionary<string, List<movieSchedule>>();
                for (int d = 0; d < 7; d++)
                {
                    string dateKey = today.AddDays(d).ToString("yyyy-MM-dd");
                    var list = new List<movieSchedule>();
                    foreach (var t in templates[mi])
                        list.Add(new movieSchedule(t.start, t.end, t.room, t.cur));
                    scheduleMap[name][dateKey] = list;
                }
            }
        }

        public static List<movieSchedule> GetSchedules(string movieName, string dateKey)
        {
            if (scheduleMap.TryGetValue(movieName, out var dm) && dm.TryGetValue(dateKey, out var list))
                return list;
            return new List<movieSchedule>();
        }
    }
}

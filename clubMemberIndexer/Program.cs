using System;

namespace clubMemberIndexer
{
    class Program
    {
        public const int Size = 15;
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0;i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType= string.Empty;
                ClubLocation= string.Empty;
                MeetingDate= string.Empty;
            }
            //indexer get and set methods
            public string this[int index]
            {
                get { return Members[index]; }
                set { Members[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();
            club[0] = "Jayne Cobb";
            club[1] = "Kaylee Frye";
            club[2] = "Simon Tam";
            club[3] = "River Tam";
            club[4] = "Shepherd Book";
            club[5] = "Inara Serra";
            club.ClubType = "virtual";
            club.ClubLocation = "online";
            club.MeetingDate = "alternate Tuesdays";

            Console.WriteLine("Information for Club Firefly:");
            Console.WriteLine("Members:");
            for (int i = 0; i<Size; i++)
            {
                if (club[i] != string.Empty)
                    Console.WriteLine(club[i]);
            }
            Console.WriteLine($"Club type: {club.ClubType}");
            Console.WriteLine($"Club location: {club.ClubLocation}");
            Console.WriteLine($"Club meeting date: {club.MeetingDate}");
        }
    }
}
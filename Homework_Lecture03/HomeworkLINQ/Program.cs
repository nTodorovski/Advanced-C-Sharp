using Entities_for_Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLINQ
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }
        static void Main(string[] args)
        {
            Init();// this method fills the arrays above with data

            /*
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░░
                ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░
                ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒███░░░░
                ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░
                ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▄██▄▒▒▒▒▄██▄▒▒▒███░
                ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒██
                ░░░█████████████▒▒▒▒▀██▀▒▒▒▒▀██▀▒▒▒▒▒██
                ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒██
                ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒██▒▒▒▒██
                ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒██
                █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒███████▒▒▒▒▒▒▒██
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░
                ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░
                ░██▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░
                ░░████████████░░░████████████████░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░▄█████▄░▄███████▄░▄███████▄░██████▄░░
                ░░██▒▒▒▒█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░██▒▒▒▒▒░██▒▒▒▒▒██░██▒▒▒▒▒██░██▒▒▒██░░
                ░░██▒▒▒▀█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░▀█████▀░▀███████▀░▀███████▀░██████▀░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░▄█████░██▒▒▒▒██▀░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▀▒▒▒░██▒▒▒██░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▒▒▒▒░█████▀░░░░░░░
                ░░░░██▒▒▒▒░██▄▒▄██░██▄▒▒▒░██▒▒▒██░░░░░░
                ░░░░▀█████░▀█████▀░▀█████░██▒▒▒▒██▄░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            */

            //1 - how many Songs start with the letter 'a' (case insensitive)
            Console.WriteLine("Songs start with the letter 'a'");
            var songsWithA = Songs
				.Where(x => x.Name.StartsWith("a"))
				.ToList();
            Console.WriteLine(string.Join(" ",songsWithA));
            Console.WriteLine("-----------------------------------------");

            //2 - how many artists end with letter 'a' (case insensitive)
            Console.WriteLine("Artists end with letter 'a'");
            var artistEnd = Artists
				.Where(x => x.FullName.EndsWith("a"))
				.ToList();
            foreach (var item in artistEnd)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine("-----------------------------------------");

            //3 - whats the name of the song with longest duration
            Console.WriteLine("Longest Song by Duration:");
            var longestSong = Songs
				.OrderByDescending(x => x.Duration)
				.First();
            Console.WriteLine(longestSong.Name);
            Console.WriteLine("-----------------------------------------");

            //4 - whats the total Duration of all Songs
            Console.WriteLine("Total Duration of all Songs:");
            var totalDuration = Songs
				.Sum(x => x.Duration);
            Console.WriteLine($"{totalDuration} seconds");
            Console.WriteLine("-----------------------------------------");

            //5 - how many albums have Songs longer than 300 seconds
            Console.WriteLine("Albums with Songs longer than 300 seconds");
            var albums300 = Albums
				.Where(x => x.Songs.Any(y => y.Duration > 300));
            foreach (var item in albums300)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("-----------------------------------------");

            //6 - print the names of the artists(separated with "--"), that have more than one album of PopRock genre
            Console.WriteLine("Artists with more than one album of PopRock Genre:");
			var popRock = Artists
				.Select(x => new { NameOfArtist = x.FullName, AlbumsOfArtist = x.Albums.Where(y => y.Genre == Genre.PopRock).Count() })
				.Where(k=>k.AlbumsOfArtist > 1);
            foreach (var item in popRock)
            {
                Console.Write(item.NameOfArtist + "--");
            }
			Console.WriteLine();
            Console.WriteLine("-----------------------------------------");

            //7 - print the name of the album that has highest Average duration of a song
            Console.WriteLine("Albums with highest Average duration of a song:");
            var durationAvg = Albums
				.Select(x => new { NameOfAlbum = x.Name, AvgDuration = x.Songs.Average(y => y.Duration) })
				.OrderByDescending(w => w.AvgDuration)
				.First();
            Console.WriteLine($"Name: {durationAvg.NameOfAlbum}, Highest Average duration: {durationAvg.AvgDuration}");
            Console.WriteLine("-----------------------------------------");

            //8 - how many characters has the song that has the shortest Duration
            Console.WriteLine("Characters of the shortest duration song:");
            var shortestDuration = Songs
				.OrderByDescending(x => x.Duration)
				.Reverse()
				.First();
            Console.WriteLine($"Name: {shortestDuration.Name}, Characters: {shortestDuration.Name.Length}, Duration: {shortestDuration.Duration}");
            Console.WriteLine("-----------------------------------------");

            //9 - print the name and the genre of the album that has most songs
            Console.WriteLine("Album with most songs:");
            var mostSongsAlbum = Albums
				.Select(x => new { SongCount = x.Songs.Count, NameOfAlbum = x.Name, GenreOfAlbum = x.Genre })
				.OrderByDescending(w => w.SongCount)
				.First();
            Console.WriteLine($"Name: {mostSongsAlbum.NameOfAlbum}, Song Count: {mostSongsAlbum.SongCount}, Genre: {mostSongsAlbum.GenreOfAlbum}");
            Console.WriteLine("-----------------------------------------");

            //10 - print the name of the artist that has most songs
            Console.WriteLine("Artist with most songs:");
			var artistMostSongs = Artists
				.Select(x => new { NameOfArtist = x.FullName, SongsOfArtist = x.Albums.Sum(y => y.Songs.Count) })
				.OrderByDescending(a => a.SongsOfArtist)
				.First();
			Console.WriteLine($"Artist: {artistMostSongs.NameOfArtist}, Songs Count: {artistMostSongs.SongsOfArtist}");
			Console.WriteLine("-----------------------------------------");

			//11 - print the type of the artist(SoloArtist/Band) that has most albums published before year 2000
			Console.WriteLine("Artist that has most albums published before year 2000:");
			var artist2000 = Artists
				.Select(x => new { NameOfArtist = x.FullName, AlbumsCount = x.Albums.Select(y => y.Year < 2000).Count() })
				.OrderByDescending(a => a.AlbumsCount)
				.First();
			Console.WriteLine($"Artist: {artist2000.NameOfArtist}");
			Console.WriteLine("-----------------------------------------");

			//12 - print the average song duration, of the album that has most songs
			Console.WriteLine("Average song duration of the album that has most songs:");
			var albumAverageDuration = Albums
				.Select(x => new { NameOfAlbum = x.Name, MostSongs = x.Songs.Count(), AverageDuration = x.Songs.Average(d => d.Duration) })
				.OrderByDescending(o => o.MostSongs)
				.First();
			Console.WriteLine($"Album Name: {albumAverageDuration.NameOfAlbum}, Songs Count: {albumAverageDuration.MostSongs}, Average Duration: {albumAverageDuration.AverageDuration} seconds");
			Console.WriteLine("-----------------------------------------");

			// Bonus:
			//13 - print the longest song duration of the album that has least songs
			Console.WriteLine("Longest song duration of the album that has least songs:");
			var longestSongDuration = Albums
				.OrderBy(x => x.Songs.Count)
				.Select(s => new { Song = s.Songs.OrderByDescending(s1 => s1.Duration).First(), AlbumName = s.Name, AlbumSongs = s.Songs.Count()})
				.First();
			Console.WriteLine($"Song Name: {longestSongDuration.Song.Name}, Song Duration: {longestSongDuration.Song.Duration} seconds, Album Name: {longestSongDuration.AlbumName}, Album Songs: {longestSongDuration.AlbumSongs}");
			Console.WriteLine("-----------------------------------------");

			//14 - print the name of the album that has most songs that contain letter 'a' in the name
			Console.WriteLine("Name of the Album that has most songs that contain letter 'a' in the name:");
			var songsThatContainA = Albums
				.Select(x => new { AlbumName = x.Name, ContainA = x.Songs.Where(y => y.Name.Contains("a")).Count() })
				.OrderByDescending(x => x.ContainA)
				.First();
			Console.WriteLine($"Album Name: {songsThatContainA.AlbumName}, Songs count that contain 'a': {songsThatContainA.ContainA}");
			Console.WriteLine("-----------------------------------------");

			//15 - print the name of the artist that has most songs that end with letter 'd'

            //OVA NE RABOTI :D
			Console.WriteLine("Name of the artist that has most songs that end with letter 'd':");
            var artistNameEndsWithD = Artists
                .Select(x => new { ArtistName = x.FullName, SongsCount = x.Albums.Select(y => y.Songs.Select(z => z.Name.EndsWith("d"))).Count() }).ToList();
                //.OrderByDescending(x => x.SongsCount)
                //.First();

            //var artistNameEndsD = Artists.SelectMany(x => x.Albums)
            //var songsThatEndsWithD = Albums
            //    .Select(x => new { AlbumName = x.Name, EndsWithD = x.Songs.Where(y => y.Name.EndsWith("d")).Count() })
            //    .OrderByDescending(x => x.EndsWithD)
            //    .First();
            //Console.WriteLine($"Album Name: {artistNameEndsWithD.ArtistName}, Songs count that ends on 'd': {artistNameEndsWithD.SongsCount}");
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();
		}

		#region Data Initialization
		private static void Init()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
            FillAlbums();
            FillArtists();
        }
        private static void FillAlbums()
        {
            foreach (var album in Albums)
            {
                album.Songs = Songs.Where(x => x.AlbumId == album.Id).ToList();
            }
        }
        private static void FillArtists()
        {
            foreach (var artist in Artists)
            {
                artist.Albums = Albums.Where(album => album.ArtistId == artist.Id).ToList();
            }
        }
        private static void InitArtists()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));
            Artists.Add(new Artist(3, "Rammstein", ArtistType.Band));
            Artists.Add(new Artist(4, "Coldplay", ArtistType.Band));
            Artists.Add(new Artist(5, "Beyonce", ArtistType.SoloArtist));
        }
        private static void InitAlbums()
        {
            Albums = new List<Album>();
            Albums.Add(new Album(1, 1, "Metallica", Genre.PopRock, 1991));
            Albums.Add(new Album(2, 1, "Ride The Lightning", Genre.PopRock, 1984));
            Albums.Add(new Album(3, 2, "Brave New World", Genre.PopRock, 2000));
            Albums.Add(new Album(4, 2, "Seventh Son of a Seventh Son", Genre.PopRock, 1988));
            Albums.Add(new Album(5, 3, "MUTTER", Genre.PopRock, 2001));
            Albums.Add(new Album(6, 3, "RosenRot", Genre.PopRock, 2005));
            Albums.Add(new Album(7, 4, "Mylo Xyloto", Genre.PopRock, 2011));
            Albums.Add(new Album(8, 5, "Lemonade", Genre.RnB, 2016));
        }
        private static void InitSongs()
        {
            Songs = new List<Song>();

            #region Metallica - Metallica
            Songs.Add(new Song(1, 1, "Enter Sandman", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "Sad But True", 5 * 60 + 24));
            Songs.Add(new Song(3, 1, "Holier Than Thou", 3 * 60 + 47));
            Songs.Add(new Song(4, 1, "The Unforgiven", 6 * 60 + 27));
            Songs.Add(new Song(5, 1, "Wherever I May Roam", 6 * 60 + 44));
            Songs.Add(new Song(6, 1, "Don't Tread on Me", 4 * 60 + 0));
            Songs.Add(new Song(7, 1, "Through the Never", 4 * 60 + 4));
            Songs.Add(new Song(8, 1, "Nothing Else Matters", 6 * 60 + 28));
            Songs.Add(new Song(9, 1, "Of Wolf and Man", 4 * 60 + 16));
            Songs.Add(new Song(10, 1, "The God That Failed", 5 * 60 + 8));
            Songs.Add(new Song(11, 1, "My Friend of Misery", 6 * 60 + 49));
            Songs.Add(new Song(12, 1, "The Struggle Within", 3 * 60 + 53));
            #endregion

            #region Metallica - ride-the-lightning
            Songs.Add(new Song(13, 2, "Fight Fire with Fire", 4 * 60 + 44));
            Songs.Add(new Song(14, 2, "Ride the Lightning", 6 * 60 + 36));
            Songs.Add(new Song(15, 2, "For Whom the Bell Tolls", 5 * 60 + 9));
            Songs.Add(new Song(16, 2, "Fade to Black", 6 * 60 + 57));
            Songs.Add(new Song(17, 2, "Trapped Under Ice", 4 * 60 + 4));
            Songs.Add(new Song(18, 2, "Escape", 4 * 60 + 23));
            Songs.Add(new Song(19, 2, "Creeping Death", 6 * 60 + 36));
            Songs.Add(new Song(20, 2, "The Call of Ktulu", 8 * 60 + 53));
            #endregion

            #region Iron Maiden - Brave New World
            Songs.Add(new Song(21, 3, "The Wicker Man", 4 * 60 + 35));
            Songs.Add(new Song(22, 3, "Ghost of the Navigator", 6 * 60 + 50));
            Songs.Add(new Song(23, 3, "Brave New World", 6 * 60 + 18));
            Songs.Add(new Song(24, 3, "Blood Brothers", 7 * 60 + 14));
            Songs.Add(new Song(25, 3, "The Mercenary", 4 * 60 + 42));
            Songs.Add(new Song(26, 3, "Dream of Mirrors", 9 * 60 + 21));
            Songs.Add(new Song(27, 3, "The Fallen Angel", 4 * 60 + 0));
            Songs.Add(new Song(28, 3, "The Nomad", 9 * 60 + 5));
            Songs.Add(new Song(29, 3, "Out of the Silent Planet", 6 * 60 + 25));
            Songs.Add(new Song(30, 3, "The Thin Line Between Love and Hate", 8 * 60 + 27));

            #endregion

            #region Iron Maiden - Seventh Son of a Seventh Son
            Songs.Add(new Song(31, 4, "Moonchild", 5 * 60 + 41));
            Songs.Add(new Song(32, 4, "Infinite Dreams", 6 * 60 + 9));
            Songs.Add(new Song(33, 4, "Can I Play with Madness", 3 * 60 + 31));
            Songs.Add(new Song(34, 4, "The Evil That Men Do", 4 * 60 + 34));
            Songs.Add(new Song(35, 4, "Seventh Son of a Seventh Son", 9 * 60 + 53));
            Songs.Add(new Song(36, 4, "The Prophecy", 5 * 60 + 6));
            Songs.Add(new Song(37, 4, "The Clairvoyant", 4 * 60 + 27));
            Songs.Add(new Song(38, 4, "Only the Good Die Young", 4 * 60 + 42));
            #endregion

            #region Rammstein - MUTTER
            Songs.Add(new Song(39, 5, "Mein Herz Brennt", 4 * 60 + 39));
            Songs.Add(new Song(40, 5, "Mein Herz Brennt", 3 * 60 + 36));
            Songs.Add(new Song(41, 5, "Sonne", 4 * 60 + 32));
            Songs.Add(new Song(42, 5, "Ich Will", 3 * 60 + 37));
            Songs.Add(new Song(43, 5, "Feuer Frei!", 3 * 60 + 11));
            Songs.Add(new Song(44, 5, "Mutter", 4 * 60 + 32));
            Songs.Add(new Song(45, 5, "Spieluhr", 4 * 60 + 46));
            Songs.Add(new Song(46, 5, "Zwitter", 4 * 60 + 17));
            Songs.Add(new Song(47, 5, "Rein Raus", 3 * 60 + 9));
            Songs.Add(new Song(48, 5, "Adios", 3 * 60 + 49));
            Songs.Add(new Song(49, 5, "Nebel", 4 * 60 + 54));
            #endregion

            #region Rammstein - Rosenrot
            Songs.Add(new Song(50, 6, "Benzin", 3 * 60 + 46));
            Songs.Add(new Song(51, 6, "Mann Gegen Mann", 3 * 60 + 50));
            Songs.Add(new Song(52, 6, "Rosenrot", 3 * 60 + 54));
            Songs.Add(new Song(53, 6, "Spring", 5 * 60 + 24));
            Songs.Add(new Song(54, 6, "Wo Bist Du", 3 * 60 + 55));
            Songs.Add(new Song(55, 6, "Stirb Nicht Vor Mir(Don't Die Before I Do)", 4 * 60 + 5));
            Songs.Add(new Song(56, 6, "Zerstören", 5 * 60 + 28));
            Songs.Add(new Song(57, 6, "Hilf Mir", 4 * 60 + 43));
            Songs.Add(new Song(58, 6, "Te Quiero Puta!", 3 * 60 + 55));
            Songs.Add(new Song(59, 6, "Feuer und Wasser", 5 * 60 + 17));
            Songs.Add(new Song(60, 6, "Ein Lied", 3 * 60 + 43));
            #endregion

            #region Coldplay - Mylo Xyloto
            Songs.Add(new Song(61, 7, "Mylo Xyloto", 0 * 60 + 43));
            Songs.Add(new Song(62, 7, "Hurts Like Heaven", 4 * 60 + 2));
            Songs.Add(new Song(63, 7, "Paradise", 4 * 60 + 37));
            Songs.Add(new Song(64, 7, "Charlie Brown", 4 * 60 + 45));
            Songs.Add(new Song(65, 7, "Us Against the World", 3 * 60 + 59));
            Songs.Add(new Song(66, 7, "M.M.I.X.", 0 * 60 + 48));
            Songs.Add(new Song(67, 7, "Every Teardrop Is a Waterfall", 4 * 60 + 0));
            Songs.Add(new Song(68, 7, "Major Minus", 3 * 60 + 30));
            Songs.Add(new Song(69, 7, "U.F.O.", 2 * 60 + 17));
            Songs.Add(new Song(70, 7, "Princess of China", 3 * 60 + 59));
            Songs.Add(new Song(71, 7, "Up in Flames", 3 * 60 + 13));
            Songs.Add(new Song(72, 7, "A Hopeful Transmission", 0 * 60 + 33));
            Songs.Add(new Song(73, 7, "Don't Let It Break Your Heart", 3 * 60 + 53));
            Songs.Add(new Song(74, 7, "Up with the Birds", 3 * 60 + 47));
            #endregion

            #region Beyonce - Lemonade
            Songs.Add(new Song(75, 8, "", 3 * 60 + 15));
            Songs.Add(new Song(76, 8, "", 3 * 60 + 41));
            Songs.Add(new Song(77, 8, "", 3 * 60 + 53));
            Songs.Add(new Song(78, 8, "", 3 * 60 + 52));
            Songs.Add(new Song(79, 8, "", 4 * 60 + 20));
            Songs.Add(new Song(80, 8, "", 4 * 60 + 47));
            Songs.Add(new Song(81, 8, "", 3 * 60 + 57));
            Songs.Add(new Song(82, 8, "", 3 * 60 + 2));
            Songs.Add(new Song(83, 8, "", 1 * 60 + 19));
            Songs.Add(new Song(84, 8, "", 4 * 60 + 49));
            Songs.Add(new Song(85, 8, "", 5 * 60 + 21));
            Songs.Add(new Song(86, 8, "", 3 * 60 + 25));

            #endregion

        }
        #endregion

    }
}


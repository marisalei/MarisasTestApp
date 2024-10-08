using System.Net.Mail;

namespace MarisaTestApp
{
	public class Person
	{
		public int Id { get; set; }

		public string Vorname { get; set; }

		public string Nachname { get; set; }

		public int Alter { get; set; }

		public string Geschlecht { get; set; }

        public string DisplayName => $"{Vorname} {Nachname} ({Alter}, {Geschlecht})";
	}
}

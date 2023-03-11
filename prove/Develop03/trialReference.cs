/*class Reference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int StartVerse { get; set; }
        public int EndVerse { get; set; }

        public Reference(string reference)
        {
            string[] parts = reference.Split(' ');
            Book = parts[0];
            string[] verses = parts[1].Split('-');
            if (verses.Length == 1)
            {
                Chapter = int.Parse(verses[0].Split(':')[0]);
                StartVerse = int.Parse(verses[0].Split(':')[1]);
                EndVerse = StartVerse;
            }
            else
            {
                Chapter = int.Parse(verses[0].Split(':')[0]);
                StartVerse = int.Parse(verses[0].Split(':')[1]);
                EndVerse = int.Parse(verses[1].Split(':')[1]);
            }
        }

        public override string ToString()
        {
            if (StartVerse == EndVerse)
            {
                return $"{Book} {Chapter}:{StartVerse}";
            }
            else
            {
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
            }
        }
    }
*/
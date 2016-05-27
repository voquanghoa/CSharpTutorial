namespace SelectSample
{
	internal class Student
	{
		public string Name { get; set; }
		public int Score1 { get; set; }
		public int Score2 { get; set; }
		public int Score3 { get; set; }
		public Student(string name, int score1, int score2, int score3)
		{
			Name = name;
			Score1 = score1;
			Score2 = score2;
			Score3 = score3;
		}
	}
}
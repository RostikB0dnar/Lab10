namespace Lab10.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool HasJob { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }

    public class Question
    {
        public int Id { get; set; } // Первинний ключ

        public int Number { get; set; }
        public string QuestionText { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public int Id { get; set; } // Первинний ключ

        public int QuestionNumber { get; set; }
        public Guid PersonId { get; set; }
        public DateTime AnswerTime { get; set; }
        public string AnswerText { get; set; }

        public Person Person { get; set; }
        public Question Question { get; set; }
    }
}

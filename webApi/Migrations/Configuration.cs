namespace webApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using webApi.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<webApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(webApi.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Questions.AddOrUpdate(x => x.Id,
                new Question() {Text = "Which of the following is a reserved keyword in C#?",CorrectAnswer = "All of the above.", Answer1 = "abstract", Answer2 = "as", Answer3 = "foreach", Difficulty = 1 },
                new Question() {Text = "Which of the following converts a type to a Boolean value, where possible in C#?", CorrectAnswer = "ToBoolean", Answer1 = "ToSingle", Answer2 = "ToChar", Answer3 = "ToDateTime", Difficulty = 1 },
                new Question() {Text = "Which of the following converts a type to a specified type in C#?", CorrectAnswer = "ToType", Answer1 = "ToSbyte", Answer2 = "ToSingle", Answer3 = "ToString", Difficulty = 1 },
                new Question() {Text = "Which of the following operator represents a conditional operation in C#?", CorrectAnswer = "?:", Answer1 = "is", Answer2 = "as", Answer3 = "*", Difficulty = 3 },
                new Question() {Text = "Which of the following method helps in returning more than one value?", CorrectAnswer = "Output parameters", Answer1 = "Value parameters", Answer2 = "Reference parameters", Answer3 = "None of the above", Difficulty = 5 },
                new Question() {Text = "Which of the following is true about C# structures?", CorrectAnswer = "All of the above", Answer1 = "Unlike classes, structures cannot inherit other structures or classes.", Answer2 = "Structure members cannot be specified as abstract, virtual, or protected.", Answer3 = " A structure can implement one or more interfaces.", Difficulty = 7 },
                new Question() {Text = "Which of the following is the correct about class constructor?", CorrectAnswer = "Both of the above.", Answer1 = "A class constructor is a special member function of a class that is executed whenever we create new objects of that class.", Answer2 = "None of the above", Answer3 = " A constructor has exactly the same name as that of class and it does not have any return type.", Difficulty = 7 },
                new Question() {Text = "Which of the following preprocessor directive allows you to undefine a symbol in C#?", CorrectAnswer = " undef", Answer1 = "define", Answer2 = "endregion", Answer3 = " region", Difficulty =5 },
                new Question() {Text = "Which of the following is true about exceptions in C#?", CorrectAnswer = " Both of the above", Answer1 = "None of the above.", Answer2 = "C# exceptions are represented by classes.", Answer3 = " The exception classes in C# are mainly directly or indirectly derived from the System.Exception class.", Difficulty =8 }



                );
        }
    }
}

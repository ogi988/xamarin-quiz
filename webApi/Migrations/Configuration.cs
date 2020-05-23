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
                new Question() {Text = "Which of the following is true about exceptions in C#?", CorrectAnswer = " Both of the above", Answer1 = "None of the above.", Answer2 = "C# exceptions are represented by classes.", Answer3 = " The exception classes in C# are mainly directly or indirectly derived from the System.Exception class.", Difficulty =8 },
                new Question() {Text = "Which of the following can be used to define the member of a class externally?", CorrectAnswer = " ::", Answer1 = ":", Answer2 = "#", Answer3 = " none of the mentioned", Difficulty =8 },
                new Question() {Text = "Which of the following operator can be used to access the member function of a class?", CorrectAnswer = " .", Answer1 = ":", Answer2 = "#", Answer3 = " ::", Difficulty =8 },
                new Question() {Text = "Which of the following gives the correct count of the constructors that a class can define?", CorrectAnswer = " Any number", Answer1 = "1", Answer2 = "2", Answer3 = " None of the above", Difficulty =4 },
                new Question() {Text = "Which of the following statements correctly tell the differences between ‘=’ and ‘==’ in C#?", CorrectAnswer = " ‘==’ operator is used to assign values from one variable to another variable ‘=’ operator is used to compare value between two variables", Answer1 = "‘=’ operator is used to assign values from one variable to another variable‘==’ operator is used to compare value between two variables", Answer2 = "No difference between both operators", Answer3 = "None of the mentioned", Difficulty = 3 },
                new Question() {Text = "What is the correct name of a method which has the same name as that of class and used to destroy objects?", CorrectAnswer = " Destructor", Answer1 = "Constructor", Answer2 = "Finalize()", Answer3 = " End", Difficulty = 5 },
                new Question() {Text = "Which of the followings is not allowed in C# as access modifier?", CorrectAnswer = " Friend", Answer1 = "public", Answer2 = "internal", Answer3 = " protected", Difficulty = 1 },
                new Question() {Text = "Which of the following C# keywords has nothing to do with multithreading?", CorrectAnswer = " sealed", Answer1 = "await", Answer2 = "async", Answer3 = " lock", Difficulty = 4 },
                new Question() {Text = "Find an invalid expression among the following C# Generics examples.", CorrectAnswer = " class A where T : class, struct", Answer1 = "class A where T : class, new()", Answer2 = "class A where T : struct, IComparable", Answer3 = " class A where T : Stream where U : IDisposable", Difficulty = 6 },
                new Question() {Text = "New keyword in C# is used to create new object from the type. Which of the followings is not allowed to use new keyword?", CorrectAnswer = "Interface : var a = new IComparable();", Answer1 = "Class: var a = new Class1();", Answer2 = "Struct : var a = new Struct1();", Answer3 = " C# object : var a = new object();", Difficulty = 7 },
                new Question() {Text = " Find a correct statement about C# exception", CorrectAnswer = "C# exception occrs at run time", Answer1 = "C# exception occrs at compile time", Answer2 = "C# exception occrs at linking time", Answer3 = "C# exception occrs at JIT compile time", Difficulty = 3 },
                new Question() {Text = "Find an invalid Main() method prototype, which is entry point in C#?",CorrectAnswer = "public static long Main(string[] args)", Answer1 = "public static void Main(string[] s)", Answer2 = "public static void Main()", Answer3 = "public static int Main()", Difficulty = 2 },
                new Question() {Text = "Which of the following utilities can be used to compile managed assemblies into processor-specific native code?", CorrectAnswer = "ngen", Answer1 = "gacutil", Answer2 = "sn", Answer3 = "dumpbin", Difficulty = 10 },
                new Question() {Text = "How can you prevent inheritance from a class in C#.NET ?", CorrectAnswer = "Declare the class as sealed", Answer1 = "Declare the class as shadows", Answer2 = "Declare the class as overloads", Answer3 = "Declare the class as override", Difficulty = 2},
                 new Question() { Text = "Which of the following statements is not valid to create new object in C#?", CorrectAnswer = "var a = new IComparable();", Answer1 = "var a = new Int32();", Answer2 = "var a = new String();", Answer3 = "var a = new [] {0};", Difficulty = 7 },
                new Question() { Text = "Which of the following operators cannot use operator overloading?", CorrectAnswer = "operator ||", Answer1 = "operator ++", Answer2 = "operator &", Answer3 = "operator true", Difficulty = 10 },
                new Question() { Text = "Which of the following statements is true about C# anonymous type?", CorrectAnswer = "Anonymous type is an immutable type", Answer1 = "You can use a delegate for a method in anonymous type", Answer2 = "Anonymous type can add an event", Answer3 = "Anonymous type can add new property once it is created", Difficulty = 10 },
                new Question() { Text = "When defining a class using C# Generics, which of the followings is invalid?", CorrectAnswer = "All are correct", Answer1 = "class MyClass where T : struct", Answer2 = "class MyClass where T : class", Answer3 = "class MyClass where T : IComparable", Difficulty = 10 },
                new Question() { Text = "Which of the following statements is incorrect about C# delegate?", CorrectAnswer = "C# delegate can not use +=, -= operators", Answer1 = "C# delegate can be used when passing a reference to a method", Answer2 = "C# delegate is considered as a technical basis of C# event", Answer3 = "C# delegate supports multicast", Difficulty = 10 },
                new Question() { Text = "C# / .NET supports various built-in data structures. Which of the following data structures does not exist as built-in?", CorrectAnswer = "Binary Tree", Answer1 = "Array", Answer2 = "Linked List", Answer3 = "Stack", Difficulty = 6 },
                new Question() { Text = "Find an invalid example of using C# var", CorrectAnswer = "var a = null;", Answer1 = "var a = db.Stores;", Answer2 = "var a = db.Stores.Single(p => p.Id == 1);", Answer3 = "var a = 3.141592;", Difficulty = 6 },
                new Question() { Text = "When you want to provide other resources for other cultures or languages, which assembly should you create?", CorrectAnswer = "Satellite Assembly", Answer1 = "Shared Assembly", Answer2 = "Private Assembly", Answer3 = "Public Assembly", Difficulty = 8 },
                new Question() { Text = "In C#, what is similar to C++ function pointer?", CorrectAnswer = "Delegate", Answer1 = "Event", Answer2 = "Method", Answer3 = "Interface", Difficulty = 7 },
                new Question() { Text = "Which of the following C# methods is not valid? (method body elided)", CorrectAnswer = "private var GetData() {}", Answer1 = "protected override int[] A() {}", Answer2 = "public dynamic Get() {}", Answer3 = "public void Set(dynamic o) {}", Difficulty = 8 },
                new Question() { Text = "What is the top .NET class that everything is derrived from?", CorrectAnswer = "System.Object", Answer1 = "System.Net", Answer2 = "System", Answer3 = "System.Root", Difficulty = 1},
                new Question() { Text = "Assume class B is inherited from class A. Which of the following statements is correct about construction of an object of class B?", CorrectAnswer = "While creating the object firstly the constructor of class A will be called followed by constructor of class B.", Answer1 = "While creating the object firstly the constructor of class B will be called followed by constructor of class A.", Answer2 = "The constructor of only class B will be called", Answer3 = "The constructor of only class B will be called", Difficulty = 4},
                new Question() { Text = "What is stored in Heap ?", CorrectAnswer = "reference type", Answer1 = "int", Answer2 = "enum", Answer3 = "long", Difficulty = 2 },
                new Question() { Text = "Select the control which can’t be placed in the toolbox", CorrectAnswer = "User control", Answer1 = "Custom control", Answer2 = "Server control", Answer3 = "ASP control", Difficulty = 4 },
                new Question() { Text = "Select the class which is immutable", CorrectAnswer = "System.String", Answer1 = "System.Text.StringBuilder", Answer2 = "System.StringBuilder", Answer3 = "System.Text.Builder", Difficulty = 5 },
                new Question() { Text = "Select the method that doesn’t gaurantee the garbage collection of an object.", CorrectAnswer = "Finalize()", Answer1 = "Dispose()", Answer2 = "Open()r", Answer3 = "None of this", Difficulty = 5 },
                new Question() { Text = "Generics are used to make reusable code classes to", CorrectAnswer = "decrease the code redundancy", Answer1 = "improve code performance", Answer2 = "improve code indentation", Answer3 = "improve code documentation", Difficulty = 4 },
                new Question() { Text = "Select the type of exceptions which is NOT used in .Net.", CorrectAnswer = "StackUnderflowException", Answer1 = "NullReferenceException", Answer2 = "OutOfMemoryException", Answer3 = "StackOverflowException", Difficulty = 6 },
                new Question() { Text = "What is used as inheritance operator in C#.", CorrectAnswer = "Colon", Answer1 = "SemiColon", Answer2 = "Dot", Answer3 = "Comma", Difficulty = 2 },
                new Question() { Text = "In c#, the attribute’s information for a Class can be retrieved at", CorrectAnswer = "Runtime", Answer1 = "Compile time", Answer2 = "Both", Answer3 = "None of the above", Difficulty = 2 },
                new Question() { Text = "What is used in conversion where the conversion is defined between the expression and the type.", CorrectAnswer = "Ctype", Answer1 = "directcast", Answer2 = " multicast", Answer3 = "Cttype", Difficulty = 5 },
                new Question() { Text = "An abstract method...", CorrectAnswer = "does not have implementation", Answer1 = "cannot be overriden ", Answer2 = " cannot be public", Answer3 = "does not return any value", Difficulty = 3 },
                new Question() { Text = "Which of the following modifiers can be used with the properties?", CorrectAnswer = "all of above", Answer1 = "protected", Answer2 = "public", Answer3 = "private", Difficulty = 3},
                new Question() { Text = "Which of the following is true?", CorrectAnswer = "try block must have a catch block", Answer1 = "try block must have finally block", Answer2 = "try block must have either catch or finally block", Answer3 = "try block must have both catch or finally block", Difficulty = 4 },
                new Question() { Text = "If an array is declared as below then which of the following statement is true? int[] myArray= new int[];", CorrectAnswer = "myArray is a reference to an object of ‘System.Array’ class", Answer1 = "myArray is a reference to the array", Answer2 = "all of above", Answer3 = "myArray is a reference to an object", Difficulty = 6 },
                new Question() { Text = "Which of the following is true about indexers?", CorrectAnswer = "all of above", Answer1 = "indexers may be used to access class objects", Answer2 = "indexer is a form of property", Answer3 = "indexers refers to location indicators", Difficulty = 8 },
                new Question() { Text = "Select type of caching that will be used if we want to cache a portion of a page instead of the whole page", CorrectAnswer = "Colon", Answer1 = "SemiColon", Answer2 = "Dot", Answer3 = "Comma", Difficulty = 2 },
                new Question() { Text = "In ASP.NET a session ends if a user has not requested or refreshed a page in the application for a specified period. How long is this period - by default?", CorrectAnswer = "After 20 minutes  ", Answer1 = "After 10 minutes  ", Answer2 = "After 40 minutes", Answer3 = "After 30 minutes", Difficulty = 9 },
                new Question() { Text = "Where can we assign value to Static read only member variable of a static class in ASP.NET?", CorrectAnswer = "Default constructor", Answer1 = "Parameterized constructor", Answer2 = "Global.asax", Answer3 = "On click of button", Difficulty = 9 },
                new Question() { Text = "In order to prevent a browser from caching a page which of these statements should be written?", CorrectAnswer = "Response.Cache.SetNoStore();", Answer1 = "None of these", Answer2 = "Response.Cache.SetNoCaching();", Answer3 = "Response.Cache.SetNoServerCaching();", Difficulty = 9 },
                new Question() { Text = "Which of these data source controls do not implement Caching?", CorrectAnswer = "LinqDataSource", Answer1 = "ObjectDataSource", Answer2 = "SqlDataSource", Answer3 = "XmlDataSource", Difficulty = 9 },    
                new Question() { Text = "How do we call methods in remoting Asynchronously in .NET?", CorrectAnswer = "By using Delegates", Answer1 = "By using NEW keyword", Answer2 = "By using pointer", Answer3 = "By using Non-default constructors", Difficulty = 9 }









                );
        }
    }
}

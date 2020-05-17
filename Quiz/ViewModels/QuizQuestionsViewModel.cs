using Java.Lang;
using Newtonsoft.Json;
using Quiz.Models;
using Quiz.Services;
using Quiz.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Quiz.ViewModels
{
    class QuizQuestionsViewModel : INotifyPropertyChanged
    {
        private readonly Api _api = new Api();
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _startQuiz = false;
        private bool _questionLoaded = false;
        private bool _answer1Loaded = false;
        private bool _answer2Loaded = false;
        private bool _answer3Loaded = false;
        private bool _correctAnswerLoaded = false;
        private int _score = 0;
        public int QuestionNumber { get; set; } = 0;
        public int Score { get { return _score; } set { _score = value; PropertyChanged(this, new PropertyChangedEventArgs(nameof(Score))); } }  
        
        public bool StartQuiz {
            get
            {
                return _startQuiz;
            }
            set
            {
                _startQuiz = value;
            }
        }
        private string _correctAnswer;
        public string CorrectAnswer
        {
            get { return _correctAnswer; }
            set
            {
                _correctAnswer = value;
                _correctAnswerLoaded = true;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CorrectAnswer)));
            }
        }
        private string _question;
        public string Question
        {
            get { return _question; }
            set
            {
                _question = value;
                _questionLoaded = true;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Question)));
            }
        }

        private string _answer1;
        public string Answer1
        {
            get { return this._answer1; }
            set
            {
                _answer1 = value;
                _answer1Loaded = true;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Answer1)));
            }
        }



        private string _answer2;
        public string Answer2
        {
            get { return this._answer2; }
            set
            {
                _answer2 = value;
                _answer1Loaded = false;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Answer2)));
            }
        }

        public List<QuestionList> questionList { get; set; }

        private string _answer3;
        public string Answer3
        {
            get { return this._answer3; }
            set
            {
                _answer3 = value;
                _answer3Loaded = true;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Answer3)));
            }
        }
        public bool QuestionLoaded { get { return _questionLoaded; } }
        public bool Answer1Loaded { get { return _answer1Loaded; } }
        public bool Answer2Loaded { get { return _answer2Loaded; } }
        public bool Answer3Loaded { get { return _answer3Loaded; } }
        public bool CorrectAnswerLoaded { get { return _correctAnswerLoaded; } }


        
        public ICommand StartQuizCommand => new Command(async() =>
        {     
            bool getQuestions = await GetQuestions();
            if (getQuestions)
            {
                var newQuestion = NewQuestion();
                CorrectAnswer = newQuestion.CorrectAnswer;
                Answer1 = newQuestion.Answer1;
                Answer2 = newQuestion.Answer2;
                Answer3 = newQuestion.Answer3;
                Question = newQuestion.Text;
                
                if (CorrectAnswerLoaded && Answer1Loaded && Answer2Loaded && Answer3Loaded && QuestionLoaded)
                {

                    StartQuiz = true;
                }
            }
       
            
            
        });

        public ICommand Check => new Command(async(btnText) =>
        {

            if(QuestionNumber == 10)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Your score is" + Score.ToString(), "Ok");
            }
            bool result = checkAnswer(btnText.ToString());
            if (result)
            {
                Score = Score + 1;
            }
            var newQuestion =  NewQuestion();
            CorrectAnswer = newQuestion.CorrectAnswer;
            Answer1 = newQuestion.Answer1;
            Answer2 = newQuestion.Answer2;
            Answer3 = newQuestion.Answer3;
            Question = newQuestion.Text;
            QuestionNumber++;
            
            
            
            
            

        });
        
        public bool checkAnswer(string btnText)
        {
            if (btnText == CorrectAnswer)
            {
                return true;
            }
            else
                return false;
        }
        public async Task<bool> GetQuestions()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, Constants.Api + "api/Questions");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            questionList = JsonConvert.DeserializeObject<List<QuestionList>>(content);
            return true;
            
        }
        public QuestionList NewQuestion()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, questionList.Count);
            return questionList[random];
        }

    }
}

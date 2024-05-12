using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class formGame : Form
    {
        CustomCloseBox customCloseBox = new CustomCloseBox();
        CustomScoreBox customScoreBox = new CustomScoreBox();
        CustomTimeBox customTimeBox = new CustomTimeBox();
        private Random random = new Random();
        private List<Question> questions;
        private List<Question> selectedQuestions;
        private int questionNumber = 1;
        private int questionIndex = 0;
        private int countCorrect = 0;
        private int countIncorrect = 0;
        private int countNull = 0;
        private Timer timer;
        private int time = 15;

        public formGame()
        {
            questions = new List<Question>();
            selectedQuestions = new List<Question>();
            InitializeComponent();
            CreateQuestions();
            CreateRandomQuestions();
            ShowQuestion();
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void CreateQuestions()
        {
            questions = new List<Question>
            {
                new Question("Hangi gezegen Güneş Sistemi'ndeki en büyük gezegendir?", "Jüpiter", new List<string>{"Jüpiter", "Mars", "Venüs", "Neptün"}),
                new Question("Mona Lisa'nın tablosunun yaratıcısı kimdir?", "Leonardo da Vinci", new List<string>{ "Leonardo da Vinci", "Pablo Picasso", "Vincent van Gogh", "Michelangelo"}),
                new Question("Hangi ülkenin bayrağında beyaz bir zambak çiçeği bulunur?", "Hollanda", new List<string>{ "Kanada", "Japonya", "Fransa", "Hollanda"}),
                new Question("Hangi tarihçi, 'Tarihçinin Görevi' adlı eserinde tarihçinin sorumluluklarını anlatmıştır?", "İbn-i Haldun", new List<string>{ "Herodot", "İbn-i Haldun", "Tacitus", "Thucydides"}),
                new Question("Hangi gezegenin uydusu Titan'da sıvı metan denizleri bulunmaktadır?", "Satürn", new List<string>{ "Mars", "Jüpiter", "Uranüs", "Satürn"}),
                new Question("Hangi ülke, 'Matador' adı verilen geleneksel boğa güreşlerine ev sahipliği yapar?", "İspanya", new List<string>{ "İtalya", "İspanya", "Meksika", "Arjantin"}),
                new Question("Hangi ressam, 'Gece Devriyesi' adlı tablosuyla ünlüdür?", "Rembrandt", new List<string>{ "Salvador Dali", "Vincent van Gogh", "Rembrandt", "Claude Monet"}),
                new Question("Hangi kitap, 'Kırk Haramiler' hikayesini anlatır?", "Binbir Gece Masalları", new List<string>{ "İstanbul Hatırası", "Şeker Portakalı", "Binbir Gece Masalları", "Çalıkuşu"}),
                new Question("Hangi yıl, Ay'a ilk insanlı iniş gerçekleştirilmiştir?", "1969", new List<string>{ "1965", "1969", "1973", "1977"}),
                new Question("Hangi bilim dalı, canlıların geçmiş ve şu anki dağılımını inceler?", "Paleontoloji", new List<string>{ "Paleontoloji", "Botanik", "Jeoloji", "Biyoloji"}),
                new Question("Hangi ülkenin milli sporcusu, 'Rüzgar Gibi Geçti' filmine ilham vermiştir?", "Amerika Birleşik Devletleri", new List<string>{ "Brezilya", "İngiltere", "Amerika Birleşik Devletleri", "Fransa"}),
                new Question("Hangi renk, insan zihninde huzur ve dinginlik hissi uyandırdığı bilinir?", "Mavi", new List<string>{ "Kırmızı", "Sarı", "Mavi", "Yeşil"}),
                new Question("Hangi müzik enstrümanı, 'Mozart'ın Piyano Konçertosu No. 21' ile ünlüdür?", "Piyano", new List<string>{ "Keman", "Flüt", "Piyano", "Korno"}),
                new Question("Hangi şehir, Leonardo da Vinci'nin doğduğu yerdir?", "Floransa", new List<string>{ "Floransa", "Venedik", "Roma", "Milano"}),
                new Question("Hangi film, 'En İyi Film' dalında Oscar kazanmamıştır?", "Parazit", new List<string>{ "Titanic", "Yeşil Yol", "Forrest Gump", "Parazit"}),
                new Question("Hangi doğal afet, sismoloji bilim dalının araştırma konusudur?", "Deprem", new List<string>{ "Kasırga", "Deprem", "Tornado", "Tsunami"}),
                new Question("Hangi dil, Latin alfabesini kullanmaz?", "Arapça", new List<string>{ "Rusça", "Arapça", "İtalyanca", "Japonca"}),
                new Question("Hangi gezegen, Güneş Sistemi'ndeki en sıcak gezegendir?", "Venüs", new List<string>{ "Venüs", "Mars", "Jüpiter", "Uranüs"}),
                new Question("Hangi ülke, 'Ulusal Bayrak Günü' kutlamaları sırasında halk dansı olan 'Sirtaki' ile ünlüdür?", "Yunanistan", new List<string>{ "Yunanistan", "Türkiye", "İtalya", "İspanya"}),
                new Question("Hangi yazar, 'Suç ve Ceza' adlı romanıyla tanınır?", "Fyodor Dostoyevski", new List<string>{ "Leo Tolstoy", "Fyodor Dostoyevski", "Franz Kafka", "Victor Hugo"}),
                new Question("Hangi ülkenin başkenti Paris'tir?", "Fransa", new List<string>{"İspanya", "İtalya", "Fransa", "Almanya"}),
                new Question("Hangi yıl, Berlin Duvarı'nın yıkılması gerçekleşmiştir?", "1989", new List<string>{"1985", "1987", "1989", "1991"}),
                new Question("Hangi bilim dalı, ışık, ses ve enerjinin hareketini inceler?", "Fizik", new List<string>{"Biyoloji", "Fizik", "Kimya", "Matematik"}),
                new Question("Hangi ülke, kilise ile devletin ayrılmasını ilk kez yasalaştırmıştır?", "Amerika Birleşik Devletleri", new List<string>{"Amerika Birleşik Devletleri", "İngiltere", "Fransa", "Türkiye"}),
                new Question("Hangi ressam, 'Yıldızlı Gece' adlı tablosuyla ünlüdür?", "Vincent van Gogh", new List<string>{"Claude Monet", "Pablo Picasso", "Vincent van Gogh", "Salvador Dali"}),
                new Question("Hangi hayvan, en yüksek zıplama yeteneğine sahip olduğu bilinir?", "Kanguru", new List<string>{"Kanguru", "Kedi", "Çekirge", "Kurbağa"}),
                new Question("Hangi ülkenin bayrağında bir akrep bulunur?", "Suudi Arabistan", new List<string>{"Meksika", "Avustralya", "Suudi Arabistan", "İsrail"}),
                new Question("Hangi gezegenin uydusu Ganymede, Güneş Sistemi'ndeki en büyük doğal uydu olarak bilinir?", "Jüpiter", new List<string>{"Mars", "Jüpiter", "Satürn", "Uranüs"}),
                new Question("Hangi film, 'The Godfather' serisi olarak da bilinir?", "The Godfather", new List<string>{"Titanic", "The Shawshank Redemption", "The Godfather", "Inception"}),
                new Question("Hangi ülke, 'Fado' müziği ile tanınır?", "Portekiz", new List<string>{"Brezilya", "Portekiz", "Arjantin", "İspanya"}),
                new Question("Hangi yıl, Amerika Birleşik Devletleri'nde köleliğin kaldırılması için Emancipation Proclamation ilan edilmiştir?", "1863", new List<string>{"1776", "1808", "1863", "1901"}),
                new Question("Hangi şehir, 'Kralların Şehri' olarak da bilinir?", "Paris", new List<string>{"Roma", "Paris", "Londra", "Madrid"}),
                new Question("Hangi renk, trafik lambasında durmayı ifade eder?", "Kırmızı", new List<string>{"Yeşil", "Kırmızı", "Sarı", "Mavi"}),
                new Question("Hangi hayvan, 'Bambu Ayı' olarak da bilinir?", "Panda", new List<string>{"Panda", "Koala", "Kanguru", "Tapir"}),
                new Question("Hangi şehir, 'Efsanevi Elmas' olan Koh-i-Noor'un bulunduğu yerdir?", "Londra", new List<string>{"Delhi", "İstanbul", "Londra", "Moskova"}),
                new Question("Hangi ülkenin mutfağında sushi geleneksel bir yemektir?", "Japonya", new List<string>{"Tayland", "Japonya", "Çin", "Hindistan"}),
                new Question("Hangi müzik enstrümanı, 'Toccata ve Füg' adlı eseriyle Johann Sebastian Bach'a atfedilir?", "Org", new List<string>{"Keman", "Org", "Piyano", "Flüt"}),
                new Question("Hangi dönem, Ortaçağ ile Modern Çağ arasında bir geçiş dönemi olarak kabul edilir?", "Rönesans", new List<string>{"Rönesans", "Barok", "Gotik", "Romantizm"}),
                new Question("Hangi gezegen, 'Kırmızı Gezegen' olarak da bilinir?", "Mars", new List<string>{"Venüs", "Jüpiter", "Mars", "Uranüs"}),
                new Question("Hangi bilim dalı, insanların toplumsal davranışlarını ve kurumlarını inceler?", "Sosyoloji", new List<string>{"Antropoloji", "Sosyoloji", "Psikoloji", "Tarih"}),
            };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            time -= 1;
            lblTimer.Text = $"Kalan süre: {time} saniye";
            if (time == 0)
            {
                timer.Stop();
                customTimeBox.ShowDialog();
                countNull++;
                questionIndex++;
                ShowQuestion();
                timer.Start();
            }
        }

        private void ShowQuestion()
        {
            HashSet<int> indexesSet = new HashSet<int>();
            List<int> indexesList = new List<int>();

            while (indexesSet.Count < 4)
            {
                int index = random.Next(0, 4);
                if (!indexesSet.Contains(index))
                {
                    indexesSet.Add(index);
                    indexesList.Add(index);
                }
            }

            if (indexesSet.Count == 4)
            {
                if (questionNumber <= 20)
                {
                    lblQuestionNumber.Text = $"Soru: {questionNumber}";
                    time = 15;
                }
                else
                {
                    lblQuestionNumber.Text = $"Quiz bitti!";
                    time = 0;
                }
                
                lblTimer.Text = $"Kalan süre: {time} saniye";
                if (questionIndex < selectedQuestions.Count)
                {
                    lblQuestions.Text = selectedQuestions[questionIndex].QuestionText;
                    btnA.Text = selectedQuestions[questionIndex].Options[indexesList[0]];
                    btnB.Text = selectedQuestions[questionIndex].Options[indexesList[1]];
                    btnC.Text = selectedQuestions[questionIndex].Options[indexesList[2]];
                    btnD.Text = selectedQuestions[questionIndex].Options[indexesList[3]];
                }
                else
                {
                    int totalPoint = (countCorrect * 5);
                    if (totalPoint < 0)
                    {
                        timer.Stop();
                        totalPoint = 0;
                        string latestscore = $"Toplam soru: {selectedQuestions.Count}\nDoğru sayısı: {countCorrect}\nYanlış sayısı: {countIncorrect}\nBoş Sayısı: {countNull}\nPuan: {totalPoint}";
                        customScoreBox.lblScore.Text = latestscore;
                        customScoreBox.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        timer.Stop();
                        string latestscore = $"Toplam soru: {selectedQuestions.Count}\nDoğru sayısı: {countCorrect}\nYanlış sayısı: {countIncorrect}\nBoş Sayısı: {countNull}\nPuan: {totalPoint}";
                        customScoreBox.lblScore.Text = latestscore;
                        customScoreBox.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (customCloseBox.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveableBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private async void btnOption_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var btn = (Button)sender;
            string answer = btn.Text;
            if (selectedQuestions[questionIndex].IsRightAnswer(answer))
            {
                btn.BackColor = Color.Green;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                await Task.Delay(1000);
                countCorrect++;
                questionNumber++;
            }
            else
            {
                foreach (var optionBtn in new Button[] {btnA, btnB, btnC, btnD})
                {
                    if (selectedQuestions[questionIndex].IsRightAnswer(optionBtn.Text))
                    {
                        btn.BackColor = Color.Red;
                        optionBtn.BackColor = Color.Green;
                        btnA.Enabled = false;
                        btnB.Enabled = false;
                        btnC.Enabled = false;
                        btnD.Enabled = false;
                        await Task.Delay(1000);
                        optionBtn.BackColor = Color.FromArgb(118, 171, 174);
                        break;
                    }
                }
                countIncorrect++;
                questionNumber++;
            }
            questionIndex++;
            ShowQuestion();
            if (lblQuestionNumber.Text == "Quiz bitti!")
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btn.BackColor = Color.FromArgb(118, 171, 174);
        }

        public class Question
        {
            public string QuestionText { get; set; }
            public string RightAnswer { get; set; }
            public List<string> Options { get; set; }

            public Question(string questionText, string rightAnswer, List<string> options)
            {
                QuestionText = questionText;
                RightAnswer = rightAnswer;
                Options = new List<string>(options);
            }

            public void AddOption(string option)
            {
                Options.Add(option);
            }

            public bool IsRightAnswer(string answer)
            {
                return answer == RightAnswer;
            }
        }

        private void CreateRandomQuestions()
        {
            HashSet<int> indexesSet = new HashSet<int>();
            List<int> selectedIndexes = new List<int>();

            while (indexesSet.Count < 20)
            {
                int index = random.Next(0, questions.Count);
                if (!indexesSet.Contains(index))
                {
                    indexesSet.Add(index);
                    selectedIndexes.Add(index);
                }
            }

            foreach (int index in selectedIndexes)
            {
                selectedQuestions.Add(questions[index]);
            }
        }


    }
}
using Timer = System.Windows.Forms.Timer;

namespace Cronos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Load += (_, _) =>
                lblTitulo.Text = $@"Actividades de hoy {DateTime.Today:D}";

            btnStart.Click += (_, _) => Start();
            btnStop.Click += (_, _) => Stop();
            btnReset.Click += (_, _) => Reset();
            btnStartNew.Click += (_, _) => StartNew();

            Shown += (_, _) =>
            {
                timerCronosBindingSource.DataSource = Activities;
                timerCronosBindingSource.ResetBindings(false);
            };
        }

        private ICollection<TimerCronos> Activities { get; set; } = new List<TimerCronos>();

        private int Seconds { get; set; }
        private bool IsRunning { get; set; }

        private Timer Timer { get; set; } = new Timer();

        private void Start()
        {
            IsRunning = true;
            Timer.Tick += Timer_Elapsed;
            Timer.Interval = 1000;
            Timer.Enabled = true;

            Activities.Add(new TimerCronos()
            {
                Index = Activities.Count + 1,
                Activity = txtActivity.Text,
                TimeStarted = 0,
                TimeElapsed = Seconds,
                DateStart = FormatearTiempo(Seconds)
            });

            txtActivity.Text = string.Empty;

            timerCronosBindingSource.ResetBindings(false);
        }

        private void StartNew()
        {
            if (string.IsNullOrEmpty(txtActivity.Text))
                return;

            var current = Activities.LastOrDefault();
            if (current != null)
            {
                current.TimeElapsed = current.TimeStarted + Seconds;
                current.DateStart = FormatearTiempo(current.TimeStarted);
                current.DateEnd = FormatearTiempo(current.TimeElapsed);
            }

            Activities.Add(new TimerCronos()
            {
                Activity = txtActivity.Text,
                Index = Activities.Count + 1,
                TimeStarted = current?.TimeElapsed ?? Seconds,
                DateStart = FormatearTiempo(current?.TimeElapsed ?? Seconds)
            });

            Seconds = 0;
            txtActivity.Text = string.Empty;

            timerCronosBindingSource.ResetBindings(false);
        }

        private void Timer_Elapsed(object? sender, EventArgs e)
        {
            Seconds++;
            lblTime.Text = TimeSpan.FromSeconds(Seconds).ToString(@"hh\:mm\:ss");
            timerCronosBindingSource.ResetBindings(false);
        }

        private void Stop()
        {
            IsRunning = false;
            Timer.Stop();
            var current = Activities.LastOrDefault();
            if (current != null)
            {
                current.TimeElapsed = current.TimeStarted + Seconds;
                current.DateStart = FormatearTiempo(current.TimeStarted);
                current.DateEnd = FormatearTiempo(current.TimeElapsed);
            }

            Seconds = 0;
            txtActivity.Text = string.Empty;

            timerCronosBindingSource.ResetBindings(false);
        }


        private void Reset()
        {
            Seconds = 0;
            Activities.Clear();
            IsRunning = false;
            Timer.Stop();
            lblTime.Text = FormatearTiempo(Seconds);
            timerCronosBindingSource.ResetBindings(false);
        }

        private string FormatearTiempo(int segundos)
        {
            TimeSpan tiempo = TimeSpan.FromSeconds(segundos);
            return tiempo.ToString(@"hh\:mm\:ss");
        }
    }
}
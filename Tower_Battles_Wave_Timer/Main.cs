using Timer = System.Windows.Forms.Timer;

namespace Tower_Battles_Wave_Timer
{
    public partial class Main : Form
    {
        private static readonly double[] _waveTimes = new double[]
        {
            17.10, 20.16, 15.99, 26.94, 22.92,
            33.14, 33.81, 49.10, 36.71, 25.99,
            36.44, 26.07, 31.48, 58.12, 38.05,
            28.52, 88.52, 43.35, 30.13, 30.45,
            44.40, 39.40, 28.67, 36.70, 42.15,
            21.54, 38.05, 27.41, 59.24, 40.16,
            56.34, 48.23, 39.55, 52.22, 44.43,
            71.86, 50.21, 60.36, 102.58
        };

        private Timer _waveTimer = new Timer();
        private bool _gameActive;
        private int _currentWave;
        private int _playerCount;
        private DateTime _waveStartTime;
        private int _currentWaveDurationMs;
        private double _offset;
        private bool _killedWave31;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _waveTimer.Tick += _waveTimer_Tick;
            _waveTimer.Interval = 10;
            cmbPlayerCount.SelectedIndex = 0;
            _playerCount = cmbPlayerCount.SelectedIndex + 1;
            _gameActive = false;
            _killedWave31 = false;

            // Hook up collective event
            nmrcLevel1.ValueChanged += CalculateIncome;
            nmrcLevel2.ValueChanged += CalculateIncome;
            nmrcLevel3.ValueChanged += CalculateIncome;
            nmrcLevel4.ValueChanged += CalculateIncome;
            nmrcLevel5.ValueChanged += CalculateIncome;

            _offset = 0;

            TopMost = true;
        }

        private void _waveTimer_Tick(object? sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int elapsedMs = (int)(now - _waveStartTime).TotalMilliseconds;
            int remainingMs = _currentWaveDurationMs - elapsedMs;

            if (remainingMs <= 0)
            {
                // Wave finished
                _currentWave++;
                if (_currentWave < _waveTimes.Length || _killedWave31)
                {
                    StartNewWave();

                    if (_killedWave31)
                    {
                        _killedWave31 = false;
                    }
                }
                else
                {
                    // All waves finished
                    _waveTimer.Stop();
                    _gameActive = false;
                    lblTimer.Text = "WAVE 40";
                    lblTimerInfo.Text = "";
                    btnStartTimer.Text = "START";
                    cmbPlayerCount.Enabled = true;
                }
            }
            else
            {
                UpdateTimerDisplay(remainingMs);
            }
        }

        private void StartNewWave()
        {
            _waveStartTime = DateTime.Now;

            if (_currentWave != 30)
            {
                _currentWaveDurationMs = (int)((_waveTimes[_currentWave] + _offset) * 1000);
                lblTimerInfo.Text = $"Time left in wave {_currentWave + 1}:";
            }
            else // Wave 31 needs manual input from the user
            {
                btnKilledWave31.Visible = true;

                _waveTimer.Stop();
            }

            if (_currentWave + 2 < WaveInfo.WaveZombies.Length)
            {
                txtZombies.Text = WaveInfo.WaveZombies[_currentWave + 2];
            }
            else
            {
                txtZombies.Text = "";
            }

            int income = (int)Math.Ceiling(213 + 35 * _currentWave + (double)_currentWave / 2);
            lblMoney.Text = $"~{income / _playerCount}$";

            int farmIncome =
                ((int)nmrcLevel1.Value * 50) +
                ((int)nmrcLevel2.Value * 100) +
                ((int)nmrcLevel3.Value * 200) +
                ((int)nmrcLevel4.Value * 500) +
                ((int)nmrcLevel5.Value * 1500);

            lblIncome.Text = $"Income next wave: {farmIncome}\nIncome + wave bonus: {farmIncome + income}";
        }

        private void UpdateTimerDisplay(int remainingMs)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(remainingMs);
            int minutes = time.Minutes;
            int seconds = time.Seconds;
            int milliseconds = time.Milliseconds / 10; // Make sure it's 2 decimal places
            lblTimer.Text = $"{minutes:00}:{seconds:00}.{milliseconds:00}";
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (!_gameActive)
            {
                cmbPlayerCount.Enabled = false;
                txtWaveOffset.Enabled = false;
                chkUseWaveOffset.Enabled = false;

                // Start new game
                btnStartTimer.Text = "RESET";
                _currentWave = 0;
                StartNewWave();
                _waveTimer.Start();
                _gameActive = true;
            }
            else
            {
                cmbPlayerCount.Enabled = true;
                txtWaveOffset.Enabled = true;
                chkUseWaveOffset.Enabled = true;

                // Reset game
                btnStartTimer.Text = "START";
                _waveTimer.Stop();
                _gameActive = false;
                lblTimer.Text = "00:00.00";
                lblTimerInfo.Text = "Time left in wave 1:";
                lblMoney.Text = "";

                txtZombies.Text = "";
            }
        }

        private void chkUseWaveOffset_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseWaveOffset.Checked)
            {
                txtWaveOffset.ReadOnly = false;

                ParseOffset();
            }
            else
            {
                txtWaveOffset.ReadOnly = true;

                _offset = 0;
            }
        }

        private void Main_Click(object sender, EventArgs e) => ActiveControl = null;
        private void cmbPlayerCount_SelectedIndexChanged(object sender, EventArgs e) => _playerCount = cmbPlayerCount.SelectedIndex + 1;
        private void txtWaveOffset_Leave(object sender, EventArgs e) => ParseOffset();

        private void txtWaveOffset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ParseOffset();

                ActiveControl = null;
            }
        }

        private void ParseOffset()
        {
            if (!double.TryParse(txtWaveOffset.Text, out _offset))
            {
                MessageBox.Show("The value you entered is not a number. Please enter a decimal number (for example: 3.14).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _offset = 0;

                txtWaveOffset.Text = "0";
            }
        }

        private void CalculateIncome(object? sender, EventArgs e)
        {
            int income = (int)Math.Ceiling(213 + 35 * _currentWave + (double)_currentWave / 2);

            int farmIncome =
                ((int)nmrcLevel1.Value * 50) +
                ((int)nmrcLevel2.Value * 100) +
                ((int)nmrcLevel3.Value * 200) +
                ((int)nmrcLevel4.Value * 500) +
                ((int)nmrcLevel5.Value * 1500);

            lblIncome.Text = $"Income next wave: {farmIncome}\nIncome + wave bonus: {farmIncome + income}";
        }

        private void btnKilledWave31_Click(object sender, EventArgs e)
        {
            btnKilledWave31.Visible = false;

            _killedWave31 = true;

            _waveTimer.Start();
        }
    }
}
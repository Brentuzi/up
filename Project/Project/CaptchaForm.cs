// CaptchaForm.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class CaptchaForm : Form
    {
        private string captchaText;

        public CaptchaForm()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            captchaText = GenerateRandomCaptcha();
            Bitmap captchaImage = CreateCaptchaImage(captchaText);
            pictureBoxCaptcha.Image = captchaImage;
        }

        private string GenerateRandomCaptcha()
        {
            Random rnd = new Random();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] captchaChars = new char[4];

            for (int i = 0; i < captchaChars.Length; i++)
            {
                captchaChars[i] = alphabet[rnd.Next(alphabet.Length)];
            }

            return new string(captchaChars);
        }

        private Bitmap CreateCaptchaImage(string captcha)
        {
            Random rnd = new Random();

          
            Bitmap captchaImage = new Bitmap(200, 100);
            Graphics g = Graphics.FromImage(captchaImage);

            
            g.Clear(Color.White);

         
            Font font = new Font("Arial", 20);
            PointF textPosition = new PointF(10, 40);
            g.DrawString(captcha, font, Brushes.Black, textPosition);

            
            for (int i = 0; i < 2000; i++)
            {
                int x = rnd.Next(captchaImage.Width);
                int y = rnd.Next(captchaImage.Height);
                captchaImage.SetPixel(x, y, Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)));
            }

            return captchaImage;
        }


        private void buttonSubmitCaptcha_Click(object sender, EventArgs e)
        {
            string enteredCaptcha = textBoxCaptcha.Text;

            if (enteredCaptcha == captchaText)
            {
                DialogResult = DialogResult.OK; 
                Close();
            }
            else
            {
                MessageBox.Show("Неверная CAPTCHA. Попробуйте еще раз.");
                GenerateCaptcha();
            }
        }

        private void textBoxCaptcha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

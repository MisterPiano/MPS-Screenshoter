namespace MPS_Screenshoter
{
    public partial class Form1 : Form
    {
        public static Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = .0;
            Graphics gr = Graphics.FromImage(img as Image);

            gr.CopyFromScreen(0, 0, 0, 0, img.Size);
            Screenshot scr = new Screenshot();
            scr.ShowDialog();
            this.Opacity = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
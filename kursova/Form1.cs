namespace kursova
{
    public partial class Form1 : Form
    {
      
        private int player; 
        public Form1()
        {
            InitializeComponent();
            player = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch(player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
            cheking();

        }
        private void cheking()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if(button1.Text!="")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                MessageBox.Show("Ви перемогли!");
                return;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Ви перемогли!");
                return;
            }
        }
    }
}
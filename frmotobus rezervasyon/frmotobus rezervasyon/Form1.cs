namespace frmotobus_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sira;
        bool rahat = false;
        int ortakapisira;
        bool setrami = false;
        private EventHandler koltuk_Click;
        private readonly int i;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rahat = false;
            setrami = false;
            if (comboBox1.SelectedIndex == 0)
            {
                sira = 12;
                ortakapisira = 6;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sira = 13;
                ortakapisira = 7;
                setrami = true;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sira = 14;
                rahat = true;
                ortakapisira = 8;

            }

            otobusuOlustur();

        }

        private void otobusuOlustur()
        {
            foreach (Button item in panel1.Controls)
            {
                item.Visible = false;
            }

            Button koltuk = new Button();
            int left = 25, top = 20;
            int genislik = 42, yukseklik = 42;
            int numara = 0;
            for (int i = 1; i <= sira; i++)
            {
                numara++;
                left = 25;
                koltuk = new Button();
                koltuk.Size = new System.Drawing.Size(genislik, yukseklik);
                koltuk.Location = new System.Drawing.Point(left, top);
                koltuk.Text = numara.ToString();
                koltuk.Click += new System.EventHandler(koltuk_Click);
                panel1.Controls.Add(koltuk);
                left += genislik + 3;
                if (!rahat)
                {
                    numara++;
                    koltuk = new Button();
                    koltuk.Size = new System.Drawing.Size(genislik, yukseklik);
                    koltuk.Location = new System.Drawing.Point(left, top);
                    koltuk.Text = numara.ToString();
                    koltuk.Click += new System.EventHandler(koltuk_Click);
                    panel1.Controls.Add(koltuk);

                    if (ortakapisira != i && !(setrami && (ortakapisira + 1) == i))
                    {
                        numara++;
                        left += genislik + 42;
                        koltuk = new Button();
                        koltuk.Size = new System.Drawing.Size(genislik, yukseklik);
                        koltuk.Location = new System.Drawing.Point(left, top);
                        koltuk.Click += new System.EventHandler(koltuk_Click);
                        panel1.Controls.Add(koltuk);
                        numara++;
                        left += genislik + 3;
                        koltuk = new Button();
                        koltuk.Size = new System.Drawing.Size(genislik, yukseklik);
                        koltuk.Location = new System.Drawing.Point(left, top);
                        koltuk.Text = numara.ToString();
                        koltuk.Click += new System.EventHandler(koltuk_Click);
                        panel1.Controls.Add(koltuk);
                    }
                    top += 47;
                }


                private void koltuk_Paint(object sender, PaintEventArgs e)

                {
                    frmotobus_rezervasyon rezerv_form= new frmotobus_rezervasyon()

                }
            }
        }
    } }

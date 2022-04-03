namespace CGlab4
{
    public partial class Form1 : Form
    {
        public float[,] kv = new float[4, 3]; // матрица тела
        public float[,] osi = new float[4, 3]; // матрица координат осей
        public float[,] fig = new float[4, 3]; // матрица координат осей
        public float[,] matr_sdv = new float[3, 3]; //матрица преобразования
        public float k, l, k2, l2; // элементы матрицы сдвига k2 и l2 - для сдвига осей
        public bool f = true; //переменная для функции непрерывного сдвига
        public float algoritm = 0;
        public float scaleX = 1;
        public float scaleY = 1;
        public float rotateX = 0;
        public float rotateY = 0;
        public Color color = Color.Blue;
        public int width = 2;

        public Form1()
        {
            InitializeComponent();
        }

        //инициализация матрицы тела
        private void Init_kvadrat()
        {
            kv[0, 0] = -50; kv[0, 1] = 0; kv[0, 2] = 1;
            kv[1, 0] = 0; kv[1, 1] = 50; kv[1, 2] = 1;
            kv[2, 0] = 50; kv[2, 1] = 0; kv[2, 2] = 1;
            kv[3, 0] = 0; kv[3, 1] = -50; kv[3, 2] = 1;
        }

        //инициализация матрицы сдвига
        private void Init_matr_preob(float k1, float l1)
        {
            matr_sdv[0, 0] = scaleX; matr_sdv[0, 1] = rotateX; matr_sdv[0, 2] = 0;
            matr_sdv[1, 0] = rotateY; matr_sdv[1, 1] = scaleY; matr_sdv[1, 2] = 0;
            matr_sdv[2, 0] = k1; matr_sdv[2, 1] = l1; matr_sdv[2, 2] = 1;
        }

        //инициализация матрицы осей
        private void Init_osi()
        {
            osi[0, 0] = -200; osi[0, 1] = 0; osi[0, 2] = 1;
            osi[1, 0] = 200; osi[1, 1] = 0; osi[1, 2] = 1;
            osi[2, 0] = 0; osi[2, 1] = 200; osi[2, 2] = 1;
            osi[3, 0] = 0; osi[3, 1] = -200; osi[3, 2] = 1;
        }

        private void Init_Figure()
        {
            fig[0, 0] = -50; fig[0, 1] = -90; fig[0, 2] = 1;
            fig[1, 0] = -50; fig[1, 1] = -40; fig[1, 2] = 1;
            fig[2, 0] = -30; fig[2, 1] = 10; fig[2, 2] = 1;
            fig[3, 0] = 110; fig[3, 1] = 90; fig[3, 2] = 1;
        }

        //умножение матриц
        private float[,] Multiply_matr(float[,] a, float[,] b)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            float[,] r = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    r[i, j] = 0;
                    for (int ii = 0; ii < m; ii++)
                    {
                        r[i, j] += a[i, ii] * b[ii, j];
                    }
                }
            }
            return r;
        }

        //вывод осей на экран
        private void Draw_osi()
        {
            Init_osi();
            Init_matr_preob(k2, l2);
            float[,] osi1 = Multiply_matr(osi, matr_sdv);
            Pen myPen = new Pen(Color.Red, 1);// цвет линии и ширина
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем ось ОХ
            g.DrawLine(myPen, osi1[0, 0], osi1[0, 1], osi1[1, 0], osi1[1,
            1]);
            // рисуем ось ОУ
            g.DrawLine(myPen, osi1[2, 0], osi1[2, 1], osi1[3, 0], osi1[3,
            1]);
            g.Dispose();
            myPen.Dispose();
        }

        //вывод квадрата на экран
        private void Draw_Kv()
        {
            pictureBox1.Image = null;
            pictureBox1.Update();
            Draw_osi();
            Init_kvadrat(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования
            float[,] kv1 = Multiply_matr(kv, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(color, width);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, kv1[0, 0], kv1[0, 1], kv1[1, 0], kv1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, kv1[1, 0], kv1[1, 1], kv1[2, 0], kv1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, kv1[2, 0], kv1[2, 1], kv1[3, 0], kv1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, kv1[3, 0], kv1[3, 1], kv1[0, 0], kv1[0, 1]);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen

        }

        private void Draw_Fig()
        {
            pictureBox1.Image = null;
            pictureBox1.Update();
            Draw_osi();
            Init_Figure(); //инициализация матрицы тела
            Init_matr_preob(k, l); //инициализация матрицы преобразования
            float[,] fig1 = Multiply_matr(fig, matr_sdv); //перемножение матриц

            Pen myPen = new Pen(color, width);// цвет линии и ширина

            //создаем новый объект Graphics (поверхность рисования) из pictureBox
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            // рисуем 1 сторону квадрата
            g.DrawLine(myPen, fig1[0, 0], fig1[0, 1], fig1[1, 0], fig1[1, 1]);
            // рисуем 2 сторону квадрата
            g.DrawLine(myPen, fig1[1, 0], fig1[1, 1], fig1[2, 0], fig1[2, 1]);
            // рисуем 3 сторону квадрата
            g.DrawLine(myPen, fig1[2, 0], fig1[2, 1], fig1[3, 0], fig1[3, 1]);
            // рисуем 4 сторону квадрата
            g.DrawLine(myPen, fig1[3, 0], fig1[3, 1], fig1[0, 0], fig1[0, 1]);
            g.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            myPen.Dispose(); //освобождвем ресурсы, связанные с Pen
        }

        //Нарисовать квадрат по центру
        private void button2_Click(object sender, EventArgs e)
        {
            //середина pictureBox
            k = pictureBox1.Width / 2;
            l = pictureBox1.Height / 2;
            //вывод квадратика в середине
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        //Нарисовать оси
        private void button1_Click(object sender, EventArgs e)
        {
            k2 = pictureBox1.Width / 2;
            l2 = pictureBox1.Height / 2;
            Draw_osi();
        }

        //Дискретный сдвиг вправо
        private void button4_Click(object sender, EventArgs e)
        {
            k += 5; //изменение соответствующего элемента матрицы сдвигa
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        //Непрерывный сдвиг
        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                algoritm = 1;
            }
            else
            {
                if (radioButton3.Checked == true)
                {
                    algoritm = 2;
                }
                else
                {
                    if (radioButton4.Checked == true)
                    {
                        algoritm = 3;
                    }
                }
            }
            timer1.Interval = 100;

            button8.Text = "Стоп";
            if (f == true)
                timer1.Start();
            else
            {
                timer1.Stop();
                button8.Text = "Старт";
            }
            f = !f;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (algoritm == 0)
            {
                k++;
            }
            else
            {
                if (algoritm == 1)
                {
                    k--;
                }
                else
                {
                    if (algoritm == 2)
                    {
                        l++;
                    }
                    else
                    {
                        l--;
                    }
                }
            }
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
            Thread.Sleep(100);
        }

        //Отчистка поля для рисования
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            scaleX = 1;
            scaleY = 1;
            rotateX = 0;
            rotateY = 0;
        }

        //Дискретный сдвиг влево
        private void button5_Click(object sender, EventArgs e)
        {
            k -= 5; //изменение соответствующего элемента матрицы сдвига
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        //Отразить фигуру
        private void button9_Click(object sender, EventArgs e)
        {
            scaleX = scaleX * (-1);
            Draw_Fig();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Увеличить фигуру
        private void button10_Click(object sender, EventArgs e)
        {
            scaleX = float.Parse(textBox1.Text);
            scaleY = float.Parse(textBox1.Text);
            Draw_Fig();
        }

        //Повернуть фигуру
        private void button11_Click(object sender, EventArgs e)
        {
            float a = (float)(double.Parse(textBox2.Text) * Math.PI / 180);
            //scaleX = (float)Math.Cos(a);
            //scaleY = (float)Math.Cos(a);
            rotateX = -(float)Math.Sin(a);
            rotateY = (float)Math.Sin(a);
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Цвет линии
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            color = colorDialog1.Color;
        }

        //Толщина линии
        private void button13_Click(object sender, EventArgs e)
        {
            width = int.Parse(textBox3.Text);
        }

        //Дискретный сдвиг вниз
        private void button6_Click(object sender, EventArgs e)
        {
            l += 5; //изменение соответствующего элемента матрицы сдвига
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        //Дискретный сдвиг вверх
        private void button7_Click(object sender, EventArgs e)
        {
            l -= 5; //изменение соответствующего элемента матрицы сдвига
            if (radioButton5.Checked == true)
            {
                Draw_Kv();
            }
            else
            {
                if (radioButton6.Checked == true)
                {
                    Draw_Fig();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5OrthogonalProjection
{
	public partial class MainForm : Form
	{
		public int xn, yn, xk, yk;
		Bitmap bitmap;
		Color currentColor = Color.Black;
		Color newColor = Color.Black;
		int lineSize = 2;

		float[][] xAxis;
		float[][] yAxis;

		float[][] rotateVector = new float[][]
			{
				new float[] {0, 0, 1, 1},
				new float[] {0, 0, 0, 1}
			};
		float[][] prismatoidVertices = new float[][]
			{
				new float[] {-100, -50, -50, 1}, // A -->
				new float[] {100, -50, -50, 1},  // B -->
				new float[] {0, 123, -50, 1},      // C -->
				new float[] {-100, -50, -50, 1}, // A -->
				new float[] {0, -50, 50, 1},     // D -->
				new float[] {100, -50, -50, 1},  // B -->
				new float[] {50, 36, 50, 1},     // F -->
				new float[] {0, 123, -50, 1},      // C -->
				new float[] {-50, 36, 50, 1},    // E -->
				new float[] {-100, -50, -50, 1}, // A -->
				new float[] {0, -50, 50, 1},     // D -->
				new float[] {50, 36, 50, 1},     // F -->
				new float[] {-50, 36, 50, 1},    // E -->
				new float[] {0, -50, 50, 1},     // D.
			};
		float[,] prismatoidTranform = new float[4, 4];

		float[][] graphVeritces;

		float tick = 0;

		public MainForm()
		{
			InitializeComponent();

			xAxis = new float[][]
				{
					new float[] {0, PictureBox.Height / 2, 0, 1},
					new float[] {PictureBox.Width, PictureBox.Height / 2, 0, 1}
				};
			yAxis = new float[][]
				{
					new float[] {PictureBox.Width / 2, 0, 0, 1},
					new float[] {PictureBox.Width / 2, PictureBox.Height, 0, 1}
				};

			graphVeritces = new float[(int)(PictureBox.Width * PictureBox.Height)][];
			int index = 0;
			for (int x = 0; x < PictureBox.Width; ++x)
			{
				for (int y = 0; y < PictureBox.Height; ++y)
				{
					int z = (int)(Math.Pow(Math.E, Math.Cos(y) - Math.Pow(x, 2)) * 10);
					graphVeritces[index] = new float[4] { x, y, z, 1 };
					index += 1;
				}
			}

			bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
			PictureBox.Image = bitmap;
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			ClearImage();
		}

		//лишняя функция
		private void PictureBox_MouseUp(object sender, MouseEventArgs e)
		{
		}

		private void SetTransformButton_Click(object sender, EventArgs e)
		{
			try
			{
				SetTransform();
			}
			catch
			{
				MessageBox.Show("Введите корректное значение сдвига матрицы.", "Ошибка");
			}
		}

		private void DrawButton_Click(object sender, EventArgs e)
		{
			ClearImage();
			DrawShapes();
			PictureBox.Refresh();
		}

		//лишняя функция
		private void PictureBox_MouseDown(object sender, MouseEventArgs e)
		{
		}

		private void ColorButton_Click(object sender, EventArgs e)
		{
			DialogResult D = ColorDialog.ShowDialog();
			if (D == System.Windows.Forms.DialogResult.OK)
			{
				currentColor = ColorDialog.Color;
			}
		}

		//применить трансформацию
		public void SetTransform()
		{
			prismatoidTranform = CreateIndetityMatrix();

			float xScale = float.Parse(XScaleTextBox.Text);
			float yScale = float.Parse(YScaleTextBox.Text);
			float zScale = float.Parse(ZScaleTextBox.Text);
			prismatoidTranform = ScaleMatrix(prismatoidTranform, xScale, yScale, zScale);

			rotateVector[0][0] = float.Parse(XTranslateTextBox.Text);
			rotateVector[0][1] = float.Parse(YTranslateTextBox.Text);
			rotateVector[0][2] = float.Parse(ZTranslateTextBox.Text);
			rotateVector[0] = NormalizeVector(rotateVector[0]);
			float angle = (float)(double.Parse(RotateAngleTextBox.Text) * Math.PI / 180);
			prismatoidTranform = RotateMatrixAroundVector(prismatoidTranform, angle, rotateVector[0]);

			float dx = float.Parse(XTranslateTextBox.Text) + PictureBox.Width / 2;
			float dy = float.Parse(YTranslateTextBox.Text) + PictureBox.Height / 2;
			float dz = float.Parse(ZTranslateTextBox.Text);
			prismatoidTranform = TranslateMatrix(prismatoidTranform, dx, dy, dz);
		}

		//нарисовать оси
		public void DrawLines(float[][] vertices, float[,] tranform)
		{
			int vertexCount = vertices.GetLength(0);
			Point[] points = new Point[vertexCount];

			for (int i = 0; i < vertexCount; ++i)
			{
				float[] vertex = vertices[i];
				if (tranform != null)
				{
					vertex = MultiplyVector(tranform, vertices[i]);
				}
				points[i] = new Point((int)vertex[0], (int)vertex[1]);
			}

			Pen pen = new Pen(newColor, lineSize);
			Graphics graphic = Graphics.FromImage(PictureBox.Image);

			for (int i = 0; i < vertexCount - 1; i++)
            {
				graphic.DrawLine(pen, points[i], points[i + 1]);
            }
		}

		private void TimerButton_Click(object sender, EventArgs e)
		{
			Timer.Interval = 10;

			if (TimerButton.Text == "Запустить таймер")
			{
				Timer.Start();
				TimerButton.Text = "Остановить таймер";
			}
			else
			{
				Timer.Stop();
				TimerButton.Text = "Запустить таймер";
			}
		}

		//изменение за один тик
		private void Timer_Tick(object sender, EventArgs e)
		{
			ClearImage();
			RotateAngleTextBox.Text = (tick % 360).ToString();
			SetTransform();
			DrawShapes();
			PictureBox.Refresh();
			tick += 1;
		}

		//нарисовать фигуру
		public void DrawShapes()
		{
			DrawLines(xAxis, null);
			rotateVector[0][0] *= 100;
			rotateVector[0][1] *= 100;
			rotateVector[0][2] *= 100;
			newColor = currentColor;
			lineSize = int.Parse(WidthTextBox.Text);
			DrawLines(prismatoidVertices, prismatoidTranform);
			rotateVector[0][0] /= 100;
			rotateVector[0][1] /= 100;
			rotateVector[0][2] /= 100;
			lineSize = 2;
			newColor = Color.Black;
			DrawLines(yAxis, null);
		}

		//Отчисить поле
		private void ClearImage()
		{
			PictureBox.Image = null;
			bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
			PictureBox.Image = bitmap;
		}

		//создание матрицы
		public float[,] CreateIndetityMatrix()
		{
			float[,] result = new float[4, 4];
			result[0, 0] = 1;
			result[1, 1] = 1;
			result[2, 2] = 1;
			result[3, 3] = 1;
			return result;
		}

		//умножение матриц
		public float[,] MultiplyMatrices(float[,] left, float[,] right)
		{
			int leftRows = left.GetLength(0);
			int leftColums = left.GetLength(1);

			int rightRows = right.GetLength(0);
			int rightColums = right.GetLength(1);
			if (leftColums != rightRows)
			{
				return null;
			}
			float[,] result = new float[leftRows, rightColums];
			for (int i = 0; i < leftRows; ++i)
			{
				for (int j = 0; j < rightColums; ++j)
				{
					result[i, j] = 0;
					for (int ii = 0; ii < leftColums; ++ii)
					{
						result[i, j] += left[i, ii] * right[ii, j];
					}
				}
			}
			return result;
		}

		//нормализованный вектор
		public float[] NormalizeVector(float[] vector)
		{
			float[] result = new float[4];

			double x = Convert.ToDouble(vector[0]);
			double y = Convert.ToDouble(vector[1]);
			double z = Convert.ToDouble(vector[2]);

			float length = (float)Math.Sqrt(Math.Pow(z, 2) +
								  Math.Pow(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)), 2));

			result[0] = vector[0] / length;
			result[1] = vector[1] / length;
			result[2] = vector[2] / length;
			result[3] = 1;

			return result;
		}

		//матрица сдвига
		public float[,] TranslateMatrix(float[,] matrix, float dx, float dy, float dz)
		{
			matrix[0, 3] += dx;
			matrix[1, 3] += dy;
			matrix[2, 3] += dz;
			return matrix;
		}

		//матрица поворота вокруг оси
		public float[,] RotateMatrixAroundVector(float[,] matrix, float angle, float[] vector)
		{
			float ratio = (float)Math.Cos(angle);
			float inverseRatio = (float)Math.Sin(angle);

			float[,] rotation = CreateIndetityMatrix();
			rotation[0, 0] = ratio + (1 - ratio) * vector[0] * vector[0];
			rotation[0, 1] = (1 - ratio) * vector[0] * vector[1] + inverseRatio * vector[2];
			rotation[0, 2] = (1 - ratio) * vector[0] * vector[2] - inverseRatio * vector[1];
			rotation[1, 0] = (1 - ratio) * vector[0] * vector[1] - inverseRatio * vector[2];
			rotation[1, 1] = ratio + (1 - ratio) * vector[1] * vector[1];
			rotation[1, 2] = (1 - ratio) * vector[1] * vector[2] + inverseRatio * vector[0];
			rotation[2, 0] = (1 - ratio) * vector[0] * vector[2] + inverseRatio * vector[1];
			rotation[2, 1] = (1 - ratio) * vector[1] * vector[2] - inverseRatio * vector[0];
			rotation[2, 2] = ratio + (1 - ratio) * vector[2] * vector[2];

			matrix = MultiplyMatrices(rotation, matrix);

			return matrix;
		}

		//матрица поворота из 4 элементов вокруг оси X
		public float[,] RotateMatrixAroundX(float[,] matrix, float angle)
		{
			float[,] rotation = CreateIndetityMatrix();
			rotation[1, 1] = (float)Math.Cos(angle);
			rotation[1, 2] = -(float)Math.Sin(angle);
			rotation[2, 1] = (float)Math.Sin(angle);
			rotation[2, 2] = (float)Math.Cos(angle);
			matrix = MultiplyMatrices(rotation, matrix);
			return matrix;
		}

		//матрица поворота из 4 элементов вокруг оси Y
		public float[,] RotateMatrixAroundY(float[,] matrix, float angle)
		{
			float[,] rotation = CreateIndetityMatrix();
			rotation[0, 0] = (float)Math.Cos(angle);
			rotation[0, 2] = (float)Math.Sin(angle);
			rotation[2, 0] = -(float)Math.Sin(angle);
			rotation[2, 2] = (float)Math.Cos(angle);
			matrix = MultiplyMatrices(rotation, matrix);
			return matrix;
		}

		//матрица поворота из 4 элементов вокруг оси Z
		public float[,] RotateMatrixAroundZ(float[,] matrix, float angle)
		{
			float[,] rotation = CreateIndetityMatrix();
			rotation[0, 0] = (float)Math.Cos(angle);
			rotation[0, 1] = -(float)Math.Sin(angle);
			rotation[1, 0] = (float)Math.Sin(angle);
			rotation[1, 1] = (float)Math.Cos(angle);
			matrix = MultiplyMatrices(rotation, matrix);
			return matrix;
		}

		//матрица масштаба из 4 элементов
		public float[,] ScaleMatrix(float[,] matrix, float xScale, float yScale, float zScale)
		{
			matrix[0, 0] *= xScale;
			matrix[1, 1] *= yScale;
			matrix[2, 2] *= zScale;
			return matrix;
		}

		//умножение матрицы из 4 эл. на вектор из 4 эл.
		public float[] MultiplyVector(float[,] matrix, float[] vec4)
		{
			float[] result = new float[4];
			for (int i = 0; i < 4; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					result[i] += matrix[i, j] * vec4[j];
				}
			}
			return result;
		}
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гаус
{
    public partial class Form1 : Form
    {
        int N = 1;
        int i = 0;
        int j = 0;
        int k = 0;
        double eps = 0.00001;
        double R = 0;
        double[,] A = new double[10, 10];
        double[] B = new double[10];
        double[] X = new double[10];

        public Form1()
        {
            InitializeComponent();
        }

     private   bool Gauss()
        {
       
            for (i = 1; i <= N-1; i++)
            {
                k = i;
                R = Math.Abs(A[i, i]);
                for (j = i + 1; j <= N; j++)
                {
                    if (Math.Abs(A[j, i]) >= R)
                    {
                        k = j;
                        R = Math.Abs(A[j, i]);
                    }
                }
                if (R < 1e-7)
                { return false; }
                if (k != i)
                {
                    R = B[k];
                    B[k] = B[i];
                    B[i] = R;
                    for (j = i; j <= N; j++)
                    {
                        R = A[k, j];
                        A[k, j] = A[i, j];
                        A[i, j] = R;
                    }
                }
                    R = A[i, i];
                    B[i] = B[i] / R;
                    for (j = 1; j <= N; j++)
                    {
                        A[i, j] = A[i, j] / R;
                    }
                    for (k = i + 1; k <= N; k++)
                    {
                        R = A[k, i];
                        B[k] = B[k] - R * B[i];
                        A[k, i] = 0;
                        for (j = i + 1; j <= N; j++)
                        {
                            A[k, j] = A[k, j] - R * A[i, j];
                        }
                    }
                }
                if (Math.Abs(A[N, N]) < 1e-7)
                { return false; }
                X[N] = B[N] / A[N, N];
                for (i = N - 1; i >= 1; i--)
                {
                    R = B[i];
                    for (j = i + 1; j <= N; j++)
                    {
                        R = R - A[i, j] * X[j];
                    }
                    X[i] = R;
                }
                return true;


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            X_vector_dgv.ReadOnly = true;
            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            A_matrix_dgv.ColumnCount = 1;
            A_matrix_dgv.RowCount = 1;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = 1;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = 1;
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);
            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
        }

        private void BСreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;
            for (i = 1; i <= N; i++)
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        A[i, j] = Convert.ToDouble(A_matrix_dgv[j-1, i-1].Value);
                    }
                    catch
                    {
                        A_matrix_dgv[j-1, i-1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                }
            for (j = 0; j < N; j++)
            {
                try
                {
                    B[j+1] = Convert.ToDouble(B_vector_dgv[0, j].Value);
                }
                catch
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
            }
            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка вводу!");
                return;
            }
             if (Gauss() == true)
            {
            for (i = 0; i < N; i++)
            X_vector_dgv[0, i].Value = X[i+1].ToString();
            MessageBox.Show("Розв'язок знайдено");
            }
            else
            { for (i = 0; i < N; i++)
            X_vector_dgv[0, i].Value = "";
            MessageBox.Show("Система вироджена!");
            }  
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    A_matrix_dgv[j, i].Value = "";
            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                X_vector_dgv[0, j].Value = "";
            }
        }

        private void A_matrix_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A_matrix_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void B_vector_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            B_vector_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

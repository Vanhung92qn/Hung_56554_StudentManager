using DevExpress.Utils.Gesture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            // Kiểm tra TextBox txtA và txtB có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Hãy nhập số A!","Thông Báo !",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); // đặt con trỏ vào txtA
                return; // dừng thực hiện tiếp
            }
            if (string.IsNullOrWhiteSpace (txtB.Text))
            {
                MessageBox.Show("Hãy nhập số B !","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtB.Focus(); return;   
            }
            // Chuyển TextBox sang số
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Cộng
            int sum = a + b;
            // Kết Quả
            txtKQ.Text = sum.ToString();
        }
        

        private void txtA_Click(object sender, EventArgs e)
        {

        }

        private void txtKQ_Click(object sender, EventArgs e)
        {

        }

        private void txtB_Click(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            // Kiểm tra TextBox txtA và txtB có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Hãy nhập số A!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); // đặt con trỏ vào txtA
                return; // dừng thực hiện tiếp
            }
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập số B !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); return;
            }
            // Chuyển TextBox sang số
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Trừ
            int sub = a - b;
            // Kết Quả
            txtKQ.Text = sub.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra TextBox txtA và txtB có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Hãy nhập số A!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); // đặt con trỏ vào txtA
                return; // dừng thực hiện tiếp
            }
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập số B !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); return;
            }
            // Chuyển TextBox sang số
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Nhân
            int multiply = a * b;
            // Kết Quả
            txtKQ.Text = multiply.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
             // Kiểm tra TextBox txtA và txtB có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Hãy nhập số A!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); // đặt con trỏ vào txtA
                return; // dừng thực hiện tiếp
            }
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập số B !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); return;
            }
            // Chuyển TextBox sang số
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Chia
            int divide = a / b;
            // Kết Quả
            txtKQ.Text = divide.ToString();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // Kiểm tra TextBox txtA và txtB có rỗng không
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Hãy nhập số A!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus(); // đặt con trỏ vào txtA
                return; // dừng thực hiện tiếp
            }
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                MessageBox.Show("Hãy nhập số B !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus(); return;
            }
            // Chuyển TextBox sang số
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            // Chia
            int modulo = a % b;
            // Kết Quả
            txtKQ.Text = modulo.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();// đóng Form1
           // Application.Exit(); // đóng toàn bộ ứng dụng

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset TextBox , TxtA, TxtB , TxtKQ
            txtA.Text = "";
            txtB.Text = "";
            txtKQ.Text = "";
            // Đặt con trỏ vào TextBox đầu tiên
            txtA.Focus();
        }
    }
}
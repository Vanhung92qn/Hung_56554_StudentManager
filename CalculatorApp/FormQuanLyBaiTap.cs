using DevExpress.XtraBars;
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
    public partial class FormQuanLyBaiTap : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormQuanLyBaiTap()
        {
            InitializeComponent();
            // Bật MDI container cho RibbonForm
            this.IsMdiContainer = true;
            // Khi mở Form, mặc định full màn hình
            this.WindowState = FormWindowState.Maximized;
        }


        /// <summary>
        /// Hàm tiện lợi: mở form con kiểu TForm.
        /// Nếu form đó đã mở thì kích hoạt, không mở mới.
        /// </summary>
        public void OpenOrActivate<TForm>() where TForm : Form, new()
        {
            // Tìm form kiểu TForm đang mở trong MDI
            var existingForm = this.MdiChildren.OfType<TForm>().FirstOrDefault();

            if (existingForm != null)
            {
                // Nếu đã mở rồi, đưa tab đó lên trước
                existingForm.BringToFront();
                existingForm.Activate();
                return;
            }

            // Nếu chưa có -> tạo mới
            TForm frm = new TForm();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent; // căn giữa trong vùng MDI
            frm.WindowState = FormWindowState.Maximized; // full size khi mở
            frm.Show();
        }



        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //// Kiểm tra xem Form1 đã mở chưa
            //foreach (Form f in this.MdiChildren)  // f là biến tự đặt đại diện cho một from trong số các form con đang mở 
            //{
            //    if (f is Form1) // DK nếu f là From1
            //    {
            //        f.BringToFront(); // Đưa Form1 hiện có lên trước (tab active)
            //        // Thoát hàm, không mở form mới
            //        return;
            //    }
            //}
            // Nếu không tìm thấy Form1 trong MDI children, tạo mới
            //Form1 frm1 = new Form1();
            //frm1.StartPosition = FormStartPosition.CenterParent; // căn giữa MDI parent
            //frm1.MdiParent = this; // gán MDI parent
            //frm1.WindowState = FormWindowState.Maximized; // full size
            //frm1.Show(); // hiển thị form dưới dạng tab
            OpenOrActivate<Form1>();
        }

        private void btnBT1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //// Kiểm tra xem Calculator đã mở chưa
            //foreach (Calculator f in this.MdiChildren)  // f là biến tự đặt đại diện cho một from trong số các form con đang mở 
            //{
            //    if (f is Calculator) // DK nếu f là From1
            //    {
            //        f.BringToFront(); // Đưa Calculator hiện có lên trước (tab active)
            //        // Thoát hàm, không mở form mới
            //        return;
            //    }
            //}
            // Nếu không tìm thấy Calculator trong MDI children, tạo mới
            //Calculator frm2 = new Calculator();
            //frm2.StartPosition = FormStartPosition.CenterParent; // căn giữa MDI parent
            //frm2.MdiParent = this; // gán MDI parent
            //frm2.WindowState = FormWindowState.Maximized; // full size
            //frm2.Show(); // hiển thị form dưới dạng tab
            OpenOrActivate<Calculator>();
        }

        private void btnBT2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOrActivate<StudenManager>();
        }
    }
}
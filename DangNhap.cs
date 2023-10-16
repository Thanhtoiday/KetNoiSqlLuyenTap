using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace KetNoiSqlLuyenTap
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void chuyenthanhsao()
        {
            password_txt.PasswordChar= '*';
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            chuyenthanhsao();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) { 
                   this.Close();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void sigiin_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.ToString();
            string password = password_txt.Text.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(StringConnect.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from USERS where USERNAME = @username and URPASSWORD = @password", conn);
                    SqlParameter userparam = new SqlParameter();
                    userparam.ParameterName = "@username";
                    userparam.Value = username;
                    SqlParameter passwordparam = new SqlParameter();
                    passwordparam.ParameterName = "@password";
                    passwordparam.Value = password;
                    cmd.Parameters.Add(passwordparam);
                    cmd.Parameters.Add(userparam);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    if (count != 0)
                    {
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex.Message );
                
            }
        }
    }
}

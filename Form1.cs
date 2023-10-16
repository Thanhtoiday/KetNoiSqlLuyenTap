using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiSqlLuyenTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = getallUser().Tables[0];

            //dataGridView1.DataMember = "USERS";
        }

        DataSet getallUser()
        {
            try
            {
                DataSet data = new DataSet();
                string sql = "select ID 'ID', URNAME 'NAME', PHONE 'PHONE', ABOUT 'ABOUT', URROLE 'ROLE', FAVOURITE 'FAVOURITE' from USERS ";
                using (SqlConnection connection = new SqlConnection(StringConnect.ConnectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.Fill(data);
                    connection.Close();

                }

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong the ket noi!");
            }
            return null;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var name = urname_txt.Text;
            var phone = phone_txt.Text;
            var about = about_txt.Text;
            var role = role_txt.Text;
            var favourite = fav_txt.Text;
            int id = Convert.ToInt32(id_txt.Text);
            try
            {
                using(SqlConnection conn = new SqlConnection(StringConnect.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update USERS set URNAME = @name, PHONE = @phone, ABOUT = @about, URROLE = @role, FAVOURITE = @fav where ID = @id", conn);
                    SqlParameter idparam = new SqlParameter("@id", id);
                    SqlParameter nameparam = new SqlParameter("@name", name);
                    SqlParameter phoneparam = new SqlParameter("@phone", phone);
                    SqlParameter aboutparam = new SqlParameter("@about", about);
                    SqlParameter roleparam = new SqlParameter("@role", role);
                    SqlParameter favparam = new SqlParameter("@fav", favourite);
                    cmd.Parameters.Add(idparam);
                    cmd.Parameters.Add(nameparam);
                    cmd.Parameters.Add(phoneparam);
                    cmd.Parameters.Add(aboutparam);
                    cmd.Parameters.Add(roleparam);
                    cmd.Parameters.Add(favparam);
                    var flag = cmd.ExecuteNonQuery();
                    conn.Close();
                    if(flag == 1)
                    {
                        MessageBox.Show("Cập nhật thành công " + id);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Không thể update");
                
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
           var name = urname_txt.Text;
            var phone = phone_txt.Text;
            var about = about_txt.Text;
            var role = role_txt.Text;
            var favourite = fav_txt.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(StringConnect.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into USERS values(@name,@phone,'','',@about,@role,@favourite)", conn);
                    SqlParameter nameparam = new SqlParameter();
                    nameparam.ParameterName = "@name";
                    nameparam.Value = name;
                    SqlParameter phoneparam = new SqlParameter();
                    phoneparam.ParameterName ="@phone";
                    phoneparam.Value = phone;
                    SqlParameter aboutparam = new SqlParameter();
                    aboutparam.ParameterName = "@about";
                    aboutparam.Value = about;
                    SqlParameter roleparam = new SqlParameter();
                    roleparam.ParameterName = "@role";
                    roleparam.Value = role;
                    SqlParameter favouriteparam = new SqlParameter();
                    favouriteparam.ParameterName = "@favourite";
                    favouriteparam.Value = favourite;
                    cmd.Parameters.Add(nameparam);
                    cmd.Parameters.Add(phoneparam);
                    cmd.Parameters.Add(aboutparam);
                    cmd.Parameters.Add(roleparam);
                    cmd.Parameters.Add(favouriteparam);
                    var flag = cmd.ExecuteNonQuery();
                    conn.Close();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.DataSource = getallUser().Tables[0];

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cần điền");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            id_txt.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            urname_txt.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            phone_txt.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            about_txt.Text  = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
            role_txt.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            fav_txt.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_txt.Text);
            try
            {
                using(SqlConnection conn = new SqlConnection(StringConnect.ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from USERS where ID = @id", conn);
                    SqlParameter idparam = new SqlParameter();
                    idparam.ParameterName = "@id";
                    idparam.Value = id;
                    cmd.Parameters.Add(idparam);
                    var flag = cmd.ExecuteNonQuery();
                    conn.Close();
                    if(flag == 1)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }catch(Exception ex )
            {
                MessageBox.Show("Vui long chọn mục muốn xóa","Thông báo");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieProjectTest
{
    public partial class FrmMovie : Form
    {
        private byte[] movieImg;
        private byte[] dirImage;

        private static void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static string connStr = "Server =AdisornMew\\SQLEXPRESS; Database=movie_record_db;Trusted_connection=true";
        public FrmMovie()
        {
            InitializeComponent();
            LoadDataIntoComboBox();
        }

        private bool IsNewMovie(string movieId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string strSql = "SELECT COUNT(*) FROM movie_tb WHERE movieId = @movieId";
                using (SqlCommand sqlCommand = new SqlCommand(strSql, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@movieId", movieId);
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    return count == 0; // ถ้า 0 แสดงว่าเป็นหนังใหม่
                }
            }
        }

        private void LoadDataIntoComboBox()
        {
            // การเชื่อมต่อฐานข้อมูล
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string strSql = "SELECT movieTypeName FROM movie_type_tb"; // เลือกคอลัมน์ที่ต้องการดึงมาแสดงใน ComboBox

                    // สร้าง command
                    using (SqlCommand sqlCommand = new SqlCommand(strSql, conn))
                    {
                        // สั่งให้ command ทำงาน (Select)
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        // ล้างข้อมูลใน ComboBox ก่อน
                        cbbMovieType.Items.Clear();

                        // อ่านข้อมูลจากฐานข้อมูลและเพิ่มลงใน ComboBox
                        while (reader.Read())
                        {
                            // เพิ่มอีเมล์ลงใน ComboBox
                            cbbMovieType.Items.Add(reader["movieTypeName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                showWarningMSG("เกิดข้อผิดพลาด: " + ex.Message);
            }

        }

        public static string GetNextMovieID()
        {
            string newID = "mv001"; // ค่าเริ่มต้น
            SqlConnection conn = new SqlConnection(connStr);

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            string strSql = "SELECT MAX(movieId) FROM movie_tb";

            SqlCommand sqlCommand = new SqlCommand(strSql, conn);
            object result = sqlCommand.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                string lastID = result.ToString(); 
                int number = int.Parse(lastID.Substring(2)) + 1; // ตัด "MV" ออก แล้วบวก 1
                newID = $"mv{number:D3}"; // ทำให้เป็น 3 หลัก 
            }

            conn.Close();
            return newID;
        }

        private void getMovieFromDBtoDGV()
        {
            // ติดต่อ DB
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();

                // คำสั่ง SQL ที่ดึงข้อมูลจากฐานข้อมูล
                string strSql = "SELECT movieId, movieName, movieDetail, movieDateSale, movieTypeName FROM movie_tb " +
                                "INNER JOIN movie_type_tb ON movie_tb.movieTypeId = movie_type_tb.movieTypeId";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(strSql, conn);
                DataTable dataTable = new DataTable();

                // ดึงข้อมูลจากฐานข้อมูลและเติมลงใน DataTable
                dataAdapter.Fill(dataTable);

                // ล้างข้อมูลเก่าที่แสดงใน DataGridView
                dgvMovieShowAll.Rows.Clear();

                // กำหนด CultureInfo เป็นภาษาไทย
                var thaiCulture = new System.Globalization.CultureInfo("th-TH");

                // เติมข้อมูลลงใน DataGridView โดยใช้ข้อมูลจาก DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // แปลงวันที่จาก DateTime เป็นวันที่ภาษาไทย
                    DateTime movieDateSale = Convert.ToDateTime(row["movieDateSale"]);
                    string dateOnly = movieDateSale.ToString("d MMMM yyyy", thaiCulture); // แสดงวันที่เป็นภาษาไทย

                    // เพิ่มแถวใหม่ใน DataGridView และใส่ข้อมูลจาก DataTable ลงในแต่ละคอลัมน์
                    dgvMovieShowAll.Rows.Add(row["movieId"], row["movieName"], row["movieDetail"], dateOnly, row["movieTypeName"]);
                }
            }
            catch (Exception ex)
            {
                showWarningMSG("เกิดข้อผิดพลาด: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }




        private void FrmMovie_Load(object sender, EventArgs e)
        {
            btSaveAddEdit.Enabled = false;
            btEdit.Enabled = false;
            btDel.Enabled = false;
            groupBox2.Enabled = false;
            btAdd.Enabled = true;
            lbMovieId.Text = "";
            tbMovieName.Clear();
            tbMovieDetail.Clear();
            dtpMovieDateSale.Value = DateTime.Now;
            nudMovieHour.Value = 0;
            nudMovieMinute.Value = 0;
            cbbMovieType.SelectedIndex = 0;
            tbMovieDVDPrice.Text = "0.00";
            tbMovieDVDTotal.Text = "0";
            pcbDirMovie.Image = null;
            pcbMovieImg.Image = null;
            tbMovieSearch.Clear();
            rdMovieId.Checked = true;
            lsMovieShow.Items.Clear();

            getMovieFromDBtoDGV();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            FrmMovie_Load(sender, e);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("คุณต้องการออกจากโปรแกรมใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FrmMovie_Load(sender, e);
            groupBox2.Enabled = true;
            btSaveAddEdit.Enabled = true;
            lbMovieId.Text = GetNextMovieID();
            btAdd.Enabled = false;
        }

        private void tbMovieDVDPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // อนุญาตให้กดปุ่ม Backspace
            if (e.KeyChar == (char)8)
                return;

            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!char.IsDigit(e.KeyChar))
            {
                // ถ้าไม่ใช่ตัวเลข ตรวจสอบว่าเป็นจุดทศนิยมหรือไม่
                if (e.KeyChar == '.')
                {
                    // ถ้าเป็นจุดทศนิยม ตรวจสอบว่ามีจุดอยู่แล้วหรือไม่
                    if (tbMovieDVDPrice.Text.Contains('.'))
                    {
                        e.Handled = true; // ถ้ามีจุดอยู่แล้ว ไม่อนุญาตให้พิมพ์จุดซ้ำ
                    }
                    // ตรวจสอบว่าเป็นตัวอักษรตัวแรกหรือไม่
                    else if (tbMovieDVDPrice.Text.Length == 0)
                    {
                        e.Handled = true; // ไม่อนุญาตให้ตัวแรกเป็นจุด
                    }
                }
                else
                {
                    e.Handled = true; // ถ้าไม่ใช่ตัวเลขและไม่ใช่จุด ไม่อนุญาตให้พิมพ์
                }
            }
        }

        private void tbMovieDVDTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // เช็คว่าเป็นตัวเลขหรือไม่ หรือเป็นปุ่ม Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // ถ้าไม่ใช่ตัวเลขหรือ Backspace จะไม่ให้พิมพ์
            }
        }

        private void nudMovieHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            // เช็คว่าเป็นตัวเลขหรือไม่ หรือเป็นปุ่ม Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // ถ้าไม่ใช่ตัวเลขหรือ Backspace จะไม่ให้พิมพ์
            }
        }

        private void nudMovieMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            // เช็คว่าเป็นตัวเลขหรือไม่ หรือเป็นปุ่ม Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // ถ้าไม่ใช่ตัวเลขหรือ Backspace จะไม่ให้พิมพ์
            }
        }

        private void btSelectImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbMovieImg.Image = Image.FromFile(openFileDialog.FileName);
                movieImg = File.ReadAllBytes(openFileDialog.FileName);
            }

        }

        private void btSelectImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbDirMovie.Image = Image.FromFile(openFileDialog.FileName);
                dirImage = File.ReadAllBytes(openFileDialog.FileName);
            }

        }

        private void btSaveAddEdit_Click(object sender, EventArgs e)
        {
            if (tbMovieName.Text.Trim().Length == 0)
            {
                showWarningMSG("กรุณากรอกชื่อหนัง");
            }
            else if (tbMovieDetail.Text.Trim().Length == 0)
            {
                showWarningMSG("กรุณากรอกรายละเอียดหนัง");
            }
            else if (nudMovieHour.Value <= 0 || nudMovieMinute.Value < 0)
            {
                showWarningMSG("กรุณากรอกเวลาหนัง");
            }
            else if (cbbMovieType.SelectedIndex == -1)
            {
                showWarningMSG("กรุณาเลือกประเภทหนัง");
            }
            else if (tbMovieDVDTotal.Text.Trim().Length == 0 || tbMovieDVDTotal.Text.Trim() == "0")
            {
                showWarningMSG("กรุณากรอกจำนวน DVD");
            }
            else if (tbMovieDVDPrice.Text.Trim().Length == 0 || tbMovieDVDPrice.Text.Trim() == "0.00")
            {
                showWarningMSG("กรุณากรอกราคา DVD");
            }
            else if (movieImg == null)
            {
                showWarningMSG("กรุณาเลือกรูปภาพหนัง");
            }
            else if (dirImage == null)
            {
                showWarningMSG("กรุณาเลือกรูปภาพปก DVD");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlTransaction sqlTransaction = conn.BeginTransaction();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = conn;
                    sqlCommand.Transaction = sqlTransaction;
                    try
                    {
                        string strSql;

                        // ตรวจสอบว่าเป็นข้อมูลใหม่หรือเก่า
                        if (IsNewMovie(lbMovieId.Text)) // ถ้าเป็นหนังใหม่ → INSERT
                        {
                            strSql = "INSERT INTO movie_tb (movieId, movieName, movieDetail, movieDateSale, movieLengthHour, movieLengthMinute, movieTypeId, movieDVDTotal, movieDVDPrice, movieImg, movieDirImg) " +
                                     "VALUES (@movieId, @movieName, @movieDetail, @movieDateSale, @movieLengthHour, @movieLengthMinute, @movieTypeId, @movieDVDTotal, @movieDVDPrice, @movieImg, @movieDirImg)";
                        }
                        else // ถ้ามีอยู่แล้ว → UPDATE
                        {
                            strSql = "UPDATE movie_tb SET movieName=@movieName, movieDetail=@movieDetail, movieDateSale=@movieDateSale, movieLengthHour=@movieLengthHour, " +
                                     "movieLengthMinute=@movieLengthMinute, movieTypeId=@movieTypeId, movieDVDTotal=@movieDVDTotal, movieDVDPrice=@movieDVDPrice, movieImg=@movieImg , movieDirImg=@movieDirImg " +
                                     "WHERE movieId=@movieId";
                        }

                        sqlCommand.CommandText = strSql;

                        // กำหนดค่า Parameter
                        sqlCommand.Parameters.AddWithValue("@movieId", lbMovieId.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@movieName", tbMovieName.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@movieDetail", tbMovieDetail.Text.Trim());
                        sqlCommand.Parameters.AddWithValue("@movieDateSale", dtpMovieDateSale.Value);
                        sqlCommand.Parameters.AddWithValue("@movieLengthHour", nudMovieHour.Value);
                        sqlCommand.Parameters.AddWithValue("@movieLengthMinute", nudMovieMinute.Value);
                        sqlCommand.Parameters.AddWithValue("@movieTypeId", cbbMovieType.SelectedIndex + 1); // ✅ บันทึก Index+1
                        sqlCommand.Parameters.AddWithValue("@movieDVDTotal", Convert.ToInt32(tbMovieDVDTotal.Text));
                        sqlCommand.Parameters.AddWithValue("@movieDVDPrice", Convert.ToDecimal(tbMovieDVDPrice.Text));
                        sqlCommand.Parameters.AddWithValue("@movieImg", movieImg);
                        sqlCommand.Parameters.AddWithValue("@movieDirImg", dirImage);

                        // สั่งให้ SQL ทำงาน
                        sqlCommand.ExecuteNonQuery();
                        sqlTransaction.Commit();
                        showWarningMSG("บันทึกข้อมูลสำเร็จ!");
                        FrmMovie_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        showWarningMSG("เกิดข้อผิดพลาด: " + ex.Message);
                    }
                }
            }


        }

        private void btMovieSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbMovieSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("กรุณาป้อนคำค้นหา");
                return;
            }

            lsMovieShow.Items.Clear(); // ล้างรายการใน ListView ก่อนแสดงผลลัพธ์ใหม่

            if (rdMovieId.Checked)
            {
                SearchByMovieID(searchText);
                groupBox2.Enabled = false;
            }
            else if (rdMovieName.Checked)
            {
                SearchByMovieName(searchText);
                groupBox2.Enabled = false;

            }

            // ตรวจสอบว่ามีรายการใน lsMovieShow หรือไม่
            if (lsMovieShow.Items.Count == 0)
            {
                MessageBox.Show("ไม่พบข้อมูลที่ค้นหา");
            }
        }

        private void SearchByMovieID(string movieId)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT movieId, movieName FROM movie_tb WHERE movieId = @movieId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@movieId", movieId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        ListViewItem item = new ListViewItem("1"); // ลำดับที่ 1 สำหรับการค้นหาด้วยรหัส
                        item.SubItems.Add(reader["movieName"].ToString());
                        item.Tag = reader["movieId"].ToString(); // เก็บ movieId ไว้ใน Tag
                        lsMovieShow.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void SearchByMovieName(string movieName)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT movieId, movieName FROM movie_tb WHERE movieName LIKE @movieName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@movieName", "%" + movieName + "%"); // ใช้ LIKE เพื่อค้นหาบางส่วนของชื่อ

                    SqlDataReader reader = command.ExecuteReader();
                    int count = 1; // เริ่มนับลำดับที่ 1
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(count.ToString()); // แสดงลำดับ
                        item.SubItems.Add(reader["movieName"].ToString());
                        item.Tag = reader["movieId"].ToString(); // เก็บ movieId ไว้ใน Tag
                        lsMovieShow.Items.Add(item);
                        count++; // เพิ่มลำดับ
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void rdMovieId_Click(object sender, EventArgs e)
        {
            lsMovieShow.Items.Clear();
            tbMovieSearch.Clear();
        }

        private void rdMovieName_Click(object sender, EventArgs e)
        {
            lsMovieShow.Items.Clear();
            tbMovieSearch.Clear();
        }


        private void btDel_Click(object sender, EventArgs e)
        {
            if(lsMovieShow.SelectedItems.Count > 0)
    {           
                // ดึง movieId จาก Tag ของ ListViewItem ที่เลือก
                string movieId = lsMovieShow.SelectedItems[0].Tag.ToString();

                DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลภาพยนตร์นี้ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection connection = new SqlConnection(connStr))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM movie_tb WHERE movieId = @movieId";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@movieId", movieId);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("ลบข้อมูลภาพยนตร์สำเร็จ");

                                FrmMovie_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                        }
                    }
                }
            }
    else
            {
                MessageBox.Show("กรุณาเลือกภาพยนตร์ที่ต้องการลบ");
            }



        }

        private void btEdit_Click(object sender, EventArgs e)
        {
           groupBox2.Enabled = true;
            btSaveAddEdit.Enabled = true;
            btAdd.Enabled = false;
            btEdit.Enabled = false;
            btDel.Enabled = false;



        }

        private void lsMovieShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsMovieShow.SelectedItems.Count > 0)
            {
                btAdd.Enabled = false;
                btEdit.Enabled = true;
                btDel.Enabled = true;
                btSaveAddEdit.Enabled = false;
                string movieId = lsMovieShow.SelectedItems[0].Tag.ToString(); // ดึง movieId จาก Tag

                // ดึงข้อมูลภาพยนตร์จากฐานข้อมูลและแสดงในฟอร์ม
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT movieName, movieDetail, movieDateSale, movieLengthHour, movieLengthMinute, movieTypeId, movieDVDTotal, movieDVDPrice, movieImg, movieDirImg FROM movie_tb WHERE movieId = @movieId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@movieId", movieId);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            lbMovieId.Text = movieId;
                            tbMovieName.Text = reader["movieName"].ToString();
                            tbMovieDetail.Text = reader["movieDetail"].ToString();
                            dtpMovieDateSale.Value = Convert.ToDateTime(reader["movieDateSale"]);
                            nudMovieHour.Value = Convert.ToInt32(reader["movieLengthHour"]);
                            nudMovieMinute.Value = Convert.ToInt32(reader["movieLengthMinute"]);
                            cbbMovieType.SelectedIndex = Convert.ToInt32(reader["movieTypeId"]) - 1; // แสดง Index-1
                            tbMovieDVDTotal.Text = reader["movieDVDTotal"].ToString();
                            tbMovieDVDPrice.Text = reader["movieDVDPrice"].ToString();

                            // แสดงรูปภาพ (ถ้ามี)
                            if (reader["movieImg"] != DBNull.Value)
                            {
                                byte[] movieImgBytes = (byte[])reader["movieImg"];
                                using (MemoryStream ms = new MemoryStream(movieImgBytes))
                                {
                                    pcbMovieImg.Image = Image.FromStream(ms);
                                    movieImg = movieImgBytes; // เก็บรูปภาพไว้ในตัวแปร movieImg
                                }
                            }
                            else
                            {
                                pcbMovieImg.Image = null;
                                movieImg = null;
                            }

                            if (reader["movieDirImg"] != DBNull.Value)
                            {
                                byte[] dirImgBytes = (byte[])reader["movieDirImg"];
                                using (MemoryStream ms = new MemoryStream(dirImgBytes))
                                {
                                    pcbDirMovie.Image = Image.FromStream(ms);
                                    dirImage = dirImgBytes; // เก็บรูปภาพไว้ในตัวแปร dirImage
                                }
                            }
                            else
                            {
                                pcbDirMovie.Image = null;
                                dirImage = null;
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                    }
                }
            }
            

        }
    }
}


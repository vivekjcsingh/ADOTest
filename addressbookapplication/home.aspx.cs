using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace addressbookapplication
{
    public partial class home : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            con = new SqlConnection("Data Source=.;Initial Catalog=addressbook;Integrated Security=True");
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "insertdata";
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@firstname", TextBox2.Text);
            com.Parameters.AddWithValue("@lastname", TextBox3.Text);
            com.Parameters.AddWithValue("@email", TextBox4.Text);
            com.Parameters.AddWithValue("@phone",TextBox5.Text);
            con.Open();
            flag=com.ExecuteNonQuery();
            if (flag > 0)
            {
                Label1.Text = "data saved";
            }
            else
            {
                Label1.Text = "data not saved";
            }
            con.Close();
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            con = new SqlConnection("Data Source=.;Initial Catalog=addressbook;Integrated Security=True");
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "deletedata";
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            flag = com.ExecuteNonQuery();
            if (flag > 0)
            {
                Label1.Text = "data deleted";
            }
            else
            {
                Label1.Text = "data not deleted";
            }
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=addressbook;Integrated Security=True");
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select * from addbook where id=" +Convert.ToInt32(TextBox1.Text) + "";
            con.Open();
            dr = com.ExecuteReader();
            con.Close();
            TextBox2.Text = dr[1].ToString();

            TextBox3.Text = dr[2].ToString();
            TextBox4.Text = dr[3].ToString();
            TextBox5.Text = dr[4].ToString();
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int flag = 0;
            con = new SqlConnection("Data Source=.;Initial Catalog=addressbook;Integrated Security=True");
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = ("update addbook set firstname='" + TextBox2.Text + "',lastname='" + TextBox3.Text + "',email='" + TextBox4.Text + "',phone='" + TextBox5.Text + "' where id=" + Convert.ToInt32(TextBox1.Text) + ")");
            con.Open();
            flag= com.ExecuteNonQuery();
            if (flag > 0)
            {
                Label1.Text = "data updated";
            }
            else
            {
                Label1.Text = "data not updated";
            }
            con.Close();
        }

    }
    }

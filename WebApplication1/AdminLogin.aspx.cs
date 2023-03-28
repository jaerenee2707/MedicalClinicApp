using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication1 {
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dob.Attributes.Add("placeholder", "yyyy-mm-dd");
            dob.Attributes.Add("type", "date");
            dob.Attributes.Add("onkeydown", "return false");

        }

        protected void SUBMIT_Click_AddPer(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                // Insert new doctor
                if (jobtype.SelectedValue == "doctor") {
                    string sql = "INSERT INTO doctor (Fname, Mname, Lname, Specialty, DOB, Work_email, Phone_num) VALUES (@fname, @Minitial, @lname, @specialty,  @dob, @email, @phone_num)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@Minitial", mi.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@specialty", specialty.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);

                    command.ExecuteNonQuery();
                }
                if (jobtype.SelectedValue == "nurse") {
                    string sql = "INSERT INTO nurse (Fname, Mname, Lname, Work_email, officeID, Phone_num, DOB) VALUES (@fname, @Minitial, @lname, @email, @office, @phone_num, @dob)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@Minitial", mi.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@specialty", specialty.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@office", office.Text);

                    command.ExecuteNonQuery();
                }
                if (jobtype.SelectedValue == "staff") {
                    string sql = "INSERT INTO staff (Fname, Lname, SRole, Work_email, officeID, Phone_num, DOB) VALUES (@fname, @lname, @role, @email, @office, @phone_num, @dob)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fname.Text);
                    command.Parameters.AddWithValue("@role", role.Text);
                    command.Parameters.AddWithValue("@lname", lname.Text);
                    command.Parameters.AddWithValue("@dob", dob.Text);
                    command.Parameters.AddWithValue("@phone_num", phone_num.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@office", office.Text);

                    command.ExecuteNonQuery();
                }
                //Redirect
                //Response.Redirect("success.aspx?patientID=" + patientID);
            }
            catch (Exception ex)
            {
                //Response.Redirect("unsuccessful.aspx");
                Response.Write("Error: " + ex.Message + '\n' + result);
            }

            connection.Close();
        }
        protected void SUBMIT_Click_AddOff(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                // Insert new office
                    string sql = "INSERT INTO office (officeAddress) VALUES (@address)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@address", address.Text);
                    command.ExecuteNonQuery();
                
                //Redirect
                //Response.Redirect("success.aspx?patientID=" + patientID);
            }
            catch (Exception ex)
            {
                //Response.Redirect("unsuccessful.aspx");
                Response.Write("Error: " + ex.Message + '\n' + result);
            }

            connection.Close();
        }
        protected void SUBMIT_Click_RemPer(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                //  remove a Personnel
                if (jobtype.SelectedValue == "doctor") {
                    string sql = "DELETE FROM doctor WHERE DoctorID = @ID";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", perID.Text);
                    command.ExecuteNonQuery();
                }
                if (jobtype.SelectedValue == "nurse") {
                    string sql = "DELETE FROM nurse WHERE NID = @ID";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", perID.Text);
                    command.ExecuteNonQuery();
                }
                if (jobtype.SelectedValue == "staff") {
                    string sql = "DELETE FROM office WHERE StaffID = @ID";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", perID.Text);
                    command.ExecuteNonQuery();
                }
                //Redirect
                //Response.Redirect("success.aspx?patientID=" + patientID);
            }
            catch (Exception ex)
            {
                //Response.Redirect("unsuccessful.aspx");
                Response.Write("Error: " + ex.Message + '\n' + result);
            }

            connection.Close();
        }
        protected void SUBMIT_Click_RemOff(object sender, EventArgs e)
        {
            string connString = "Server=medicaldatabase3380.mysql.database.azure.com;Database=medicalclinicdb;Uid=dbadmin;Pwd=Medical123!;";
            MySqlConnection connection = new MySqlConnection(connString);

            connection.Open();

            try {
                //  remove a office
                string sql = "DELETE FROM office WHERE officeAddress = @address";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@address", address.Text);
                command.ExecuteNonQuery();

                //Redirect
                //Response.Redirect("success.aspx?patientID=" + patientID);
            }
            catch (Exception ex)
            {
                //Response.Redirect("unsuccessful.aspx");
                Response.Write("Error: " + ex.Message + '\n' + result);
            }

            connection.Close();
        }

        // Get the modal - Add Person
        var modal_addPer = document.getElementById("personnelModal");
        var btn_addPer = document.getElementById("AddPer");
        var span_addPer = document.getElementsByClassName("close")[0];
        btn_addPer.onclick = function () {
            modal_addPer.style.display = "block";
        }
        span_addPer.onclick = function () {
            modal_addPer.style.display = "none";
        }

        // Get the modal - Add Office
        var modal_AddOff = document.getElementById("officeModal");
        var btn_AddOff = document.getElementById("AddOff");
        var span_AddOff = document.getElementsByClassName("close")[0];
        btn_AddOff.onclick = function () {
            modal_AddOff.style.display = "block";
        }
        span_AddOff.onclick = function () {
            modal_AddOff.style.display = "none";
        }
        
        // Get the modal - delete Person
        var modal_DelPer = document.getElementById("delperModal");
        var btn_DelPer = document.getElementById("RemOff");
        var span_DelPer = document.getElementsByClassName("close")[0];
        btn_DelPer.onclick = function () {
            modal_DelPer.style.display = "block";
        }
        span_DelPer.onclick = function () {
            modal_DelPer.style.display = "none";
        }

        // Get the modal - delete Office
        var modal_DelOff = document.getElementById("deloffModal");
        var btn_DelOff = document.getElementById("RemPer");
        var span_DelOff = document.getElementsByClassName("close")[0];
        btn_DelOff.onclick = function () {
            modal_DelOff.style.display = "block";
        }
        span_DelOff.onclick = function () {
            modal_DelOff.style.display = "none";
        }

        //click off any closes it
        window.onclick = function (event) {
            if (event.target == modal_addPer) {
                modal_addPer.style.display = "none";
            }
            if (event.target == modal_AddOff) {
                modal_AddOff.style.display = "none";
            }
            if (event.target == modal_DelPer) {
                modal.style.display = "none";
            }
            if (event.target == modal_DelOff) {
                modal_addPer.style.display = "none";
            }
        }
    }
}

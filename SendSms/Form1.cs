using Nexmo.Api;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Windows.Forms;


namespace SendSms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public static string ConnectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Сontacts.mdb";
        private OleDbConnection connect;


        private void Form1_Load(object sender, EventArgs e)
        {
           
            connect = new OleDbConnection(ConnectString);
            connect.Open();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            TbAPIKey.Text = Properties.Settings.Default.APIkey;
            TbAPIS.Text = Properties.Settings.Default.APISecret;

        }

        private void TBMessege_TextChanged(object sender, EventArgs e)
        {

            string mess = TBMessege.Text;
            int lmess = mess.Length;
            label2.Text = string.Format("Текст сообщения({0}/ 70)",lmess);
        }


        private void CbOtrdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Список контактов(" + Convert.ToString(CbOtrdel.Text) + ")";
            string selectQ = "SELECT * FROM [" + CbOtrdel.Text + "]";
            OleDbCommand command = new OleDbCommand(selectQ, connect);
            OleDbDataReader reader = command.ExecuteReader();
            LsbDB.Items.Clear();
            while (reader.Read())
            {
                LsbDB.Items.Add(reader[1].ToString() + " | " + reader[2].ToString() + " | " + reader[3].ToString());
            }
            reader.Close();

        }

        private void BAddCont_Click(object sender, EventArgs e)
        {
            PAddContact.Location = new Point(BtAddCont.Location.X, BtAddCont.Location.Y + 31);
            label3.Text = "Добавление";
            TbFIO.Text = "";
            TbPosition.Text = "";
            TbNumber.Text = "";

            if (!PAddContact.Visible)
            {
                PAddContact.Visible = true;
            }
            else
            {
                PAddContact.Visible = false;
            }
        }

        private void BtSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Client(creds: new Nexmo.Api.Request.Credentials
                {
                    ApiKey = Properties.Settings.Default.APIkey,
                    ApiSecret = Properties.Settings.Default.APISecret
                });

                var messageType = "unicode";

                string[] words = LsbDB.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string[] FIO = words[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = words[1].Trim(' ');
                string phone = words[2].Trim(' ');

                string[] sim = { " ", "+", "(", ")", "-" };
                foreach (string str in sim)
                {
                    phone = phone.Replace(str, "");
                }
                
                if (phone.Length == 11)
                {
                    phone = phone.Remove(0, 1);
                    var results = client.SMS.Send(request: new SMS.SMSRequest
                    {
                        from = TbTitle.Text,
                        to = "7" + phone,
                        text = TBMessege.Text,
                        type = messageType
                    });
                }
                else
                {

                }
                
            }
            catch(Exception ex)
            {
                if(ex.Message == "Индекс находился вне границ массива.")
                MessageBox.Show("Выберите конткат") ;
                else
                    MessageBox.Show(ex.Message);
            }
        }


        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (label3.Text == "Добавление")
                {
                    try
                    {
                        if (TbNumber.Text.Length < 17 && TbPosition.Text == "" && TbFIO.Text == "")
                        {
                            MessageBox.Show("Одно из полей не заполнено!");
                            return;
                        }
                        else
                        {
                            string insertQ = "INSERT INTO [" + CbOtrdel.Text + "] (ФИО, Должность, [Номер телефона]) VALUES ('" + TbFIO.Text + "', '" + TbPosition.Text + "', '" + TbNumber.Text + "')"; ;
                            OleDbCommand command = new OleDbCommand(insertQ, connect);
                            command.ExecuteNonQuery();
                            LsbDB.Items.Add(TbFIO.Text + " | " + TbPosition.Text + " | " + TbNumber.Text);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Выберите отдел!");
                    }
                }
                else
                {
                    try
                    {
                        
                    

                    string updateQ = "UPDATE [" + CbOtrdel.Text + "] SET ФИО = '" + TbFIO.Text + "', Должность = '" + TbPosition.Text + "', [Номер телефона] = '" + TbNumber.Text + "' WHERE Код = " + id;
                    OleDbCommand command = new OleDbCommand(updateQ, connect);
                    command.ExecuteNonQuery();
                    LsbDB.Items.Remove(LsbDB.SelectedItem);
                    LsbDB.Items.Add(TbFIO.Text + " | " + TbPosition.Text + " | " + TbNumber.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }

                TbFIO.Text = "";
                TbPosition.Text = "";
                TbNumber.Text = "";
                PAddContact.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.Close();
        }
        private string id;
        private void BtEditCont_Click(object sender, EventArgs e)
        {
            try
            {
                PAddContact.Location = new Point(BtEditCont.Location.X, BtEditCont.Location.Y + 31);
                label3.Text = "Редактирование";
                string[] words = LsbDB.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                TbFIO.Text = words[0].Trim(' ');
                TbPosition.Text = words[1].Trim(' ');
                TbNumber.Text = words[2].Trim(' ');

                if (!PAddContact.Visible)
                {
                    PAddContact.Visible = true;
                }
                else
                {
                    PAddContact.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран контакт");
            }
        }

        private void LsbDB_Click(object sender, EventArgs e)
        {
            try
            {
                LbID.Text = "Код: " + (LsbDB.SelectedIndex + 1);
                if (label3.Text == "Редактирование")
                {
                    string[] words = LsbDB.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    TbFIO.Text = words[0].Trim(' ');
                    TbPosition.Text = words[1].Trim(' ');
                    TbNumber.Text = words[2].Trim(' ');
                    string selectQ = "SELECT Код FROM [" + CbOtrdel.Text + "] WHERE ФИО = '" + words[0].Trim(' ') + "'";

                    OleDbCommand command1 = new OleDbCommand(selectQ, connect);
                    id = Convert.ToString(command1.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtDelCont_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите Удалить контакт?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string[] words = LsbDB.Text.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    string name = words[0].Trim(' ');


                    string qw = "SELECT Код FROM [" + CbOtrdel.Text + "] WHERE ФИО = '" + name + "'";
                    OleDbCommand command1 = new OleDbCommand(qw, connect);
                    string id = Convert.ToString(command1.ExecuteScalar());

                    string query = "DELETE FROM [" + CbOtrdel.Text + "] WHERE Код = " + id;
                    OleDbCommand command = new OleDbCommand(query, connect);
                    command.ExecuteNonQuery();
                    LsbDB.Items.Remove(LsbDB.SelectedItem);

                }
                else
                {
                   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TbAPIKey_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.APIkey = TbAPIKey.Text;
            Properties.Settings.Default.Save();
        }

        private void TbAPIS_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.APISecret = TbAPIS.Text;
            Properties.Settings.Default.Save();
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            if (!PSettings.Visible)
            {
                PSettings.Visible = true;
            }
            else
            {
                PSettings.Visible = false;
            }
        }


    }
}

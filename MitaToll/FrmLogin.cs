using MetroFramework.Controls;
using System;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using MitaToll.DAL;
namespace testmultithread
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //try
            //{
            //    Get the current application configuration file.
            //    Configuration config =
            //    ConfigurationManager.OpenExeConfiguration(
            //    ConfigurationUserLevel.None);

            //    MessageBox.Show(config.FilePath);

            //}
            //catch (ConfigurationErrorsException e)
            //{
            //    MessageBox.Show("[Exception error: {0}]", e.ToString());
            //}
        }

        public bool isValid()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is MetroTextBox)
                {
                    MetroTextBox txtBox = ctrl as MetroTextBox;
                    if (txtBox.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool TestKetNoi()
        {
            if (isValid())
            {
                try
                {
                    DbConfig.DbName = txtDatabase.Text;
                    DbConfig.DbServer = txtServer.Text;
                    DbConfig.DbUser = txtUser.Text;
                    DbConfig.DbPass = txtPassword.Text;

                    DBHelper dB = new DBHelper();
                    dB.initConnection();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin!!!");
                return false;
            }
        }

        public string EncryptInfor(string str)
        {
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(2048);

            //how to get the private key

            //and the public key ...
            var privKey = csp.ExportParameters(true);
            var pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, pubKey);
            //get the string from the stream
            pubKeyString = sw.ToString();

            sw = new StringWriter();
            //we need a serializer
            xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, privKey);
            //get the string from the stream
            var privKeyString = sw.ToString();

            //converting it back
            //get a stream from the string
            var sr = new System.IO.StringReader(pubKeyString);
            //we need a deserializer
            xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            pubKey = (RSAParameters)xs.Deserialize(sr);

            //conversion for the private key is no black magic either ... omitted

            //we have a public key ... let's get a new csp and load that key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            //we need some data to encrypt
            var plainTextData = str;

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            var cypherText = Convert.ToBase64String(bytesCypherText);

            return cypherText + ";" + privKeyString;
        }

        public string DecryptData(string str)
        {
            /*
           * some transmission / storage / retrieval
           * 
           * and we want to decrypt our cypherText
           * 
           */
            var plainTextData = "";
            var csp = new RSACryptoServiceProvider(2048);
            string privKeyString;

            privKeyString = str.Split(';')[1];
            //get a stream from the string
            var sr = new StringReader(privKeyString);
            //we need a deserializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            RSAParameters privKey = (RSAParameters)xs.Deserialize(sr);
            csp.ImportParameters(privKey);

            //first, get our bytes back from the base64 string ...
            var bytesCypherText = Convert.FromBase64String(str.Split(';')[0]);

            //decrypt and strip pkcs#1.5 padding
            var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
            return plainTextData;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (TestKetNoi())
            {
                if (ckbSave.Checked)
                {
                    AddUpdateAppSettings("Server", EncryptInfor(txtServer.Text));
                    AddUpdateAppSettings("DatabaseName", EncryptInfor(txtDatabase.Text));
                    AddUpdateAppSettings("UserID", EncryptInfor(txtUser.Text));
                    AddUpdateAppSettings("PassWord", EncryptInfor(txtPassword.Text));
                }
                this.Hide();
                // FrmManHinhChinh FrmManHinhChinh = new FrmManHinhChinh();
                //FrmManHinhChinh.Show();
                new NhanSu().Show();
            }
        }

        private void btnTestKetNoi_Click(object sender, EventArgs e)
        {
            if (TestKetNoi())
            {
                MessageBox.Show("Kết nối thành công");
            }

        }

        private void ckbLuuThongTin_Checked(object sender, EventArgs e)
        {
            if (ckbSave.Checked)
            {
                AddUpdateAppSettings("isSaveInfor", "true");
            }
            else
            {
                AddUpdateAppSettings("isSaveInfor", "fasle");
            }
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (ConfigurationManager.AppSettings["isSaveInfor"].Equals("true"))
                {
                    ckbSave.Checked = true;
                    txtDatabase.Text = DecryptData(ConfigurationManager.AppSettings["DatabaseName"]);
                    txtServer.Text = DecryptData(ConfigurationManager.AppSettings["Server"]);
                    txtUser.Text = DecryptData(ConfigurationManager.AppSettings["UserID"]);
                    txtPassword.Text = DecryptData(ConfigurationManager.AppSettings["Password"]);
                
                }
            }
            catch
            {
                ckbSave.Checked = false;
            }
        }
    }
}

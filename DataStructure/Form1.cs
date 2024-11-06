using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;

namespace DataStructure
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> extensions;
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadDataFile()
        {
            var seralize = new BinaryFormatter();
            using (var stream = File.OpenRead("datafile.dat"))
            {
                extensions = (Dictionary<string, string>)seralize.Deserialize(stream);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            extensions = new Dictionary<string, string>();

            try
            {
                ReadDataFile();
                btnlist_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("unable to load data file" + ex.Message);
            }
        }

        private void Updatedatafile()
        {
            var serializer = new BinaryFormatter();
            using (var stream = File.OpenWrite("datafile.dat"))
            {
                serializer.Serialize(stream, extensions);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string strext = txtextension.Text;
            string strprog = txtprogram.Text;
            if (strext == "" || strprog == "")
            {
                MessageBox.Show("Must have File Extension");
            }
            else
            {
                try
                {
                    extensions.Add(strext, strprog);
                    MessageBox.Show("New Entry Added");
                    txtextension.Clear();
                    txtenter.Clear();
                    txtprogram.Clear();
                    txtdisplay.Clear();
                    txtdisplay.AppendText("File Extension:" + " " + strext + " " + "open with" + " " + strprog);
                    Updatedatafile();
                }
                catch
                {
                    MessageBox.Show("Entry with Key =" + strext + "already Exist");
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear?", "Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtextension.Clear();
                Updatedatafile();
            }
            txtdisplay.Clear();
            txtextension.Clear();
            txtenter.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            String strext = txtextension.Text;
            if (strext == "")
            {
                MessageBox.Show("Must enter extension to delete");
            }
            else
            {
                if (extensions.Remove(strext))
                {
                    MessageBox.Show("Entry for" + " " + strext + " " + "removed");
                    Updatedatafile();
                }
                else
                {
                    MessageBox.Show("No entry with extension" + " " + strext + " " + "to remove");
                    txtextension.Focus();
                    txtdisplay.Clear();
                    txtenter.Clear();
                    txtextension.Clear();
                }
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear();
            txtenter.Clear();
            txtprogram.Clear();
            txtextension.Clear();

            foreach (KeyValuePair<string, string> kvp in extensions)
            {
                txtdisplay.AppendText("File extension: " + kvp.Key + ", " + "it opens with " + kvp.Value + "\n");
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            String key = "";
            String value = "";
            txtdisplay.Clear();
            txtprogram.Clear();
            if (txtenter.Text == "")
            {
                MessageBox.Show("Must Enter Extension to Find");
            }
            else
            {
                key = txtenter.Text;
                if (extensions.TryGetValue(key, out value))
                {
                    txtdisplay.AppendText("File Extension:" + " " + key + " " + "open with" + " " + value);
                }
                else
                {
                    MessageBox.Show("No Entry with Key" + " " + key);
                }
            }
        }

        private void txtenter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
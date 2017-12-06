﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NDSinjector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = "D7B0";
            string txt = textBox1.Text;
            if (txt.Contains(c))
            {
                string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(ckeylocation))
                {
                    writetext.WriteLine(txt);
                }

                MessageBox.Show("The commonkey is correct");
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("The commonkey is incorrect");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c = "1337";
            string txt = textBox2.Text;
            if (txt.Contains(c))
            {
                string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\WWEUTK");

                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(tklocation))
                {
                    writetext.WriteLine(txt);
                }
                MessageBox.Show("The Titlekey is correct");
                textBox2.Enabled = false;

            }
            else
            {
                MessageBox.Show("The Titlekey is incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            string TK = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\TOOLS\Storage\WWEUTK");
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string word = "<ckey>";
            if (File.ReadAllText(cfg).Contains(word))
            {
                MessageBox.Show("There is a match");
                string text = File.ReadAllText(cfg);
                text = text.Replace(word, textBox1.Text);
                File.WriteAllText(cfg, text);
            }
            Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
            System.Diagnostics.Process clientProcess = new Process();
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 00050000101a2000 " + textBox2.Text + " -file .*";
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string ckeycheck = "D7B0";
            string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\WWEUTK");
            string tkey = File.ReadAllText(tklocation);
            string tkeycheck = "1337";
            if (ckey.Contains(ckeycheck))
            {
                textBox1.Text = ckey;
            }
            else
            {
                textBox1.Text = "";
            }
            if (tkey.Contains(tkeycheck))
            {
                textBox2.Text = tkey;
            }
            else
            {
                textBox2.Text = "";
            }
            label1.Visible = false;
            label1.Enabled = false;
            label2.Enabled = true;
            label2.Visible = true;
            label3.Enabled = true;
            label3.Visible = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label9.Enabled = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label8.Enabled = true;
            label9.Visible = true;
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button7.Enabled = true;
            button5.Visible = true;
            button7.Visible = true;
            label7.Enabled = true;
            label7.Visible = true;
            button6.Visible = true;
            button6.Enabled = true;
            button10.Enabled = true;
            button10.Visible = true;
            button11.Enabled = false;
            button11.Visible = false;
            label24.Visible = true;
            label28.Visible = true;
            button21.Visible = true;
            label24.Enabled = true;
            label28.Enabled = true;
            button21.Enabled = true;
            label24.Enabled = true;
            label25.Enabled = true;
            label28.Enabled = true;
            label24.Visible = true;
            label25.Visible = true;
            label28.Visible = true;
            textBox5.Enabled = true;
            textBox5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string sourcefile = tempPath;
                string newfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\WUP-N-DAGP.srl");

                string oldromzip = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\rom.zip");
                string desfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\rom.nds");
                string rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]\content\0010\");
                System.IO.File.Copy(sourcefile, desfile);
                string olddir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGP01]");
                string desdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU");
                File.Move(desfile, newfile);
                File.Delete(oldromzip);
                Directory.Move(olddir, desdir);
                string zip = "7za.exe";
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\7zip\");
                proc.StartInfo.FileName = zip;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = "a ../JNUSTOOL/WarioWareEU/content/0010/rom.zip ../JNUSTOOL/WarioWareEU/content/0010/WUP-N-DAGP.srl";
                proc.Start();
                proc.WaitForExit();
                int exitCode = proc.ExitCode;
                proc.Close();
                string newnewfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\content\0010\WUP-N-DAGP.srl");
                File.Delete(newnewfile);
                button5.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                label6.Enabled = false;
                label7.Enabled = false;
            }



        }

        private void button7_Click(object sender, EventArgs e)
        {
            var oldpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta");
            var oldpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\code");
            var oldpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\content");
            var wwus = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU");
            var newpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\meta");
            var newpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\code");
            var newpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\content");

            Directory.Move(oldpathcode, newpathcode);
            Directory.Move(oldpathcontent, newpathcontent);
            Directory.Move(oldpathmeta, newpathmeta);
            Directory.Delete(wwus);
            var input = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input");
            var output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\output");
            var appname = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\NUSPacker.jar");
            var atb = " -in " + input + " -out " + output + " -encryptKeyWith ";
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string fullpath = appname + atb + ckey;
            MessageBox.Show(fullpath);
            var processInfo = new ProcessStartInfo("java.exe", "-jar " + appname + atb + ckey)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process proc;

            if ((proc = Process.Start(processInfo)) == null)
            {
                throw new InvalidOperationException("??");
            }

            proc.WaitForExit();
            int exitCode = proc.ExitCode;
            proc.Close();
            var packedinstall = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\Injected_VC_Game");
            var endpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Injected_Games\Injected_VC_Game");
            Directory.Move(output, packedinstall);
            Directory.Move(packedinstall, endpath);
            Directory.Delete(newpathcode);
            Directory.Delete(newpathcontent);
            Directory.Delete(newpathmeta);
            label1.Visible = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label2.Visible = false;
            label3.Enabled = false;
            label3.Visible = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label9.Enabled = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            label7.Visible = false;
            label7.Enabled = false;
            label10.Enabled = true;
            label10.Visible = true;
            button9.Visible = true;
            button9.Enabled = true;
            button5.Visible = false;
            button7.Visible = false;
            button6.Visible = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button8.Visible = false;
            button10.Visible = false;
            button10.Enabled = false;
            label12.Enabled = false;
            label12.Visible = false;
            label28.Visible = false;
            label28.Enabled = false;
            label24.Enabled = false;
            label24.Visible = false;
            button21.Enabled = false;
            button21.Visible = false;
            label24.Enabled = false;
            label25.Enabled = false;
            label28.Enabled = false;
            label24.Visible = false;
            label25.Visible = false;
            label28.Visible = false;
            textBox5.Enabled = false;
            textBox5.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string NAME = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\STORAGE\NAME");
            using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(NAME))
            {
                writetext.WriteLine();
            }
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label8.Enabled = false;
            button6.Enabled = false;
            button6.Visible = false;
            button10.Visible = false;
            button10.Enabled = false;
            button8.Enabled = true;
            button8.Visible = true;
            label11.Enabled = true;
            label11.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string olddrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta\bootDrcTex.tga");
            string oldicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta\iconTex.tga");
            string oldlogo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta\bootLogoTex.tga");
            string oldtv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta\bootTvTex.tga");
            string newtv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootTvTex.tga");
            string newdrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootDrcTex.tga");
            string newicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\iconTex.tga");
            string newlogo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootLogoTex.tga");
            File.Delete(olddrc);
            File.Delete(oldicon);
            File.Delete(oldlogo);
            File.Delete(oldtv);
            File.Copy(newtv, oldtv);
            File.Copy(newdrc, olddrc);
            File.Copy(newicon, oldicon);
            File.Copy(newlogo, oldlogo);
            label11.Enabled = false;
            label11.Visible = false;
            button8.Visible = false;
            button8.Enabled = false;
            label12.Enabled = true;
            label12.Visible = true;
        }
        //Wario Ware US
        private void button11_Click(object sender, EventArgs e)
        {
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string ckeycheck = "D7B0";
            string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\WWUSTK");
            string tkey = File.ReadAllText(tklocation);
            string tkeycheck = "efaa";
            if (ckey.Contains(ckeycheck))
            {
                textBox3.Text = ckey;
            }
            else
            {
                textBox3.Text = "";
            }
            if (tkey.Contains(tkeycheck))
            {
                textBox4.Text = tkey;
            }
            else
            {
                textBox4.Text = "";
            }
            textBox3.Enabled = true;
            textBox3.Visible = true;
            textBox4.Enabled = true;
            textBox4.Visible = true;
            label13.Enabled = true;
            label13.Visible = true;
            label14.Enabled = true;
            label14.Visible = true;
            button12.Enabled = true;
            button12.Visible = true;
            button13.Enabled = true;
            button13.Visible = true;
            button14.Enabled = true;
            button14.Visible = true;
            button11.Visible = false;
            button11.Enabled = false;
            label1.Enabled = false;
            label1.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label15.Enabled = true;
            label16.Enabled = true;
            label17.Enabled = true;
            label18.Enabled = true;
            button15.Enabled = true;
            button15.Visible = true;
            label19.Enabled = true;
            label19.Visible = true;
            button17.Enabled = true;
            button17.Visible = true;
            button16.Enabled = true;
            button16.Visible = true;
            label22.Visible = true;
            label22.Enabled = true;
            button19.Enabled = true;
            button19.Visible = true;
            label26.Enabled = true;
            label27.Enabled = true;
            label29.Enabled = true;
            button22.Enabled = true;
            textBox6.Enabled = true;
            label26.Visible = true;
            label27.Visible = true;
            label29.Visible = true;
            button22.Visible = true;
            textBox6.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string c = "D7B0";
            string txt = textBox3.Text;
            if (txt.Contains(c))
            {
                string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(ckeylocation))
                {
                    writetext.WriteLine(txt);
                }

                MessageBox.Show("The commonkey is correct");
                textBox3.Enabled = false;
            }
            else
            {
                MessageBox.Show("The commonkey is incorrect");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string c = "efaa";
            string txt = textBox4.Text;
            if (txt.Contains(c))
            {
                string tklocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\WWUSTK");

                using (System.IO.StreamWriter writetext = new System.IO.StreamWriter(tklocation))
                {
                    writetext.WriteLine(txt);
                }
                MessageBox.Show("The Titlekey is correct");
                textBox4.Enabled = false;

            }
            else
            {
                MessageBox.Show("The Titlekey is incorrect");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string cfg = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\config");
            string TK = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\TOOLS\Storage\WWUSTK");
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string word = "<ckey>";
            if (File.ReadAllText(cfg).Contains(word))
            {
                MessageBox.Show("There is a match");
                string text = File.ReadAllText(cfg);
                text = text.Replace(word, textBox3.Text);
                File.WriteAllText(cfg, text);
            }
            Directory.SetCurrentDirectory(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL"));
            System.Diagnostics.Process clientProcess = new Process(); 
            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = "-jar JNUSTool.jar 00050000101a1f00 " + textBox4.Text +" -file .*";
            clientProcess.Start();
            clientProcess.WaitForExit();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            label13.Enabled = false;
            label14.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                tempPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                string sourcefile = tempPath;
                string newfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGE01]\content\0010\WUP-N-DAGE.srl");

                string oldromzip = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGE01]\content\0010\rom.zip");
                string desfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGE01]\content\0010\rom.nds");
                string rompath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGE01]\content\0010\");
                System.IO.File.Copy(sourcefile, desfile);
                string olddir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWare Touched! [DAGE01]");
                string desdir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS");
                File.Move(desfile, newfile);
                File.Delete(oldromzip);
                Directory.Move(olddir, desdir);
                string zip = "7za.exe";
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\7zip\");
                proc.StartInfo.FileName = zip;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = "a ../JNUSTOOL/WarioWareUS/content/0010/rom.zip ../JNUSTOOL/WarioWareUS/content/0010/WUP-N-DAGE.srl";
                proc.Start();
                proc.WaitForExit();
                int exitCode = proc.ExitCode;
                proc.Close();
                string newnewfile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\content\0010\WUP-N-DAGE.srl");
                File.Delete(newnewfile);
                label15.Enabled = false;
                label16.Enabled = false;
                label17.Enabled = false;
                label18.Enabled = false;
                button15.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not implemented");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button17.Enabled = false;
            button17.Visible = false;
            button18.Enabled = true;
            button18.Visible = true;
            button16.Enabled = false;
            button16.Visible = false;
            label19.Enabled = false;
            label19.Visible = false;
            label20.Visible = true;
            label20.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string olddrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta\bootDrcTex.tga");
            string oldicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta\iconTex.tga");
            string oldlogo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta\bootLogoTex.tga");
            string oldtv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta\bootTvTex.tga");
            string newtv = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootTvTex.tga");
            string newdrc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootDrcTex.tga");
            string newicon = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\iconTex.tga");
            string newlogo = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\GameFiles\bootLogoTex.tga");
            File.Delete(olddrc);
            File.Delete(oldicon);
            File.Delete(oldlogo);
            File.Delete(oldtv);
            File.Copy(newtv, oldtv);
            File.Copy(newdrc, olddrc);
            File.Copy(newicon, oldicon);
            File.Copy(newlogo, oldlogo);
            label20.Enabled = false;
            label20.Visible = false;
            button18.Visible = false;
            button18.Enabled = false;
            label21.Enabled = true;
            label21.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var oldpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta");
            var oldpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\code");
            var oldpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\content");
            var wwus = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS");
            var newpathmeta = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\meta");
            var newpathcode = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\code");
            var newpathcontent = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input\content");
            
            Directory.Move(oldpathcode, newpathcode);
            Directory.Move(oldpathcontent, newpathcontent);
            Directory.Move(oldpathmeta, newpathmeta);
            Directory.Delete(wwus);
            var input = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\input");
            var output = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\output");
            var appname = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\NUSPacker.jar");
            var atb = " -in " + input + " -out " + output + " -encryptKeyWith ";
            string ckeylocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\Storage\CKEY");
            string ckey = File.ReadAllText(ckeylocation);
            string fullpath = appname + atb + ckey;
            MessageBox.Show(fullpath);
            var processInfo = new ProcessStartInfo("java.exe", "-jar " + appname + atb + ckey)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process proc;

            if ((proc = Process.Start(processInfo)) == null)
            {
                throw new InvalidOperationException("??");
            }

            proc.WaitForExit();
            int exitCode = proc.ExitCode;
            proc.Close();
            var packedinstall = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\NUSPACKER\Injected_VC_Game");
            var endpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\Injected_Games\Injected_VC_Game");
            Directory.Move(output, packedinstall);
            Directory.Move(packedinstall, endpath);
            Directory.Delete(newpathcode);
            Directory.Delete(newpathcontent);
            Directory.Delete(newpathmeta);
            textBox3.Enabled = false;
            textBox3.Visible = false;
            textBox4.Enabled = false;
            textBox4.Visible = false;
            label13.Enabled = false;
            label13.Visible = false;
            label14.Enabled = false;
            label14.Visible = false;
            button12.Enabled = false;
            button12.Visible = false;
            button13.Enabled = false;
            button13.Visible = false;
            button14.Enabled = false;
            button14.Visible = false;
            button11.Visible = false;
            button11.Enabled = false;
            label1.Enabled = false;
            label1.Visible = false;
            button4.Enabled = false;
            button4.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label15.Enabled = false;
            label16.Enabled = false;
            label17.Enabled = false;
            label18.Enabled = false;
            button15.Enabled = false;
            button15.Visible = false;
            label19.Enabled = false;
            label19.Visible = false;
            button17.Enabled = false;
            button17.Visible = false;
            button16.Enabled = false;
            button16.Visible = false;
            label22.Visible = false;
            label22.Enabled = false;
            button19.Enabled = false;
            button19.Visible = false;
            label23.Enabled = true;
            label23.Visible = true;
            button20.Enabled = true;
            button20.Visible = true;
            label26.Visible = false;
            label27.Visible = false;
            label29.Visible = false;
            button22.Visible = false;
            textBox6.Visible = false;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //XMLWARIOWAREEU
        private void button21_Click(object sender, EventArgs e)
        {
            string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\meta.xml");
            string Newloc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\meta\meta.xml");
            string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\app.xml");
            string Newloc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareEU\code\app.xml");
            File.Move(Newloc, xmlFile);
            File.Move(Newloc2, xmlFile2);
            var random = new Random();
            var ID = String.Format("{0:X4}", random.Next(0x10000));
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode node = doc.SelectSingleNode("menu/longname_ja");
            XmlNode node2 = doc.SelectSingleNode("menu/longname_en");
            XmlNode node3 = doc.SelectSingleNode("menu/longname_fr");
            XmlNode node4 = doc.SelectSingleNode("menu/longname_de");
            XmlNode node5 = doc.SelectSingleNode("menu/longname_it");
            XmlNode node6 = doc.SelectSingleNode("menu/longname_es");
            XmlNode node7 = doc.SelectSingleNode("menu/longname_zhs");
            XmlNode node8 = doc.SelectSingleNode("menu/longname_ko");
            XmlNode node9 = doc.SelectSingleNode("menu/longname_nl");
            XmlNode node10 = doc.SelectSingleNode("menu/longname_pt");
            XmlNode node11 = doc.SelectSingleNode("menu/longname_ru");
            XmlNode node12 = doc.SelectSingleNode("menu/longname_zht");
            XmlNode node13 = doc.SelectSingleNode("menu/product_code");
            XmlNode node14 = doc.SelectSingleNode("menu/title_id");
            node13.InnerText = "WUP-N-" + ID;
            node14.InnerText = "0005000010" + ID + "00";
            node.InnerText = textBox5.Text;
            node2.InnerText = textBox5.Text;
            node3.InnerText = textBox5.Text;
            node4.InnerText = textBox5.Text;
            node5.InnerText = textBox5.Text;
            node6.InnerText = textBox5.Text;
            node7.InnerText = textBox5.Text;
            node8.InnerText = textBox5.Text;
            node9.InnerText = textBox5.Text;
            node10.InnerText = textBox5.Text;
            node11.InnerText = textBox5.Text;
            node12.InnerText = textBox5.Text;
            XmlNode mode = doc.SelectSingleNode("menu/shortname_ja");
            XmlNode mode2 = doc.SelectSingleNode("menu/shortname_en");
            XmlNode mode3 = doc.SelectSingleNode("menu/shortname_fr");
            XmlNode mode4 = doc.SelectSingleNode("menu/shortname_de");
            XmlNode mode5 = doc.SelectSingleNode("menu/shortname_it");
            XmlNode mode6 = doc.SelectSingleNode("menu/shortname_es");
            XmlNode mode7 = doc.SelectSingleNode("menu/shortname_zhs");
            XmlNode mode8 = doc.SelectSingleNode("menu/shortname_ko");
            XmlNode mode9 = doc.SelectSingleNode("menu/shortname_nl");
            XmlNode mode10 = doc.SelectSingleNode("menu/shortname_pt");
            XmlNode mode11 = doc.SelectSingleNode("menu/shortname_ru");
            XmlNode mode12 = doc.SelectSingleNode("menu/shortname_zht");
            mode.InnerText = textBox5.Text;
            mode2.InnerText = textBox5.Text;
            mode3.InnerText = textBox5.Text;
            mode4.InnerText = textBox5.Text;
            mode5.InnerText = textBox5.Text;
            mode6.InnerText = textBox5.Text;
            mode7.InnerText = textBox5.Text;
            mode8.InnerText = textBox5.Text;
            mode9.InnerText = textBox5.Text;
            mode10.InnerText = textBox5.Text;
            mode11.InnerText = textBox5.Text;
            mode12.InnerText = textBox5.Text;
            doc.Save(xmlFile);
            File.Move(xmlFile, Newloc);
            XmlDocument doc2 = new XmlDocument();
            doc.Load(xmlFile2);
            XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
            node14.InnerText = "0005000010" + ID + "00";
            doc.Save(xmlFile2);
            File.Move(xmlFile2, Newloc2);
            label24.Enabled = false;
            label25.Enabled = false;
            label28.Enabled = false;
            button21.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string xmlFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\meta.xml");
            string Newloc = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\meta\meta.xml");
            string xmlFile2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\EDIT\app.xml");
            string Newloc2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TOOLS\JNUSTOOL\WarioWareUS\code\app.xml");
            File.Move(Newloc, xmlFile);
            File.Move(Newloc2, xmlFile2);
            var random = new Random();
            var ID = String.Format("{0:X4}", random.Next(0x10000));
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);
            XmlNode node = doc.SelectSingleNode("menu/longname_ja");
            XmlNode node2 = doc.SelectSingleNode("menu/longname_en");
            XmlNode node3 = doc.SelectSingleNode("menu/longname_fr");
            XmlNode node4 = doc.SelectSingleNode("menu/longname_de");
            XmlNode node5 = doc.SelectSingleNode("menu/longname_it");
            XmlNode node6 = doc.SelectSingleNode("menu/longname_es");
            XmlNode node7 = doc.SelectSingleNode("menu/longname_zhs");
            XmlNode node8 = doc.SelectSingleNode("menu/longname_ko");
            XmlNode node9 = doc.SelectSingleNode("menu/longname_nl");
            XmlNode node10 = doc.SelectSingleNode("menu/longname_pt");
            XmlNode node11 = doc.SelectSingleNode("menu/longname_ru");
            XmlNode node12 = doc.SelectSingleNode("menu/longname_zht");
            XmlNode node13 = doc.SelectSingleNode("menu/product_code");
            XmlNode node14 = doc.SelectSingleNode("menu/title_id");
            node13.InnerText = "WUP-N-" + ID;
            node14.InnerText = "0005000010" + ID + "00";
            node.InnerText = textBox6.Text;
            node2.InnerText = textBox6.Text;
            node3.InnerText = textBox6.Text;
            node4.InnerText = textBox6.Text;
            node5.InnerText = textBox6.Text;
            node6.InnerText = textBox6.Text;
            node7.InnerText = textBox6.Text;
            node8.InnerText = textBox6.Text;
            node9.InnerText = textBox6.Text;
            node10.InnerText = textBox6.Text;
            node11.InnerText = textBox6.Text;
            node12.InnerText = textBox6.Text;
            XmlNode mode = doc.SelectSingleNode("menu/shortname_ja");
            XmlNode mode2 = doc.SelectSingleNode("menu/shortname_en");
            XmlNode mode3 = doc.SelectSingleNode("menu/shortname_fr");
            XmlNode mode4 = doc.SelectSingleNode("menu/shortname_de");
            XmlNode mode5 = doc.SelectSingleNode("menu/shortname_it");
            XmlNode mode6 = doc.SelectSingleNode("menu/shortname_es");
            XmlNode mode7 = doc.SelectSingleNode("menu/shortname_zhs");
            XmlNode mode8 = doc.SelectSingleNode("menu/shortname_ko");
            XmlNode mode9 = doc.SelectSingleNode("menu/shortname_nl");
            XmlNode mode10 = doc.SelectSingleNode("menu/shortname_pt");
            XmlNode mode11 = doc.SelectSingleNode("menu/shortname_ru");
            XmlNode mode12 = doc.SelectSingleNode("menu/shortname_zht");
            mode.InnerText = textBox6.Text;
            mode2.InnerText = textBox6.Text;
            mode3.InnerText = textBox6.Text;
            mode4.InnerText = textBox6.Text;
            mode5.InnerText = textBox6.Text;
            mode6.InnerText = textBox6.Text;
            mode7.InnerText = textBox6.Text;
            mode8.InnerText = textBox6.Text;
            mode9.InnerText = textBox6.Text;
            mode10.InnerText = textBox6.Text;
            mode11.InnerText = textBox6.Text;
            mode12.InnerText = textBox6.Text;
            doc.Save(xmlFile);
            File.Move(xmlFile, Newloc);
            XmlDocument doc2 = new XmlDocument();
            doc.Load(xmlFile2);
            XmlNode n2ode = doc.SelectSingleNode("menu/title_id");
            node14.InnerText = "0005000010" + ID + "00";
            doc.Save(xmlFile2);
            File.Move(xmlFile2, Newloc2);
            label26.Enabled = false;
            label27.Enabled = false;
            label29.Enabled = false;
            button22.Enabled = false;
            textBox6.Enabled = false;
        }
    }
    }
    
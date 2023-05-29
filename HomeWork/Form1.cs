using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;



namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            size();
        }
        static string PathOriginal = "";
        static string PathCopy = "";
        private void size()
        {
            int x = this.Width = 440;
            int y = this.Height = 260;
            var CBSize = new Size(x, y);
            this.MinimumSize = this.MaximumSize = this.Size = CBSize;
        }
        private string Path()
        {
            string Path = "";
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {               
                Path = dialog.FileName;               
            }
            return Path;

        }

        private void button_open_MouseClick(object sender, MouseEventArgs e)
        {
            PathOriginal=Path();
            textBox_path.Text = PathOriginal;          
        }

        private void button_saveCopy_MouseClick(object sender, MouseEventArgs e)
        {
            PathCopy=Path();
            textBox_pathSave.Text = PathCopy;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Parallel_();
        }

        private void Parallel_()
        {
            Task.Run(() =>
            {
                try
                {
                    string[] files = Directory.GetFiles(PathOriginal,
                                        "*.jpg",
                                        SearchOption.AllDirectories);
                    Record(PathCopy + @"\ОтчетParallel.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} Paralle Запущен");
                    Parallel.ForEach(files,
                     item =>
                     {
                         string filename = System.IO.Path.GetFileName(item);
                         using (Bitmap bitmap = new Bitmap(item))
                         {
                             bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                             string modFile = System.IO.Path.Combine(PathCopy, filename + ".Parallel.jpeg");

                             bitmap.Save(modFile);
                         }
                     });
                    Record(PathCopy + @"\ОтчетParallel.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} Paralle Закончен");
                    
                }
                catch { }
                finally { MessageBox.Show("Все готово!!!"); }

            });

        }


        private void Task_()
        {
            
            Task.Run(() =>
            {
                try
                {
                    string[] files = Directory.GetFiles(PathOriginal,
                                        "*.jpg",
                                        SearchOption.AllDirectories);
                    Record(PathCopy + @"\ОтчетTask.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} TASK Запущен");
                    foreach (var item in files)
                    {
                        string filename = System.IO.Path.GetFileName(item);
                        using (Bitmap bitmap = new Bitmap(item))
                        {
                            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            string modFile = System.IO.Path.Combine(PathCopy, filename + ".TASK.jpeg");
                            bitmap.Save(modFile);
                        }
                    }
                    Record(PathCopy + @"\ОтчетTask.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} TASK Закончен");
                   
                }
                catch { }
                finally { MessageBox.Show("Все готово!!!"); }

            });

        }
        private void Thrade_()
        {
          
           
                Thread tr = new Thread(
                    () =>
                    {
                        tmpThrade();
                    });

                tr.Start();
               
            
            

        }
        private void tmpThrade() 
        {
            object locker = new object();
            lock (locker)
            {
                try
                {
                    Record(PathCopy + @"\ОтчетTHRADE.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} THRADE Запущен");
                    string[] files = Directory.GetFiles(PathOriginal,
                                        "*.jpg",
                                        SearchOption.AllDirectories);

                    foreach (var item in files)
                    {
                        string filename = System.IO.Path.GetFileName(item);
                        using (Bitmap bitmap = new Bitmap(item))
                        {
                            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            string modFile = System.IO.Path.Combine(PathCopy, filename + ".THRADE.jpeg");
                            bitmap.Save(modFile);
                        }
                    };
                    Record(PathCopy + @"\ОтчетTHRADE.txt", $"{(DateTime.Now.ToString("HH:mm:ss.fffff"))} THRADE Закончен");
                }
                catch { }
                finally { MessageBox.Show("Все готово!!!"); }
            }
        }

        private void Record(string path, string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
        }

        private void button_Task_MouseClick(object sender, MouseEventArgs e)
        {
            Task_();
        }

        private void button_Thrade_MouseClick(object sender, MouseEventArgs e)
        {
            Thrade_();
        }
    }
}

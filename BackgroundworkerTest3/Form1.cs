using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BackgroundWorkerTest3
{
    public partial class Form1 : Form
    {
        int g_dellCnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeBackgroundWorker()
        {
            _bw.DoWork += new DoWorkEventHandler(_bw_DoWork);
            _bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_bw_RunWorkerCompleted);
            _bw.ProgressChanged += new ProgressChangedEventHandler(_bw_ProgressChanged);
        }

        private void _bw_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void _bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void _bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bw.WorkerReportsProgress = true;
            _bw.WorkerSupportsCancellation = true;
            StreamReader _sr = new StreamReader(Application.StartupPath + "\\" + "Dell Data +5c_0714_00.csv");
            Console.WriteLine("button click");
            Console.WriteLine("g_dellCnt:{0}", g_dellCnt);
            //if (_bw.IsBusy != true)
            //{
            //    // Start the asynchronous operation.
            //    _bw.RunWorkerAsync();
            //}
            GetDellDataCount();
            printdata();
        }
        #region GetDellDataCnt
        private void GetDellDataCount()
        {
            Console.WriteLine("GetDellDataCount");
            StreamReader _reader = new StreamReader(Application.StartupPath + "\\" + "Dell Data +5c_0714_00.csv");
            while (!_reader.EndOfStream)
            {
                _reader.ReadLine();
                g_dellCnt++;
            }
            g_dellCnt = g_dellCnt - 1;
            _reader.Close();
            _reader.Dispose();
        }
        #endregion
        #region listboxDataShow
        private void printdata()
        {
            StreamReader _reader = new StreamReader(Application.StartupPath + "\\" + "Dell Data +5c_0714_00.csv");
            string _line = _reader.ReadLine();
            string[] _tempArray = null;
            while (!_reader.EndOfStream)
            {
                //Console.WriteLine(_line);
                _tempArray = _reader.ReadLine().Split(',');
                Console.WriteLine("_tempArray[0]:{0}", _tempArray[0]);
                listBox1.Invoke(new Action(() => listBox1.Items.Add(_tempArray[0] + _tempArray[1] + _tempArray[2])));
                switch (int.Parse(_tempArray[0]) / 10)
                {
                    case 0:
                        Console.WriteLine("0~10");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                    case 1:
                        Console.WriteLine("11~19");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                    case 2:
                        Console.WriteLine("20~29");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                    case 3:
                        Console.WriteLine("30~39");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                    case 4:
                        Console.WriteLine("40~49");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                    case 5:
                        Console.WriteLine("50~59");
                        if (_bw.IsBusy != true)
                        {
                            // Start the asynchronous operation.
                            _bw.RunWorkerAsync();
                        }
                        break;
                }
            }
            //if (_bw.IsBusy != true)
            //{
            //    // Start the asynchronous operation.
            //    _bw.RunWorkerAsync();
            //}
            _reader.Close();
            _reader.Dispose();

        }
        #endregion
    }
}

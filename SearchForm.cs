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
using System.Text.RegularExpressions;


namespace TextSearch
{
    /// <summary>
    /// 指定されたディレクトリ内のテキストファイルを検索する
    /// </summary>
    public partial class SearchForm : Form
    {
        string target = "";
        string output = "";
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        // <検索文字列, 行数>
        Dictionary<string, int> dic = new Dictionary<string, int>();


        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初画面表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //最初に選択されているフォルダ、ファイルパスを指定する
            fbd.SelectedPath = @"C:\Users\sayur\source\MIT\02_20180823\Kadai2\grep_test";
            directory.Text = fbd.SelectedPath;

            //ファイルパス：検索対象ディレクトリの中
            output = fbd.SelectedPath + @"\grep.txt";
            filePass.Text = output;
        }

        /// <summary>
        /// フォルダを参照する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brouseButton_Click(object sender, EventArgs e)
        {
            directory.Text = fbd.SelectedPath;
            // ユーザーが新しいフォルダを作成できるようにする
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                directory.Text = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// 検索文字列を指定
        /// </summary>
        private void serchText_TextChanged(object sender, EventArgs e)
        {
            target = serchText.Text;
        }

        /// <summary>
        /// 検索対象ディレクトリを指定
        /// </summary>
        private void directory_TextChanged(object sender, EventArgs e)
        {
            fbd.SelectedPath = directory.Text;
        }

        /// <summary>
        /// 出力ファイルパス
        /// </summary>
        private void filePass_TextChanged(object sender, EventArgs e)
        {
           output = filePass.Text;
        }

        /// <summary>
        /// 検索ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kensakuButton_Click(object sender, EventArgs e)
        {
            // 再帰
            SearchText(fbd.SelectedPath);
            
            // メッセージボックスを表示する
            DialogResult result = MessageBox.Show("検索を続けますか？",
                "出力完了！",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                serchText.Text = "";
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時
                Application.Exit();
            }
        }

        /// <summary>
        /// パスを受け取ってそのディレクトリ内を検索（再帰）
        /// </summary>
        /// <param name="dir"></param>
        private void SearchText(string dir)
        {
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
          
            try
            {
                // ディレクトリを検索
                foreach (var d in Directory.GetDirectories(dir))
                {
                    // 子ディレクトリを検索
                    SearchText(d);
                }
                Console.WriteLine(dir);
                // ファイルを検索
                foreach (var f in Directory.GetFiles(dir, "*.txt"))
                {
                    using (StreamWriter writer = new StreamWriter(output, false, enc))
                    {
                        int cnt = 0;
                        // txtファイルを1行ずつ読み込む
                        foreach (var line in File.ReadLines(f))
                        {
                            cnt++;
                            if (line.Contains(target))
                                writer.WriteLine("{0}行目：{1}", cnt, line);
                        }
                    }

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                return;
            }
            

                
        }
    }
}

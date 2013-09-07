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

namespace QTViewer
{
    public partial class QTFullScreenViewer : Form
    {
        public QTFullScreenViewer()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // ◆モニタサイズを取得（複数の場合も対応）
            // モニタサイズ保持用の構造体を生成
            Rectangle screenRectangle = new Rectangle(0, 0, 0, 0);

            // ディスプレイの解像度を取得するには？
            // http://www.atmarkit.co.jp/fdotnet/dotnettips/003screen/screen.html
            foreach (Screen s in Screen.AllScreens)
            {
                //Console.WriteLine(s.Bounds);
                screenRectangle.X = Math.Min(screenRectangle.X, s.Bounds.X);
                screenRectangle.Y = Math.Min(screenRectangle.Y, s.Bounds.Y);

                screenRectangle.Width = Math.Max(screenRectangle.Width, s.Bounds.Right);
                screenRectangle.Height = Math.Max(screenRectangle.Height, s.Bounds.Bottom);
            }
            //Console.WriteLine(screenRectangle);

            // ウィンドウとQTを配置するエリアの位置やサイズを指定
            axQTControl1.Top = 0;
            axQTControl1.Left = 0;
            this.Top = screenRectangle.Top;
            this.Left = screenRectangle.Left;
            this.Width = axQTControl1.Width = screenRectangle.Width - screenRectangle.X;
            this.Height = axQTControl1.Height = screenRectangle.Height - screenRectangle.Y;

            string[] cmds = System.Environment.GetCommandLineArgs();
            string path = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "movie.mp4";


            if (cmds.Length > 1)
            {
                //ドロップされたファイルのパスをすべて表示
                for (int i = 1; i < cmds.Length; i++)
                {
                    // Console.WriteLine(cmds[i]);
                    path = cmds[i];
                }
            }

            axQTControl1.URL = path;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            axQTControl1.Width = this.Width;
            axQTControl1.Height = this.Height;
        }

    }
}

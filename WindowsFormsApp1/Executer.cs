using CpsSimple;
using CpsJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public static class Executer
    {
        const string Dir_Old = @"J:\開発\コプロ\大虎でこか\項目情報\old\";

        public static bool MoveFilesToOld_ByYear()
        {
            var move_cnt = 0;

            //old直下のファイル取得
            foreach (var path in Directory.GetFiles(Dir_Old))
            {
                var name = Path.GetFileName(path);
                var year = File.GetLastWriteTime(path).Year;
                var new_dir = Dir_Old + year;


                ////フォルダ作成
                //if (!Directory.Exists(new_dir))
                //    Directory.CreateDirectory(new_dir);

                //ファイル移動
                File.Move(path, new_dir + "\\" + name);

                Console.WriteLine(year + "\t" + name);
                move_cnt++;
            }

            MessageBoxΩ.Show($"{move_cnt}件のファイルを移動しました");

            return true;
        }

    }
}

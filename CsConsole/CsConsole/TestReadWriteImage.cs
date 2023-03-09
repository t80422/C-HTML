using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//讀寫圖片
namespace CsConsole
{
    internal class TestReadWriteImage
    {
        public static void Main()
        {
            //變數的生命週期只在try裡 所以寫在finally的變數要拉出來
            Stream fs=null,fos=null;
            try
            {
                string path = @"C:\Users\user\Desktop\C#HTML5\Images\background-image.jpg";
                //類別多型化
                fs = new FileStream(path,FileMode.Open,FileAccess.Read);
                //準備緩存區 Byte Array(元素數量要固定)
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer,0, buffer.Length);
                //關閉檔案
                fs.Close();
                //寫出去
                string newFile= @"C:\Users\user\Desktop\C#HTML5\Images\background-image_new.jpg";
                fos = new FileStream(newFile, FileMode.CreateNew, FileAccess.Write);
                fos.Write(buffer, 0, buffer.Length);
                //清除緩存區
                fos.Flush();
                fos.Close();
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
                if (fs != null)
                {
                    fs.Close();
                }
                if(fos != null)
                {
                    fos.Close();
                }
                
            }

        }   
    }
}

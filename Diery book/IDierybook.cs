using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace Diery_book
{
    interface IDierybook
    {
        DataTable SelectAll();
        DataTable SelectRow(int BookId);
        bool Insert(string Title, string Date,byte[] pic, string Description);
        bool Edit(int BookId, string Title, string Date, byte[] pic, string Description);
        bool Delete(int BookId);
        byte[] ConvertImgToBytes(Image img);
         Image ConvertByteArrayToImage(byte[] data);
       
    }
}
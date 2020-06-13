using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Mulan : Bioskop
    {
        public override void Film()
        {
            Console.WriteLine("Mulan");
            Console.WriteLine("Mulan mengisahkan tentang seorang gadis muda yang menyamar sebagai prajurit laki-laki untuk menggantikan kewajiban sang ayah. Tindakan ini diambil Mulan setelah penjajah utara yang dipimpin oleh Bori Khan melaksanakan dekrit dari kaisar untuk merekrut satu orang lelaki dari setiap keluarga China.");
        }
    }
}

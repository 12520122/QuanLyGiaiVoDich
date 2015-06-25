using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaiVoDich.Model.tbModel
{
    public class DoiBongSan
    {
        private int MADOI;
        private string TENDOI;
        private int MASAN;
        private string TENSAN;
        private int? SUCCHUA;
        private string DIACHI;

        public int Madoi
        {
            get { return MADOI; }
            set { MADOI = value; }
        }

        public string Tendoi
        {
            get { return TENDOI; }
            set { TENDOI = value; }
        }

        public int Masan
        {
            get { return MASAN; }
            set { MASAN = value; }
        }

        public string Tensan
        {
            get { return TENSAN; }
            set { TENSAN = value; }
        }

        public int? Succhua
        {
            get { return SUCCHUA; }
            set { SUCCHUA = value; }
        }

        public string Diachi
        {
            get { return DIACHI; }
            set { DIACHI = value; }
        }

        public DoiBongSan(int madoi, string tendoi, int masan, string tensan, int? succhua, string diachi)
        {
            MADOI = madoi;
            TENDOI = tendoi;
            MASAN = masan;
            TENSAN = tensan;
            DIACHI = diachi;
            SUCCHUA = succhua;
        }

        public DoiBongSan() { }
    }
}

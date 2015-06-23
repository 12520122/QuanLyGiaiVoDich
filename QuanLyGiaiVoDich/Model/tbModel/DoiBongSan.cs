using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuanLyGiaiVoDich.Annotations;

namespace QuanLyGiaiVoDich.Model.tbModel
{
    public class DoiBongSan : INotifyPropertyChanged
    {
        public int STT;
        public int MADOI;
        public string TENDOI;
        public string TENMUA;
        public int MASAN;
        public string TENSAN;
        public int SUCCHUA;
        public string DIACHI;

        public int Stt
        {
            get { return STT; }
            set
            {
                if (value == STT) return;
                STT = value;
                OnPropertyChanged();
            }
        }

        public int Madoi
        {
            get { return MADOI; }
            set
            {
                if (value == MADOI) return;
                MADOI = value;
                OnPropertyChanged();
            }
        }

        public string Tendoi
        {
            get { return TENDOI; }
            set
            {
                if (value == TENDOI) return;
                TENDOI = value;
                OnPropertyChanged();
            }
        }

        public int Masan
        {
            get { return MASAN; }
            set
            {
                if (value == MASAN) return;
                MASAN = value;
                OnPropertyChanged();
            }
        }

        public string Tenmua
        {
            get { return TENMUA; }
            set
            {
                if (value == TENMUA) return;
                TENMUA = value;
                OnPropertyChanged();
            }
        }

        public string Tensan
        {
            get { return TENSAN; }
            set
            {
                if (value == TENSAN) return;
                TENSAN = value;
                OnPropertyChanged();
            }
        }

        public int Succhua
        {
            get { return SUCCHUA; }
            set
            {
                if (value == SUCCHUA) return;
                SUCCHUA = value;
                OnPropertyChanged();
            }
        }

        public string Diachi
        {
            get { return DIACHI; }
            set
            {
                if (value == DIACHI) return;
                DIACHI = value;
                OnPropertyChanged();
            }
        }

        public DoiBongSan(int stt, int madoi, string tendoi,string muagiai, int masan, string tensan, int succhua, string diachi)
        {
            STT = stt;
            MADOI = madoi;
            TENDOI = tendoi;
            MASAN = masan;
            TENMUA = muagiai;
            TENSAN = tensan;
            DIACHI = diachi;
            SUCCHUA = succhua;

        }

        public DoiBongSan() { }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

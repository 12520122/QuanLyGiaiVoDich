using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using QuanLyGiaiVoDich.Annotations;
using System.Windows;
using System.Windows.Controls;

namespace QuanLyGiaiVoDich.ViewModel
{
    public class DanhsachMuagiaiVM : ViewModelBase
    {
        private ICommand _LstBxItemClickCmd;

        public ICommand LstBxItemClickCmd
        {
            get { return _LstBxItemClickCmd; }
            set { _LstBxItemClickCmd = value; }
        }

        public DanhsachMuagiaiVM()
        {
            LstBxItemClickCmd = new RelayCommand(new Action<object>(LstBxItemClickCmd_Xuly) , new Predicate<object>(LstBxItemClickCmd_Dieukien));
        }

        private void LstBxItemClickCmd_Xuly(object obj)
        {
            if(obj == null)
            {
                MessageBox.Show("null");
            }
            else
                MessageBox.Show(obj.ToString());
        }
        private bool LstBxItemClickCmd_Dieukien(object obj)
        {
            return true;
        }
    }
}

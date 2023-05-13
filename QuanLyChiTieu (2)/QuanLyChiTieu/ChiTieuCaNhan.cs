using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
    internal class ChiTieuCaNhan
    {
        private string _TenChiTieu;
        private string _DMCT;
        private string _SoTien;
        private string _SL;
        private string _GhiChu;

        public string TenChiTieu { get => _TenChiTieu; set => _TenChiTieu = value; }
        public string DMCT { get => _DMCT; set => _DMCT = value; }
        public string SL{ get => _SL; set => _SL = value; }
        public string SoTien { get => _SoTien; set => _SoTien = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
    }
}

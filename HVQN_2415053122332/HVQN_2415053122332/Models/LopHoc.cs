using System.Collections.Generic;

namespace HVQN_2415053122332.Models
{
    public class LopHoc
    {
        public int LopHocId { get; set; }
        public string TenLop { get; set; }
        public string Khoa { get; set; }

        public List<SinhVien> SinhViens { get; set; }
    }
}
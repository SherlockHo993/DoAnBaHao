using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using System.IO;

namespace QuanLyHocVien
{
    public partial class frmHelp : DevExpress.XtraEditors.XtraForm
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            memoHelp.Text =
            @"HƯỚNG DẪN SỬ DỤNG PHẦN MỀM QUẢN LÝ HỌC VIÊN
            ================================================

            MỤC LỤC
            1) Đăng nhập / Đăng xuất
            2) Đăng ký tài khoản
            3) Đổi mật khẩu
            4) Quản lý Học viên
            5) Quản lý Giáo viên
            6) Quản lý Lớp học
            7) Quản lý Biên lai (Điểm - Kết quả - Xếp loại - Tiền nộp)
            8) Thống kê / Báo cáo
            9) Lưu ý và lỗi thường gặp

            ------------------------------------------------
            1) ĐĂNG NHẬP / ĐĂNG XUẤT
            ------------------------------------------------
            1.1 Đăng nhập
            - Bước 1: Chọn menu/ nút 'Đăng nhập'
            - Bước 2: Nhập 'Tên đăng nhập' và 'Mật khẩu'
            - Bước 3: Nhấn 'OK' để đăng nhập
            Kết quả:
            - Nếu đúng: hệ thống bật các chức năng quản lý (Học viên / Giáo viên / Lớp học / Biên lai / Thống kê...)
            - Nếu sai: hệ thống báo lỗi và yêu cầu nhập lại (không thoát chương trình)

            1.2 Đăng xuất
            - Bước 1: Chọn 'Đăng xuất'
            - Bước 2: Xác nhận (nếu có)
            Kết quả:
            - Hệ thống khóa các chức năng quản lý
            - Chỉ còn các chức năng: Đăng nhập / Đăng ký
            - Dữ liệu UserControl sẽ được đóng/clear để tránh thao tác nhầm

            Mẹo:
            - Nếu không thấy menu quản lý: bạn chưa đăng nhập hoặc đăng xuất rồi.

            ------------------------------------------------
            2) ĐĂNG KÝ TÀI KHOẢN
            ------------------------------------------------
            - Bước 1: Trong form đăng nhập, bấm link 'Đăng ký'
            - Bước 2: Nhập thông tin:
              + Tên đăng nhập (không trùng)
              + Mật khẩu
              + Nhập lại mật khẩu
            - Bước 3: Nhấn 'Xác nhận'
            Kết quả:
            - Tạo tài khoản mới thành công → quay lại form đăng nhập và tự điền sẵn tên đăng nhập

            Lưu ý:
            - Tên đăng nhập phải duy nhất (không trùng người khác)
            - Mật khẩu và Nhập lại mật khẩu phải giống nhau

            ------------------------------------------------
            3) ĐỔI MẬT KHẨU
            ------------------------------------------------
            Điều kiện:
            - PHẢI đăng nhập thành công mới đổi mật khẩu được

            - Bước 1: Chọn menu 'Đổi mật khẩu'
            - Bước 2: Hệ thống tự điền Tên đăng nhập (không cần nhập lại)
            - Bước 3: Nhập:
              + Mật khẩu cũ
              + Mật khẩu mới
              + Xác nhận mật khẩu mới
            - Bước 4: Nhấn 'Xác nhận'
            Kết quả:
            - Nếu mật khẩu cũ đúng và 2 lần mật khẩu mới trùng → đổi mật khẩu thành công
            - Nếu sai → báo lỗi và yêu cầu nhập lại

            ------------------------------------------------
            4) QUẢN LÝ HỌC VIÊN
            ------------------------------------------------
            4.1 Xem danh sách học viên
            - Chọn menu 'Học viên'
            - Danh sách học viên hiển thị trong bảng (Grid)

            4.2 Thêm mới học viên (NewAdd → Save)
            - Bước 1: Nhấn 'NewAdd'
            - Bước 2: Nhập thông tin:
              + MAHV (mã học viên) (nhập mới, không trùng)
              + Họ, Tên
              + Ngày sinh
              + Nghề nghiệp
            - Bước 3: Nhấn 'Save'
            Kết quả:
            - Hệ thống kiểm tra trùng MAHV
            - Lưu thành công → dữ liệu cập nhật lên Grid

            4.3 Cập nhật học viên (Update)
            - Bước 1: Click chọn 1 dòng học viên trên Grid
            - Bước 2: Sửa các thông tin (trừ MAHV)
            - Bước 3: Nhấn 'Update'
            Lưu ý:
            - MAHV là khóa chính → thường KHÔNG cho đổi để tránh lỗi liên kết biên lai

            4.4 Xóa học viên (Delete)
            - Bước 1: Chọn 1 học viên
            - Bước 2: Nhấn 'Delete'
            Kết quả:
            - Nếu học viên đã có BIÊN LAI liên quan:
              + Hệ thống sẽ báo không thể xóa hoặc hỏi bạn có muốn xóa luôn biên lai (tùy cài đặt)
            - Nếu không có liên quan → xóa thành công

            4.5 Hủy thao tác (Cancel)
            - Khi đang thêm mới (Save/Cancel đang bật)
            - Nhấn 'Cancel' để bỏ thao tác và quay về trạng thái bình thường

            ------------------------------------------------
            5) QUẢN LÝ GIÁO VIÊN
            ------------------------------------------------
            Các thao tác tương tự Học viên:
            - NewAdd → Save: thêm giáo viên mới (MAGV không trùng)
            - Update: sửa thông tin (không đổi MAGV)
            - Delete: xóa giáo viên (nếu có lớp học đang dùng MAGV có thể bị chặn)

            ------------------------------------------------
            6) QUẢN LÝ LỚP HỌC
            ------------------------------------------------
            6.1 Ý nghĩa các cột
            - MALH: Mã lớp học (khóa chính)
            - TENLOP: Tên lớp
            - MAMH: Mã môn học
            - MAGV: Mã giáo viên phụ trách (FK tới bảng GIAOVIEN)
            - LTRG: Số tín chỉ
            - SISODK: Sĩ số đăng ký
            - PHHOC: Phòng học

            6.2 Thêm mới lớp học
            - NewAdd → nhập MALH, TENLOP, MAMH, MAGV, LTRG, SISODK, PHHOC → Save
            Lưu ý:
            - MAGV nếu nhập phải tồn tại trong bảng giáo viên, nếu không sẽ báo lỗi

            6.3 Xóa lớp học
            - Nếu lớp học đã có BIÊN LAI (bảng BIENLAI tham chiếu MALH)
              + hệ thống sẽ chặn hoặc hỏi xóa kèm BIÊN LAI tùy cài đặt

            ------------------------------------------------
            7) QUẢN LÝ BIÊN LAI (ĐIỂM - KẾT QUẢ - XẾP LOẠI)
            ------------------------------------------------
            7.1 Ý nghĩa
            - BIENLAI có khóa chính kép: (MALH, MAHV)
              => 1 học viên trong 1 lớp chỉ có 1 biên lai

            7.2 Thêm mới biên lai
            - Bước 1: Nhấn 'NewAdd'
            - Bước 2: Nhập:
              + MALH (mã lớp) - phải tồn tại trong LOPHOC
              + MAHV (mã học viên) - phải tồn tại trong HOCVIEN
              + DIEM (0-10)
              + TIENNOP (nếu có)
            - KQUA và XEPLOAI: hệ thống TỰ TÍNH, người dùng KHÔNG được sửa

            Quy tắc tự tính:
            - KQUA:
              + DIEM >= 7.0  => ĐẬU
              + DIEM <  7.0  => RỚT
            - XEPLOAI:
              + DIEM >= 8.5  => A
              + DIEM >= 7.0  => B
              + DIEM >= 5.0  => C
              + DIEM <  5.0  => D

            - Bước 3: Nhấn Save để lưu

            7.3 Cập nhật biên lai
            - Bước 1: Chọn 1 biên lai trên Grid
            - Bước 2: Sửa DIEM, TIENNOP
            - KQUA/XEPLOAI tự đổi theo DIEM
            - Bước 3: Nhấn Update

            7.4 Xóa biên lai
            - Chọn biên lai → Delete → xác nhận

            ------------------------------------------------
            8) THỐNG KÊ / BÁO CÁO
            ------------------------------------------------
            8.1 Thống kê theo kết quả (ĐẬU/RỚT)
            - Chọn 'Thống kê theo KQ'
            - Chọn 'ĐẬU' hoặc 'RỚT'
            - Report hiển thị danh sách theo điều kiện

            8.2 Thống kê theo điểm
            - Chọn lớp (hoặc tất cả)
            - Nhập khoảng điểm Min/Max
            - Nhấn 'Xem thống kê' để xem report

            8.3 Thống kê tổng tiền theo lớp (nếu có)
            - Chọn menu thống kê tổng tiền
            - Hệ thống cộng TIENNOP theo từng lớp

            ------------------------------------------------
            9) LƯU Ý & LỖI THƯỜNG GẶP
            ------------------------------------------------
            - Không thấy nút quản lý: chưa đăng nhập
            - Save bị báo trùng: mã khóa chính đã tồn tại (MAHV/MAGV/MALH hoặc (MALH,MAHV))
            - Xóa bị báo lỗi FK: bản ghi đang bị bảng khác tham chiếu (ví dụ BIENLAI tham chiếu HOCVIEN/LOPHOC)
            - DIEM phải nằm trong 0..10
            - KQUA và XEPLOAI tự tính theo điểm, không nhập tay

            ================================================
            KẾT THÚC HƯỚNG DẪN
            ";
        }
    }
}
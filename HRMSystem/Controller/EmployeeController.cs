using DocumentFormat.OpenXml.Wordprocessing;
using HRMSystem.Controls;
using HRMSystem.Interfaces;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Controller
{
    public class EmployeeController : IucControlController
    {
        private ucBaseSingleList View;
        public void Initialize(UserControl _view)
        {
            View = _view as ucBaseSingleList;
            View.Load += View_Load;

            View.DeleteButtonClick += MasterForm_DeleteButtonClick; 

            View.ReLoadButtonClick += MasterForm_ReLoadButtonClick; 
        }

        private void MasterForm_DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var model = context.NhanViens.Find(Convert.ToInt32(View.GetPrimaryKey("MaNV")));

                    if (model != null)
                    {
                        context.NhanViens.Remove(model);

                        context.SaveChanges();

                        LoadData();
                    }

                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally {  }
        }

        private void MasterForm_ReLoadButtonClick(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                using (var context = new AppDbContext())
                {

                    var query = (from nv in context.NhanViens
                                 join cm in context.ChuyenMons on nv.MaCM equals cm.MaCM
                                 join nn in context.NgoaiNgus on nv.MaNN equals nn.MaNN
                                 join xx in context.DinhMucXangXes on nv.MaDMXX equals xx.MaDMXX
                                 join tg in context.TonGiaos on nv.MaTG equals tg.MaTG
                                 join cv in context.ChucVus on nv.MaChucVu equals cv.MaChucVu
                                 join xl in context.XepLoaiNhanViens on nv.MaChucVu equals xl.MaXLCB
                                 join vh in context.TrinhDoVanHoas on nv.MaChucVu equals vh.MaTDVH
                                 join lv in context.TrangThaiLamViecs on nv.MaTTLV equals lv.MaTTLV
                                 join tt in context.TinhThanhs on nv.MaTT equals tt.MaTT
                                 join dt in context.DanTocs on nv.MaTT equals dt.MaDT
                                 join tl in context.ThangLuongs on nv.MaTL equals tl.MaTL
                                 join ml in context.MucLuongToiThieus on nv.MaMLTT equals ml.MaMLTT
                                 select new
                                 {
                                     nv.MaNV,
                                     nv.TenNV,
                                     nv.BiDanh,
                                     nv.GioiTinh,
                                     nv.NgaySinh,
                                     nv.QueQuan,
                                     nv.NoiSinh,
                                     nv.NoiOHienTai,
                                     nv.SoCCCD,
                                     nv.NgayCap,
                                     nv.NoiCap,
                                     nv.Email,
                                     nv.SoDienThoai,
                                     nv.Anh,
                                     nv.NgayVaoDoan,
                                     nv.NoiVaoDoan,
                                     nv.NgayVaoDang,
                                     nv.NoiVaoDang,
                                     nv.NgayVaoLam,
                                     nv.NgayRoiCoQuan,
                                     nv.LyDo,
                                     tl.HeSo,
                                     nv.HeSoPhuCap,
                                     nv.HeSoTNVK,
                                     nv.SoSocBH,
                                     nv.NgayCapSo,
                                     nv.NoiCapSo,
                                     nv.SoThe,
                                     nv.SoTaiKhoan,
                                     nv.NganHang,
                                     nv.TinhTrangHonNhan,
                                     nv.TinhTrangSuckhoe,
                                     nv.ChieuCao,
                                     nv.CanNang,
                                     nv.NhomMau,
                                     nv.NgayNhapNgu,
                                     nv.NgayXuatNgu,
                                     nv.QuanHamCaoNhat,
                                     nv.ThoiGianNangBacHSL,
                                     nv.KhongChoPhepNangLuong,
                                     nv.RoiCoQuan,
                                     ml.MLTTC,
                                     xx.DMXX,
                                     xx.TenPTien,
                                     tg.TenTG,
                                     cv.TenChucVu,
                                     xl.XepLoai,
                                     tt.TenTT,
                                     vh.TenTDVH,
                                     dt.TenDT,
                                     nn.TenNN,
                                     nv.MaTDLLCT,
                                     lv.TenTTLV,
                                     cm.TenCM
                                 });

                    var result = query.ToList();

                    View.SetTitle("Quản lý Danh Sách Nhân Viên");
                    View.SetDataSource(result, clsInitialGridColumn.InitialEmployee());
                    View.SetSpecialGridProperties();
                }
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ExpertiseController", ex.ToString()); }
            finally { }
           

        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "EmployeeController", ex.ToString()); }
            finally { clsCommon.CloseWaitingForm(); }
        }
    }
}

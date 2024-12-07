USE [HRMsystem]
GO
/****** Object:  StoredProcedure [dbo].[GetLuongNhanVien]    Script Date: 12/4/2024 10:24:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetLuongNhanVien]
    @nam INT,   
    @thang INT   
AS
BEGIN
SELECT 
    nv.TenNV,
    nv.MaNV,
    ml.MLTTC,
    tl.HeSo,
    (ml.MLTTC * tl.HeSo) AS LuongCoBan,
    ISNULL(cc.NgayCongTrongThang, 26) AS NgayCongTrongThang,
    ((ml.MLTTC * tl.HeSo) / 26 * ISNULL(cc.NgayCongTrongThang, 26)) AS LuongThoiGian,
    xx.DMXX,
    (ISNULL(cc.NgayCongTrongThang, 26) * 25000) AS TienAn,
    ((ml.MLTTC * tl.HeSo) / 26 * ISNULL(cc.NgayCongTrongThang, 26)) + (ISNULL(cc.NgayCongTrongThang, 26) * 25000) + xx.DMXX AS TongLuong,
    ((ml.MLTTC * tl.HeSo) * 8 / 100) AS BHXH,
    ((ml.MLTTC * tl.HeSo) * 1.5 / 100) AS BHYT,
    ((ml.MLTTC * tl.HeSo) * 1 / 100) AS BHTN,
    ISNULL(tu.SoTienTU, 0) AS SoTienTU,
    ((ml.MLTTC * tl.HeSo) * 8 / 100) + ((ml.MLTTC * tl.HeSo) * 1.5 / 100) + ((ml.MLTTC * tl.HeSo) * 1 / 100) + ISNULL(tu.SoTienTU, 0) AS LuongGiamTru,
    ((ml.MLTTC * tl.HeSo) / 26 * ISNULL(cc.NgayCongTrongThang, 26)) + (ISNULL(cc.NgayCongTrongThang, 26) * 25000) + xx.DMXX - (((ml.MLTTC * tl.HeSo) * 8 / 100) + ((ml.MLTTC * tl.HeSo) * 1.5 / 100) + ((ml.MLTTC * tl.HeSo) * 1 / 100) + ISNULL(tu.SoTienTU, 0))   AS LuongThucNhan
FROM 
    dbo.NhanVien nv
LEFT JOIN 
    dbo.ChamCongTL cc ON nv.MaNV = cc.MaNV AND cc.Nam = @nam AND cc.Thang = @thang
LEFT JOIN 
    dbo.DinhMucXangXe xx ON nv.MaDMXX = xx.MaDMXX
LEFT JOIN 
    dbo.BangTamUng tu ON nv.MaNV = tu.MaNV AND tu.Nam = @nam AND tu.Thang = @thang
LEFT JOIN 
    dbo.MucLuongToiThieu ml ON nv.MaMLTT = ml.MaMLTT
LEFT JOIN 
    dbo.ThangLuong tl ON nv.MaTL = tl.MaTL

    WHERE 
      (cc.Nam Is NULL AND cc.Thang Is NULL) or ( cc.Nam = @nam AND cc.Thang = @thang)
    ORDER BY 
        nv.MaNV ASC;
END;

CREATE TRIGGER UpdateLuong
ON [dbo].[QuaTrinhLuong]
AFTER UPDATE, INSERT
AS
BEGIN

    DECLARE @MaMLTT int;
    DECLARE @MABL int;
    DECLARE @MANV int;

    SELECT @MaMLTT = inserted.MaMLTT, @MABL= inserted.MaBL, @MANV = inserted.MaNV
    FROM inserted;
    
    

    UPDATE [dbo].[NhanVien] SET MaMLTT = @MaMLTT , MaTL = @MABL WHERE MaNV = @MANV;
	 

   
END;


USE [HRMsystem]
GO

/****** Object:  StoredProcedure [dbo].[GetDanhSachNhanVien]    Script Date: 12/4/2024 10:38:01 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDanhSachNhanVien] 
	
AS
BEGIN
	SELECT 
		*
	FROM 
		NhanVien nv
	left join 
		ChuyenMon cm ON nv.MaCM = cm.MaCM
	left join 
		NgoaiNgu nn ON nv.MaNN = nn.MaNN
	left join 
		DinhMucXangXe xx ON nv.MaDMXX = xx.MaDMXX
	left join 
		TonGiao tg ON nv.MaTG = tg.MaTG
	left join 
		ChucVu cv ON nv.MaChucVu = cv.MaChucVu
	left join 
		XepLoaiCanBo xl ON nv.MaChucVu = xl.MaXLCB
	left join 
		TrinhDoVanHoa vh ON nv.MaChucVu = vh.MaTDVH
	left join 
		TrangThaiLamViec lv ON nv.MaTTLV = lv.MaTTLV
	left join 
		TinhThanh tt ON nv.MaTT = tt.MaTT
	left join 
		DanToc dt ON nv.MaTT = dt.MaDT
	left join 
		ThangLuong tl ON nv.MaTL = tl.MaTL
	left join 
		MucLuongToiThieu ml ON nv.MaMLTT = ml.MaMLTT;

END
GO



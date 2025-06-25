CREATE DATABASE DinhThienTruong_DoAn1
GO
USE DinhThienTruong_DoAn1
GO
CREATE TABLE TheLoai (
    MaTheLoai CHAR(5) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(500) NOT NULL
)
GO

CREATE TABLE Truyen (
    MaTruyen CHAR(5) PRIMARY KEY,
    TenTruyen NVARCHAR(100) NOT NULL,
    MaTheLoai CHAR(5) NOT NULL,
	TacGia NVARCHAR(100) NOT NULL,
	SoLuong INT NOT NULL CHECK (SoLuong >= 0),
	Gia INT NOT NULL CHECK(Gia >= 0), 
	HinhAnh IMAGE,
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)
)
GO


CREATE TABLE NhanVien (
    MaNV CHAR(5) PRIMARY KEY,
    HoTenNV NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
	QueQuan NVARCHAR(50) NOT NULL,
	SoDienThoai CHAR(10) NOT NULL,
)
GO	

CREATE TABLE KhachHangThanhVien (
    MaKHTV CHAR(5) PRIMARY KEY,
    HoTenKHTV NVARCHAR(100),
	SoDienThoai CHAR(10) NOT NULL,
    DiaChi NVARCHAR(150),
    HSDTheThanhVien DATE
)
GO	

CREATE TABLE HoaDonNhap (
    MaHoaDonNhap CHAR(5) PRIMARY KEY,
    NgayNhap DATE NOT NULL,
	TongTien INT NOT NULL CHECK( TongTien >= 0),
	MaNhanVienNhap CHAR(5),
	FOREIGN KEY (MaNhanVienNhap) REFERENCES NhanVien(MaNV) ON DELETE SET NULL
)
GO	

CREATE TABLE ChiTietHoaDonNhap (
	MaHoaDonNhap CHAR(5) NOT NULL,
	MaTruyen CHAR(5) NOT NULL,
	SoLuongNhap INT NOT NULL,
	GiaNhap INT NOT NULL,
	ThanhTien INT NOT NULL,
	FOREIGN KEY (MaHoaDonNhap) REFERENCES dbo.HoaDonNhap(MaHoaDonNhap),
	FOREIGN KEY (MaTruyen) REFERENCES dbo.Truyen(MaTruyen)
)
GO	

CREATE TABLE HoaDonBan (
    MaHoaDonBan CHAR(5) PRIMARY KEY,
    NgayBan DATE NOT NULL,
	TongTien INT NOT NULL CHECK( TongTien >= 0),
	MaNhanVienBan CHAR(5),
	MaKHTV CHAR(5),
	FOREIGN KEY (MaNhanVienBan) REFERENCES NhanVien(MaNV) ON DELETE SET NULL,
	FOREIGN KEY (MaKHTV) REFERENCES dbo.KhachHangThanhVien(MaKHTV) ON DELETE SET NULL
)
GO
--tự sinh mã hoá đơn bán
 SELECT CONCAT('B', RIGHT(CONCAT('00000',ISNULL(right(max(MaHoaDonBan),4),0) + 1),4))
                                            FROM dbo.HoaDonBan where MaHoaDonBan like 'B%'
GO	

CREATE TABLE ChiTietHoaDonBan (
	MaHoaDonBan CHAR(5) NOT NULL,
	MaTruyen CHAR(5) NOT NULL,
	SoLuongBan INT NOT NULL,
	GiaBan INT NOT NULL,
	ThanhTien INT NOT NULL,
	FOREIGN KEY (MaHoaDonBan) REFERENCES dbo.HoaDonBan(MaHoaDonBan),
	FOREIGN KEY (MaTruyen) REFERENCES dbo.Truyen(MaTruyen)
)
GO	

CREATE TABLE GioHang(
	MaHoaDon CHAR(5) NOT NULL,
	MaTruyen CHAR(5) NOT NULL,
	SoLuong INT NOT NULL,
	Gia INT NOT NULL,
	ThanhTien INT NOT NULL,
)

GO	


CREATE TABLE TaiKhoan (
	UserName CHAR(5) PRIMARY KEY, 
	PassWord NVARCHAR(20) NOT NULL,
	Quyen INT NOT NULL,
	FOREIGN KEY (UserName) REFERENCES dbo.NhanVien(MaNV) ON DELETE CASCADE
)
GO 

--đăng nhập
CREATE PROCEDURE sp_Login
@userName CHAR(5), @passWord NVARCHAR(20)
AS
BEGIN	
	SELECT * FROM dbo.TaiKhoan WHERE UserName = @userName AND PassWord = @passWord
END
GO
SELECT * FROM dbo.TaiKhoan WHERE UserName = 'ADMIN1' AND PassWord = '12345'

--hiển thị thông tin form truyện
CREATE PROCEDURE sp_HienThiThongTinTruyen
AS
BEGIN
    SELECT 
        Truyen.MaTruyen,
        Truyen.TenTruyen,
        TheLoai.TenTheLoai,
        Truyen.TacGia,
        Truyen.SoLuong,
        Truyen.Gia,
		Truyen.HinhAnh
    FROM 
        Truyen
    INNER JOIN 
        TheLoai ON Truyen.MaTheLoai = TheLoai.MaTheLoai;
END;
GO	

--thêm thông tin truyện
CREATE PROCEDURE sp_ThemThongTinTruyen
    @MaTruyen CHAR(5),
    @TenTruyen NVARCHAR(100),
    @TenTheLoai NVARCHAR(100),
    @TacGia NVARCHAR(100),
    @SoLuong INT,
    @Gia INT,
	@HinhAnh IMAGE
AS
BEGIN
    -- Lấy mã thể loại từ bảng TheLoai dựa trên tên thể loại
    DECLARE @MaTheLoai CHAR(5);
    SELECT @MaTheLoai = MaTheLoai FROM TheLoai WHERE TenTheLoai = @TenTheLoai;

    -- Thêm thông tin truyện mới vào bảng Truyen
    INSERT INTO Truyen (MaTruyen, TenTruyen, MaTheLoai, TacGia, SoLuong, Gia, HinhAnh)
    VALUES (@MaTruyen, @TenTruyen, @MaTheLoai, @TacGia, @SoLuong, @Gia, @HinhAnh);
END;
GO

--sửa thông tin form truyện bao gồm tên thể loại
CREATE PROCEDURE sp_CapNhatThongTinTruyen
    @MaTruyen CHAR(5),
    @TenTruyenMoi NVARCHAR(100),
    @TenTheLoaiMoi NVARCHAR(100),
    @TacGiaMoi NVARCHAR(100),
    @SoLuongMoi INT,
    @GiaMoi INT,
	@HinhAnhMoi IMAGE
AS
BEGIN
    -- Lấy mã thể loại mới từ bảng TheLoai dựa trên tên thể loại mới
    DECLARE @MaTheLoaiMoi CHAR(5);
    SELECT @MaTheLoaiMoi = MaTheLoai FROM TheLoai WHERE TenTheLoai = @TenTheLoaiMoi;

    -- Cập nhật tất cả thông tin trong bảng Truyen dựa trên mã truyện
    UPDATE Truyen
    SET TenTruyen = @TenTruyenMoi,
        TacGia = @TacGiaMoi,
        SoLuong = @SoLuongMoi,
        Gia = @GiaMoi, 
		HinhAnh = @HinhAnhMoi, 
		MaTheLoai = @MaTheLoaiMoi
    WHERE MaTruyen = @MaTruyen;
END;
GO

--tìm kiếm thông tin truyện bằng tên truyện hoặc tên thể loại
CREATE PROCEDURE sp_TimThongTinTruyen
    @DoiTuong NVARCHAR(100)
AS
BEGIN
    SELECT Truyen.MaTruyen, Truyen.TenTruyen, TheLoai.TenTheLoai, Truyen.TacGia, Truyen.SoLuong, Truyen.Gia, Truyen.HinhAnh
    FROM Truyen
    INNER JOIN TheLoai ON Truyen.MaTheLoai = TheLoai.MaTheLoai
    WHERE Truyen.TenTruyen LIKE N'%' + @DoiTuong + '%' OR TheLoai.TenTheLoai LIKE N'%' + @DoiTuong + '%';
END;
GO


--xem thông tin hoá đơn bán
CREATE PROCEDURE sp_GetAllHoaDonBan
AS
BEGIN
    SELECT
        H.MaHoaDonBan,
        H.NgayBan,
        H.TongTien,
        NV.HoTenNV AS NhanVienBan,
		H.MaKHTV AS KhachHangThanhVien
        --KHTV.HoTenKHTV AS KhachHangThanhVien
    FROM HoaDonBan H
    LEFT JOIN NhanVien NV ON H.MaNhanVienBan = NV.MaNV
    --LEFT JOIN KhachHangThanhVien KHTV ON H.MaKHTV = KHTV.MaKHTV;
END;
GO	

-- Thủ tục thêm hoá đơn bán
CREATE PROCEDURE sp_ThemHoaDonBan
    @MaHoaDonBan CHAR(5),
    @NgayBan DATE,
    @TenNhanVienBan NVARCHAR(100),
    @MaKHTV CHAR(5),
	@TongTien INT
AS
BEGIN
    DECLARE @MaNhanVienBan CHAR(5);

    -- Lấy mã nhân viên bán từ tên nhân viên bán
    SELECT @MaNhanVienBan = MaNV
    FROM NhanVien
    WHERE HoTenNV = @TenNhanVienBan;

    -- Kiểm tra giá trị của @MaKHTV
    IF @MaKHTV = ''
        SET @MaKHTV = NULL;
			
    -- Thêm hoá đơn bán
    INSERT INTO HoaDonBan (MaHoaDonBan, NgayBan, MaNhanVienBan, MaKHTV, TongTien)
    VALUES (@MaHoaDonBan, @NgayBan, @MaNhanVienBan, @MaKHTV, @TongTien);
END
GO

-- Thủ tục thêm hoá đơn nhập
CREATE PROCEDURE sp_ThemHoaDonNhap
    @MaHoaDonNhap CHAR(5),
    @NgayNhap DATE,
    @TenNhanVienNhap NVARCHAR(100),
	@TongTien INT
AS
BEGIN
    DECLARE @MaNhanVienNhap CHAR(5);

    -- Lấy mã nhân viên bán từ tên nhân viên bán
    SELECT @MaNhanVienNhap = MaNV
    FROM NhanVien
    WHERE HoTenNV = @TenNhanVienNhap;
			
    -- Thêm hoá đơn bán
    INSERT INTO HoaDonNhap (MaHoaDonNhap, NgayNhap, MaNhanVienNhap, TongTien)
    VALUES (@MaHoaDonNhap, @NgayNhap, @MaNhanVienNhap, @TongTien);
END
GO

-- Câu lệnh INSERT cho bảng ChiTietHoaDonBan
INSERT INTO ChiTietHoaDonBan (MaHoaDonBan, MaTruyen, SoLuongBan, GiaBan, ThanhTien)VALUES ('', '', , , )


--sửa hoá đơn bán
CREATE PROCEDURE sp_UpdateHoaDonBan
    @MaHoaDonBan CHAR(5),
    @TenNhanVienBan NVARCHAR(100),
    @MaKHTV NVARCHAR(100),
    @NgayBan DATE
AS
BEGIN
    DECLARE @MaNhanVienBan CHAR(5);

    -- Lấy mã nhân viên bán từ tên nhân viên bán
    SELECT @MaNhanVienBan = MaNV
    FROM NhanVien
    WHERE HoTenNV = @TenNhanVienBan

    -- Kiểm tra giá trị của @MaKHTV
    IF @MaKHTV = ''
        SET @MaKHTV = NULL;

    -- Sửa thông tin hóa đơn bán
    UPDATE HoaDonBan
    SET MaNhanVienBan = @MaNhanVienBan,
        MaKHTV = @MaKHTV,
        NgayBan = @NgayBan
    WHERE MaHoaDonBan = @MaHoaDonBan;
END;

GO 

--tìm kiếm thông tin theo tên nv bán
CREATE PROCEDURE sp_TimHoaDonBan
    @TenNVB NVARCHAR(100)
AS
BEGIN
    SELECT
        hdb.MaHoaDonBan,
        hdb.NgayBan,
        hdb.TongTien,
        nv.HoTenNV AS NhanVienBan,
        khtv.HoTenKHTV AS KhachHangThanhVien
    FROM HoaDonBan hdb
    LEFT JOIN NhanVien nv ON hdb.MaNhanVienBan = nv.MaNV
    LEFT JOIN KhachHangThanhVien khtv ON hdb.MaKHTV = khtv.MaKHTV
    WHERE NV.HoTenNV LIKE '%' + @TenNVB + '%';
END;
GO	

CREATE PROCEDURE sp_TimCTHoaDonBan
    @TenNVB NVARCHAR(100)
AS
BEGIN
    SELECT
        ct.MaHoaDonBan,
        t.TenTruyen,
        ct.SoLuongBan,
        ct.GiaBan,
        ct.ThanhTien
    FROM ChiTietHoaDonBan ct
    JOIN Truyen t ON ct.MaTruyen = t.MaTruyen
    JOIN HoaDonBan hdb ON ct.MaHoaDonBan = hdb.MaHoaDonBan
    JOIN NhanVien nv ON hdb.MaNhanVienBan = nv.MaNV
    WHERE nv.HoTenNV LIKE '%' + @TenNVB + '%';
END
GO	

--hiển thị chi tiết hoá đơn bán
CREATE PROCEDURE sp_HienThiChiTietHoaDonBan
AS
BEGIN
    SELECT
        c.MaHoaDonBan,
        t.TenTruyen,
        c.SoLuongBan,
        c.GiaBan,
        c.ThanhTien
    FROM ChiTietHoaDonBan c
    INNER JOIN Truyen t ON c.MaTruyen = t.MaTruyen;
END
GO	

--sửa chi tiết hoá đơn bán
CREATE PROCEDURE sp_SuaCTHoaDonBan
    @MaHoaDonBan CHAR(5),
    @TenTruyen NVARCHAR(100),
    @SoLuongBan INT,
    @GiaBan INT,
    @ThanhTien INT
AS
BEGIN
    DECLARE @MaTruyen CHAR(5)
    
    -- Lấy mã truyện dựa trên tên truyện
    SELECT @MaTruyen = MaTruyen
    FROM Truyen
    WHERE TenTruyen = @TenTruyen
    
    -- Cập nhật thông tin trong bảng ChiTietHoaDonBan
    UPDATE ChiTietHoaDonBan
    SET SoLuongBan = @SoLuongBan,
        GiaBan = @GiaBan,
        ThanhTien = @ThanhTien
    WHERE MaHoaDonBan = @MaHoaDonBan
        AND MaTruyen = @MaTruyen
END

GO

--xoá chi tiết hoá đơn bán
CREATE PROCEDURE sp_XoaCTHoaDonBan
    @MaHoaDonBan CHAR(5),
    @TenTruyen NVARCHAR(100),
    @SoLuongBan INT,
    @GiaBan INT,
    @ThanhTien INT
AS
BEGIN
    DECLARE @MaTruyen CHAR(5)
    
    -- Lấy mã truyện dựa trên tên truyện
    SELECT @MaTruyen = MaTruyen
    FROM Truyen
    WHERE TenTruyen = @TenTruyen
    
    -- Xoá thông tin trong bảng ChiTietHoaDonBan
    DELETE FROM ChiTietHoaDonBan
    WHERE MaHoaDonBan = @MaHoaDonBan
        AND MaTruyen = @MaTruyen
		AND	SoLuongBan = @SoLuongBan
		AND	GiaBan = @GiaBan
		AND ThanhTien = @ThanhTien		
END

GO

--hiển thị hoá đơn nhập
CREATE PROCEDURE sp_GetAllHoaDonNhap
AS
BEGIN
    SELECT
        H.MaHoaDonNhap,
        H.NgayNhap,
        H.TongTien,
        NV.HoTenNV AS NhanVienNhap
    FROM dbo.HoaDonNhap H
    LEFT JOIN NhanVien NV ON H.MaNhanVienNhap = NV.MaNV
END;

GO

--sửa hoá đơn nhập
CREATE PROCEDURE sp_UpdateHoaDonNhap
    @MaHoaDonNhap CHAR(5),
    @NgayNhap DATE,
	@TenNhanVienNhap NVARCHAR(100)
AS
BEGIN
    DECLARE @MaNhanVienNhap CHAR(5);

    -- Lấy mã nhân viên bán từ tên nhân viên bán
    SELECT @MaNhanVienNhap = MaNV
    FROM NhanVien
    WHERE HoTenNV = @TenNhanVienNhap;

    -- Sửa thông tin hóa đơn bán
    UPDATE dbo.HoaDonNhap
    SET NgayNhap = @NgayNhap,
		MaNhanVienNhap = @MaNhanVienNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap;
END;
GO 

--tìm kiếm thông tin theo tên nv nhập
CREATE PROCEDURE sp_TimHoaDonNhap
    @TenNVN NVARCHAR(100)
AS
BEGIN
    SELECT
        hdn.MaHoaDonNhap,
        hdn.NgayNhap,
        hdn.TongTien,
        nv.HoTenNV AS NhanVienNhap
    FROM HoaDonNhap hdn
    LEFT JOIN NhanVien nv ON hdn.MaNhanVienNhap = nv.MaNV
    WHERE NV.HoTenNV LIKE '%' + @TenNVN + '%';
END
GO

CREATE PROCEDURE sp_TimCTHoaDonNhap
    @TenNVN NVARCHAR(100)
AS
BEGIN
    SELECT
        ct.MaHoaDonNhap,
        t.TenTruyen,
        ct.SoLuongNhap,
        ct.GiaNhap,
        ct.ThanhTien
    FROM ChiTietHoaDonNhap ct
    JOIN Truyen t ON ct.MaTruyen = t.MaTruyen
    JOIN HoaDonNhap hdn ON ct.MaHoaDonNhap = hdn.MaHoaDonNhap
    JOIN NhanVien nv ON hdn.MaNhanVienNhap = nv.MaNV
    WHERE nv.HoTenNV LIKE '%' + @TenNVN + '%';
END
GO	

--hiển thị chi tiết hoá đơn nhập
CREATE PROCEDURE sp_HienThiChiTietHoaDonNhap
AS
BEGIN
    SELECT
        c.MaHoaDonNhap,
        t.TenTruyen,
        c.SoLuongNhap,
        c.GiaNhap,
        c.ThanhTien
    FROM dbo.ChiTietHoaDonNhap c
    INNER JOIN Truyen t ON c.MaTruyen = t.MaTruyen;
END
GO

--sửa chi tiết hoá đơn nhập
CREATE PROCEDURE sp_SuaCTHoaDonNhap
    @MaHoaDonNhap CHAR(5),
    @TenTruyen NVARCHAR(100),
    @SoLuongNhap INT,
    @GiaNhap INT,
    @ThanhTien INT
AS
BEGIN
    DECLARE @MaTruyen CHAR(5)
    
    -- Lấy mã truyện dựa trên tên truyện
    SELECT @MaTruyen = MaTruyen
    FROM Truyen
    WHERE TenTruyen = @TenTruyen
    
    -- Cập nhật thông tin trong bảng ChiTietHoaDonBan
    UPDATE ChiTietHoaDonNhap
    SET SoLuongNhap = @SoLuongNhap,
        GiaNhap = @GiaNhap,
        ThanhTien = @ThanhTien
    WHERE MaHoaDonNhap = @MaHoaDonNhap
        AND MaTruyen = @MaTruyen
END

GO	

--xoá chi tiết hoá đơn nhập
CREATE PROCEDURE sp_XoaCTHoaDonNhap
    @MaHoaDonNhap CHAR(5),
    @TenTruyen NVARCHAR(100),
    @SoLuongNhap INT,
    @GiaNhap INT,
    @ThanhTien INT
AS
BEGIN
    DECLARE @MaTruyen CHAR(5)
    
    -- Lấy mã truyện dựa trên tên truyện
    SELECT @MaTruyen = MaTruyen
    FROM Truyen
    WHERE TenTruyen = @TenTruyen
    
    -- Xoá thông tin trong bảng ChiTietHoaDonBan
    DELETE FROM ChiTietHoaDonNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap
        AND MaTruyen = @MaTruyen
		AND	SoLuongNhap = @SoLuongNhap
		AND	GiaNhap = @GiaNhap
		AND ThanhTien = @ThanhTien		
END
GO

CREATE PROCEDURE sp_Top5TruyenBanChay
AS
BEGIN
    SELECT TOP 5
        T.MaTruyen,
        T.TenTruyen,
        SUM(CTHD.SoLuongBan) AS TongSoLuongBan,
        SUM(CTHD.ThanhTien) AS TongTienBan
    FROM 
        Truyen T
    JOIN 
        ChiTietHoaDonBan CTHD ON T.MaTruyen = CTHD.MaTruyen
    GROUP BY 
        T.MaTruyen, T.TenTruyen
    ORDER BY 
        TongSoLuongBan DESC
END
GO

CREATE PROCEDURE sp_Top5NhanVienXuatSac
AS
BEGIN
    SELECT TOP 5
		NV.MaNV,
		NV.HoTenNV,
		SUM(HDB.TongTien) AS TongTienBan
	FROM 
		NhanVien NV
	JOIN 
		HoaDonBan HDB ON NV.MaNV = HDB.MaNhanVienBan
	GROUP BY 
		NV.MaNV, NV.HoTenNV
	ORDER BY 
		SUM(HDB.TongTien) DESC
END
GO

CREATE PROCEDURE sp_Top5KhachHangTiemNang
AS
BEGIN
    SELECT TOP 5
        KHTV.MaKHTV,
        KHTV.HoTenKHTV,
        SUM(HDB.TongTien) AS TongTienMua,
        SUM(CTHDB.SoLuongBan) AS TongSoLuongSanPhamMua
    FROM 
        KhachHangThanhVien KHTV
    JOIN 
        HoaDonBan HDB ON KHTV.MaKHTV = HDB.MaKHTV
    JOIN
        ChiTietHoaDonBan CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    GROUP BY 
        KHTV.MaKHTV, KHTV.HoTenKHTV
    ORDER BY 
        SUM(HDB.TongTien) DESC
END
GO

-- Tạo một thủ tục lấy thông tin doanh thu
CREATE PROCEDURE sp_DoanhThu
    @NgayBatDau DATE, 
    @NgayKetThuc DATE 
AS
BEGIN
    SELECT
        Ngay AS NgayThangNam,
        SUM(TongTienBan) AS 'Tổng bán',
        SUM(TongTienNhap) AS 'Tổng nhập',
        SUM
		(
			SUM(TongTienBan) - SUM(TongTienNhap)) 
			--hàm cửa sổ sử dụng để thực hiện phép tính trên 1 tập hợp con của các hàng
			OVER (ORDER BY Ngay --sắp xếp theo trường Ngay
			ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW 
			--phạm vi: UNBOUNDED PRECEDING (bắt đầu từ hàng đầu tiên)
			--		   CURRENT ROW (kết thúc ở hàng hiện tại)
		) AS 'Doanh thu'
    FROM    
    (
        SELECT NgayBan AS Ngay, TongTien AS TongTienBan, 0 AS TongTienNhap FROM HoaDonBan
        UNION ALL
        SELECT NgayNhap AS Ngay, 0 AS TongTienBan, TongTien AS TongTienNhap FROM HoaDonNhap
    ) AS TongTienBanNhap
    WHERE Ngay BETWEEN @NgayBatDau AND @NgayKetThuc
    GROUP BY Ngay
    HAVING SUM(TongTienBan) > 0 OR SUM(TongTienNhap) > 0
    ORDER BY Ngay;
END;
GO


CREATE TRIGGER trg_Insert_NhanVien
ON NhanVien
AFTER INSERT
AS
BEGIN
    INSERT INTO TaiKhoan(UserName, PassWord, Quyen)
    SELECT i.MaNV, '123', 0 FROM inserted i
END
GO


SELECT * FROM dbo.TaiKhoan



USE [QLBH]
GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONNHAP_DeleteByMAHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONNHAP_DeleteByMAHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from CHITIETHOADONNHAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONNHAP_DeleteByMAHANG]
	(
	@MAHANG int
	)
AS
	SET NOCOUNT ON

	DELETE FROM CHITIETHOADONNHAP WHERE [MAHANG]=@MAHANG

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONNHAP_GetBySOHOADON]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONNHAP_GetBySOHOADON]
	(
	@SOHOADON int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM CHITIETHOADONNHAP WHERE [SOHOADON] =@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_DeleteByID]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_DeleteByID
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_DeleteByID]
	(
	@ID int
	)
AS
	SET NOCOUNT ON

	DELETE FROM CHITIETHOADONXUAT WHERE [ID]=@ID

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_DeleteByMAHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_DeleteByMAHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_DeleteByMAHANG]
	(
	@MAHANG int
	)
AS
	SET NOCOUNT ON

	DELETE FROM CHITIETHOADONXUAT WHERE [MAHANG]=@MAHANG

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_DeleteBySOHOADON]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_DeleteByID
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_DeleteBySOHOADON]
	(
	@SOHOADON int
	)
AS
	SET NOCOUNT ON

	DELETE FROM CHITIETHOADONXUAT WHERE [SOHOADON]=@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM CHITIETHOADONXUAT

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_GetByID]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_GetByID
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_GetByID]
	(
	@ID int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM CHITIETHOADONXUAT WHERE [ID]=@ID

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_GetBySOHOADON]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_GetBySOHOADON]
	(
	@SOHOADON int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM CHITIETHOADONXUAT WHERE [SOHOADON] =@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_Insert]
(
	
	@SOHOADON int,
	@MAHANG int,
	@GIABAN bigint,
	@GIANHAP bigint,
	@SOLUONG int
)
AS
	SET NOCOUNT ON

	INSERT INTO CHITIETHOADONXUAT
			([SOHOADON] ,[MAHANG] ,[GIABAN] ,[GIANHAP] ,[SOLUONG])
	VALUES	(@SOHOADON ,@MAHANG ,@GIABAN ,@GIANHAP ,@SOLUONG )
    

	SELECT  Scope_Identity() AS [ID];

GO
/****** Object:  StoredProcedure [dbo].[CHITIETHOADONXUAT_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	CHITIETHOADONXUAT_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	CHITIETHOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[CHITIETHOADONXUAT_Update]
(
	
	@SOHOADON int,
	@MAHANG int,
	@GIABAN bigint,
	@GIANHAP bigint,
	@SOLUONG int,
	@ID int
)
AS
	SET NOCOUNT ON

	UPDATE CHITIETHOADONXUAT SET 

		[SOHOADON] = @SOHOADON ,
		[MAHANG] = @MAHANG ,
		[GIABAN] = @GIABAN ,
		[GIANHAP] = @GIANHAP ,
		[SOLUONG] = @SOLUONG 
	WHERE [ID]=@ID

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_DeleteByMADONVITINH]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	DONVITINH_DeleteByMADONVITINH
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from DONVITINH table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_DeleteByMADONVITINH]
	(
	@MADONVITINH int
	)
AS
	SET NOCOUNT ON

	DELETE FROM DONVITINH WHERE [MADONVITINH]=@MADONVITINH

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	DONVITINH_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from DONVITINH table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM DONVITINH
	ORDER BY TENDONVITINH

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_GetByMADONVITINH]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	DONVITINH_GetByMADONVITINH
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from DONVITINH table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_GetByMADONVITINH]
	(
	@MADONVITINH int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM DONVITINH WHERE [MADONVITINH]=@MADONVITINH

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_GetByTENDONVITINH]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_GetByTENDONVITINH]
	(
	@TENDONVITINH nvarchar(50)
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM DONVITINH WHERE [TENDONVITINH]=@TENDONVITINH

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	DONVITINH_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to DONVITINH table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_Insert]
(
	
	@TENDONVITINH nvarchar(50)
)
AS
	SET NOCOUNT ON

	INSERT INTO DONVITINH
			([TENDONVITINH] )
	VALUES	(@TENDONVITINH )
    

	SELECT  Scope_Identity() AS [MADONVITINH];

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_SearchTENDONVITINH]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_SearchTENDONVITINH]
	(
	@TENDONVITINH nvarchar(50)
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM DONVITINH WHERE [TENDONVITINH] like N'%'+@TENDONVITINH+'%'

GO
/****** Object:  StoredProcedure [dbo].[DONVITINH_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	DONVITINH_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	DONVITINH table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[DONVITINH_Update]
(
	
	@MADONVITINH int,
	@TENDONVITINH nvarchar(50)
)
AS
	SET NOCOUNT ON

	UPDATE DONVITINH SET 

		[TENDONVITINH] = @TENDONVITINH 
	WHERE [MADONVITINH]=@MADONVITINH

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_DeleteBySOHOADON]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	HOADONXUAT_DeleteBySOHOADON
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from HOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[HOADONXUAT_DeleteBySOHOADON]
	(
	@SOHOADON int
	)
AS
	SET NOCOUNT ON

	DELETE FROM HOADONXUAT WHERE [SOHOADON]=@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	HOADONXUAT_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from HOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[HOADONXUAT_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM HOADONXUAT

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByDayThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByDayThanhTien] @ENDDAY nvarchar(20)
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where DATEDIFF(DD,NGAYGIAOHANG,@ENDDAY) = 0
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByDayToDayThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByDayToDayThanhTien] @STARDAY nvarchar(20),@ENDDAY nvarchar(20)
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where NGAYGIAOHANG BETWEEN @STARDAY and @ENDDAY
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByEveryMonth]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByEveryMonth] @ENDDAY nvarchar(20)
AS
	select MONTH(NGAYGIAOHANG) as THANG,SUM(THANHTIEN) as THANHTIEN, SUM(TIENLOI) as TIENLOI
	from HOADONXUAT
	where DATEDIFF(yy,NGAYGIAOHANG,@ENDDAY) = 0
	group by MONTH(NGAYGIAOHANG)
	order by MONTH(NGAYGIAOHANG) asc

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByEveryNgay]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByEveryNgay] @ENDDAY nvarchar(20)
AS
	select DAY(NGAYGIAOHANG) as THANG,SUM(THANHTIEN) as THANHTIEN, SUM(TIENLOI) as TIENLOI
	from HOADONXUAT
	where DATEDIFF(MM,NGAYGIAOHANG,@ENDDAY) = 0
	group by DAY(NGAYGIAOHANG)
	order by DAY(NGAYGIAOHANG) asc

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByEveryQui]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByEveryQui] @ENDDAY nvarchar(20)
AS
	select DATEPART(QQ,NGAYGIAOHANG) as THANG,SUM(THANHTIEN) as THANHTIEN, SUM(TIENLOI) as TIENLOI
	from HOADONXUAT
	where DATEDIFF(yy,NGAYGIAOHANG,@ENDDAY) = 0
	group by DATEPART(QQ,NGAYGIAOHANG)
	order by DATEPART(QQ,NGAYGIAOHANG) asc

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByEveryTuan]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByEveryTuan] @ENDDAY nvarchar(20)
AS
	select ((datepart(dd,NGAYGIAOHANG)-1) / 7 + 1) as THANG,SUM(THANHTIEN) as THANHTIEN, SUM(TIENLOI) as TIENLOI
	from HOADONXUAT
	where DATEDIFF(MM,NGAYGIAOHANG,@ENDDAY) = 0
	group by ((datepart(dd,NGAYGIAOHANG)-1) / 7 + 1)
	order by ((datepart(dd,NGAYGIAOHANG)-1) / 7 + 1) asc

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByMonthThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByMonthThanhTien] @ENDDAY nvarchar(20)
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where DATEDIFF(MM,NGAYGIAOHANG,@ENDDAY) = 0
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByQuaTerThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByQuaTerThanhTien] @NAM int,@QuaTer int
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where DATEPART(QQ,NGAYGIAOHANG) = @QuaTer and YEAR(NGAYGIAOHANG) = @NAM
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetBySOHOADON]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	HOADONXUAT_GetBySOHOADON
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from HOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[HOADONXUAT_GetBySOHOADON]
	(
	@SOHOADON int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM HOADONXUAT WHERE [SOHOADON]=@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByWeekThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByWeekThanhTien] @ENDDAY nvarchar(20),@Tuan int
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where ((datepart(dd,NGAYGIAOHANG)-1) / 7 + 1) = @Tuan and DATEDIFF(MM,NGAYGIAOHANG,@ENDDAY) = 0
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_GetByYearThanhTien]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HOADONXUAT_GetByYearThanhTien] @NAM int
AS
	select TENHANG,Sum(c.SOLUONG) as SOLUONG,C.GIABAN,(Sum(c.SOLUONG)*C.GIABAN) as THANHTIEN, (Sum(c.SOLUONG) * ROUND((C.GIABAN-C.GIANHAP),0)) as TIENLOI
	from HOADONXUAT H
	join CHITIETHOADONXUAT C ON C.SOHOADON = H.SOHOADON
	join MATHANG M ON M.MAHANG = C.MAHANG
	 where YEAR(NGAYGIAOHANG) = @NAM
	 group by TENHANG,C.GIABAN,C.GIANHAP
	 order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	HOADONXUAT_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to HOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[HOADONXUAT_Insert]
(
	
	@MAKHACHHANG int,
	@NGAYDATHANG datetime,
	@NGAYGIAOHANG datetime,
	@DIADIEM nvarchar(100) = NULL,
	@THANHTIEN bigint,
	@TIENLOI bigint = NULL,
	@MANHANVIEN int
)
AS
	SET NOCOUNT ON

	INSERT INTO HOADONXUAT
			([MAKHACHHANG] ,[NGAYDATHANG] ,[NGAYGIAOHANG] ,[DIADIEM] ,[THANHTIEN] ,[TIENLOI], [MANHANVIEN])
	VALUES	(@MAKHACHHANG ,@NGAYDATHANG ,@NGAYGIAOHANG ,@DIADIEM ,@THANHTIEN ,@TIENLOI, @MANHANVIEN )
    

	SELECT  Scope_Identity() AS [SOHOADON];

GO
/****** Object:  StoredProcedure [dbo].[HOADONXUAT_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	HOADONXUAT_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	HOADONXUAT table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[HOADONXUAT_Update]
(
	
	@SOHOADON int,
	@MAKHACHHANG int,
	@NGAYDATHANG datetime,
	@NGAYGIAOHANG datetime,
	@DIADIEM nvarchar(100) = NULL,
	@THANHTIEN bigint,
	@TIENLOI bigint = NULL,
	@MANHANVIEN int
)
AS
	SET NOCOUNT ON

	UPDATE HOADONXUAT SET 

		[MAKHACHHANG] = @MAKHACHHANG ,
		[NGAYDATHANG] = @NGAYDATHANG ,
		[NGAYGIAOHANG] = @NGAYGIAOHANG ,
		[DIADIEM] = @DIADIEM ,
		[THANHTIEN] = @THANHTIEN ,
		[TIENLOI] = @TIENLOI ,
		[MANHANVIEN] = @MANHANVIEN
	WHERE [SOHOADON]=@SOHOADON

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_DeleteByMAKHACHHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	KHACHHANG_DeleteByMAKHACHHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from KHACHHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[KHACHHANG_DeleteByMAKHACHHANG]
	(
	@MAKHACHHANG int
	)
AS
	SET NOCOUNT ON

	DELETE FROM KHACHHANG WHERE [MAKHACHHANG]=@MAKHACHHANG

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	KHACHHANG_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from KHACHHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[KHACHHANG_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM KHACHHANG
	ORDER BY TENKHACHHANG

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_GetByMAKHACHHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	KHACHHANG_GetByMAKHACHHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from KHACHHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[KHACHHANG_GetByMAKHACHHANG]
	(
	@MAKHACHHANG int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM KHACHHANG WHERE [MAKHACHHANG]=@MAKHACHHANG

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	KHACHHANG_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to KHACHHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[KHACHHANG_Insert]
(
	
	@TENKHACHHANG nvarchar(50) = NULL,
	@DIACHI nvarchar(50) = NULL,
	@EMAIL nvarchar(50) = NULL,
	@DIENTHOAI nvarchar(13) = NULL,
	@FAX nvarchar(13) = NULL
)
AS
	SET NOCOUNT ON

	INSERT INTO KHACHHANG
			([TENKHACHHANG] ,[DIACHI] ,[EMAIL] ,[DIENTHOAI] ,[FAX] )
	VALUES	(@TENKHACHHANG ,@DIACHI ,@EMAIL ,@DIENTHOAI ,@FAX)
    

	SELECT  Scope_Identity() AS [MAKHACHHANG];

GO
/****** Object:  StoredProcedure [dbo].[KHACHHANG_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	KHACHHANG_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	KHACHHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[KHACHHANG_Update]
(
	
	@MAKHACHHANG int,
	@TENKHACHHANG nvarchar(50) = NULL,
	@DIACHI nvarchar(50) = NULL,
	@EMAIL nvarchar(50) = NULL,
	@DIENTHOAI nvarchar(13) = NULL,
	@FAX nvarchar(13) = NULL
)
AS
	SET NOCOUNT ON

	UPDATE KHACHHANG SET 

		[TENKHACHHANG] = @TENKHACHHANG ,
		[DIACHI] = @DIACHI ,
		[EMAIL] = @EMAIL ,
		[DIENTHOAI] = @DIENTHOAI ,
		[FAX] = @FAX
	WHERE [MAKHACHHANG]=@MAKHACHHANG

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_DeleteByMALOAIHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	LOAIHANG_DeleteByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_DeleteByMALOAIHANG]
	(
	@MALOAIHANG int
	)
AS
	SET NOCOUNT ON

	DELETE FROM LOAIHANG WHERE [MALOAIHANG]=@MALOAIHANG

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM LOAIHANG
	ORDER BY TENLOAIHANG

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_GetByMALOAIHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_GetByMALOAIHANG]
	(
	@MALOAIHANG int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM LOAIHANG WHERE [MALOAIHANG]=@MALOAIHANG

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_GetByTENLOAIHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_GetByTENLOAIHANG]
	(
	@TENLOAIHANG nvarchar(100)
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM LOAIHANG WHERE [TENLOAIHANG]=@TENLOAIHANG

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	LOAIHANG_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_Insert]
(
	
	@TENLOAIHANG nvarchar(100)
)
AS
	SET NOCOUNT ON

	INSERT INTO LOAIHANG
			([TENLOAIHANG] )
	VALUES	(@TENLOAIHANG )
    

	SELECT  Scope_Identity() AS [MALOAIHANG];

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_SearchTENLOAIHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_SearchTENLOAIHANG]
	(
	@TENLOAIHANG nvarchar(100)
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM LOAIHANG WHERE [TENLOAIHANG] like N'%'+@TENLOAIHANG+'%'

GO
/****** Object:  StoredProcedure [dbo].[LOAIHANG_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[LOAIHANG_Update]
(
	
	@MALOAIHANG int,
	@TENLOAIHANG nvarchar(100)
)
AS
	SET NOCOUNT ON

	UPDATE LOAIHANG SET 

		[TENLOAIHANG] = @TENLOAIHANG 
	WHERE [MALOAIHANG]=@MALOAIHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_DeleteByMAHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	MATHANG_DeleteByMAHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_DeleteByMAHANG]
	(
	@MAHANG int
	)
AS
	SET NOCOUNT ON

	DELETE FROM MATHANG WHERE [MAHANG]=@MAHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_DONVITINH_GetByTENDONVITINH]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_DONVITINH_GetByTENDONVITINH] @TENDONVITINH nvarchar(50)
AS
	SELECT MAHANG,BARCODE,TENHANG,TENHANGKHONGDAU,MATHANG.MANHACUNGCAP,MALOAIHANG,SOLUONG,MATHANG.MADONVITINH,GIANHAP,GIABAN,NGAYCAPNHAT
	FROM DONVITINH JOIN MATHANG ON MATHANG.MADONVITINH = DONVITINH.MADONVITINH WHERE [TENDONVITINH] like '%'+@TENDONVITINH+'%'
	order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	MATHANG_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM MATHANG ORDER BY TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetAllHangTonKho]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	MATHANG_GetAllHangTonKho
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_GetAllHangTonKho]
AS
	SET NOCOUNT ON

	SELECT MAHANG,BARCODE,TENHANG,TENNHACUNGCAP,TENDONVITINH,TENLOAIHANG,SOLUONG,GIANHAP,ROUND((GIABAN-GIANHAP),0) as TIENLOI,GIABAN,NGAYCAPNHAT,Sum(SOLUONG*GIABAN) as TOTAL_SL_GB, Sum(SOLUONG*GIANHAP) as TOTAL_SL_GN
	FROM MATHANG join NHACUNGCAP on MATHANG.MANHACUNGCAP = NHACUNGCAP.MANHACUNGCAP  join DONVITINH on MATHANG.MADONVITINH = DONVITINH.MADONVITINH join LOAIHANG on MATHANG.MALOAIHANG = LOAIHANG.MALOAIHANG
	GROUP BY MAHANG,BARCODE,TENHANG,TENNHACUNGCAP,TENDONVITINH,TENLOAIHANG,SOLUONG,GIANHAP,GIABAN,NGAYCAPNHAT
	ORDER BY TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetByBARCODE]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_GetByBARCODE] @BARCODE varchar(13)
AS
	SELECT *  FROM MATHANG WHERE [BARCODE]=@BARCODE

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetByBARCODE_DAUDUOI]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_GetByBARCODE_DAUDUOI] @BARCODE varchar(13)
AS
	SELECT *  FROM MATHANG WHERE BARCODE like '%' + @BARCODE + '%'
	order by BARCODE

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetByMAHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	MATHANG_GetByMAHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_GetByMAHANG]
	(
	@MAHANG int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM MATHANG WHERE [MAHANG]=@MAHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetByNGAYCAPNHAT_THOIGIAN]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_GetByNGAYCAPNHAT_THOIGIAN] @THOIGIAN nvarchar(20)
AS
	SELECT *  FROM MATHANG WHERE DATEDIFF(dd,@THOIGIAN,NGAYCAPNHAT) <= 0
	--tang dan theo ngay
	order by NGAYCAPNHAT asc

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_GetByTENHANGKHONGDAU]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_GetByTENHANGKHONGDAU] @TENHANGKHONGDAU nvarchar(50)
AS
	SELECT *  FROM MATHANG WHERE [TENHANGKHONGDAU] like '%'+@TENHANGKHONGDAU+'%' or [TENHANG] like N'%'+@TENHANGKHONGDAU+'%'

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_HANGTONKHO_UPDATE]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_HANGTONKHO_UPDATE]
(
	@MAHANG int,
	@SOLUONG int = NULL,
	@GIANHAP bigint = NULL,
	@GIABAN bigint = NULL,
	@NGAYCAPNHAT datetime = NULL
)
AS
	SET NOCOUNT ON

	SET NOCOUNT ON

	UPDATE MATHANG SET 
		[SOLUONG] = @SOLUONG ,
		[GIANHAP] = @GIANHAP ,
		[GIABAN] = @GIABAN ,
		[NGAYCAPNHAT] = @NGAYCAPNHAT 
	WHERE [MAHANG]=@MAHANG
    


GO
/****** Object:  StoredProcedure [dbo].[MATHANG_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	MATHANG_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_Insert]
(
	
	@BARCODE nchar(13) = NULL,
	@TENHANG nvarchar(50) = NULL,
	@TENHANGKHONGDAU nvarchar(50) = NULL,
	@MANHACUNGCAP int = NULL,
	@MALOAIHANG int = NULL,
	@MADONVITINH int = NULL,
	@SOLUONG int = NULL,
	@GIANHAP bigint = NULL,
	@GIABAN bigint = NULL,
	@NGAYCAPNHAT datetime = NULL
)
AS
	SET NOCOUNT ON

	INSERT INTO MATHANG
			([BARCODE] ,[TENHANG] ,[TENHANGKHONGDAU] ,[MANHACUNGCAP] ,[MALOAIHANG] ,[SOLUONG] ,[MADONVITINH] ,[GIANHAP] ,[GIABAN] ,[NGAYCAPNHAT] )
	VALUES	(@BARCODE ,@TENHANG ,@TENHANGKHONGDAU ,@MANHACUNGCAP ,@MALOAIHANG ,@SOLUONG ,@MADONVITINH ,@GIANHAP ,@GIABAN ,@NGAYCAPNHAT )
    

	SELECT  Scope_Identity() AS [MAHANG];

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_LOAIHANG_GetByTENLOAIHANG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_LOAIHANG_GetByTENLOAIHANG] @TENLOAIHANG nvarchar(100)
AS
	SELECT MAHANG,BARCODE,TENHANG,TENHANGKHONGDAU,MATHANG.MANHACUNGCAP,MATHANG.MALOAIHANG,SOLUONG,MADONVITINH,GIANHAP,GIABAN,NGAYCAPNHAT
	FROM LOAIHANG JOIN MATHANG ON MATHANG.MALOAIHANG = LOAIHANG.MALOAIHANG WHERE [TENLOAIHANG] like '%'+@TENLOAIHANG+'%'
	order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_NHACUNGCAP_GetByTENNHACUNGCAP]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_NHACUNGCAP_GetByTENNHACUNGCAP] @TENNHACUNGCAP nvarchar(50)
AS
	SELECT MAHANG,BARCODE,TENHANG,TENHANGKHONGDAU,MATHANG.MANHACUNGCAP,MALOAIHANG,SOLUONG,MADONVITINH,GIANHAP,GIABAN,NGAYCAPNHAT
	FROM NHACUNGCAP JOIN MATHANG ON MATHANG.MANHACUNGCAP = NHACUNGCAP.MANHACUNGCAP WHERE [TENNHACUNGCAP] like '%'+@TENNHACUNGCAP+'%'
	order by TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_SearchByBARCODE]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MATHANG_SearchByBARCODE] @BARCODE varchar(13)
AS
	SELECT *  FROM MATHANG WHERE [BARCODE] like '%'+@BARCODE+'%'

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_SearchHangTonKho]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	MATHANG_SearchHangTonKho
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_SearchHangTonKho] @SEARCHDATA varchar(50)
AS
	SET NOCOUNT ON

	SELECT MAHANG,BARCODE,TENHANG,TENNHACUNGCAP,TENDONVITINH,TENLOAIHANG,SOLUONG,GIANHAP,(GIABAN-GIANHAP) as TIENLOI,GIABAN,NGAYCAPNHAT,Sum(SOLUONG*GIABAN) as TOTAL_SL_GB, Sum(SOLUONG*GIANHAP) as TOTAL_SL_GN
	FROM MATHANG join NHACUNGCAP on MATHANG.MANHACUNGCAP = NHACUNGCAP.MANHACUNGCAP  join DONVITINH on MATHANG.MADONVITINH = DONVITINH.MADONVITINH join LOAIHANG on MATHANG.MALOAIHANG = LOAIHANG.MALOAIHANG
	WHERE [BARCODE] like '%'+@SEARCHDATA+'%' or [TENHANGKHONGDAU] like '%'+@SEARCHDATA+'%' or [TENHANG] like N'%'+@SEARCHDATA+'%' or [TENNHACUNGCAP] like '%'+@SEARCHDATA+'%' or [TENDONVITINH] like N'%'+@SEARCHDATA+'%' or [TENLOAIHANG] like N'%'+@SEARCHDATA+'%' or [GIANHAP] like '%'+@SEARCHDATA+'%' or [GIABAN] like '%'+@SEARCHDATA+'%'
	GROUP BY MAHANG,BARCODE,TENHANG,TENNHACUNGCAP,TENDONVITINH,TENLOAIHANG,SOLUONG,GIANHAP,GIABAN,NGAYCAPNHAT
	ORDER BY TENHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_SearchTENHANGKHONGDAU]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[MATHANG_SearchTENHANGKHONGDAU] @TENHANGKHONGDAU nvarchar(50)
AS
	SELECT top 30 * FROM MATHANG WHERE [TENHANGKHONGDAU] like '%'+@TENHANGKHONGDAU+'%' or [TENHANG] like N'%'+@TENHANGKHONGDAU+'%'

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	MATHANG_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_Update]
(
	
	@MAHANG int,
	@BARCODE nchar(13) = NULL,
	@TENHANG nvarchar(50) = NULL,
	@TENHANGKHONGDAU nvarchar(50) = NULL,
	@MANHACUNGCAP int = NULL,
	@MALOAIHANG int = NULL,
	@MADONVITINH int = NULL,
	@SOLUONG int = NULL,
	@GIANHAP bigint = NULL,
	@GIABAN bigint = NULL,
	@NGAYCAPNHAT datetime = NULL
)
AS
	SET NOCOUNT ON

	UPDATE MATHANG SET 

		[BARCODE] = @BARCODE ,
		[TENHANG] = @TENHANG ,
		[TENHANGKHONGDAU] = @TENHANGKHONGDAU ,
		[MANHACUNGCAP] = @MANHACUNGCAP ,
		[MALOAIHANG] = @MALOAIHANG ,
		[MADONVITINH] = @MADONVITINH ,
		[SOLUONG] = @SOLUONG ,
		[GIANHAP] = @GIANHAP ,
		[GIABAN] = @GIABAN ,
		[NGAYCAPNHAT] = @NGAYCAPNHAT 
	WHERE [MAHANG]=@MAHANG

GO
/****** Object:  StoredProcedure [dbo].[MATHANG_Update_CONGSOLUONG]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	MATHANG_Update_CONGSOLUONG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from MATHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[MATHANG_Update_CONGSOLUONG]
	(
	@MAHANG int,
	@SOLUONG int
	)
AS
	SET NOCOUNT ON

	update MATHANG set [SOLUONG] = [SOLUONG] + @SOLUONG where [MAHANG] = @MAHANG

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_DeleteByMANHACUNGCAP]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	NHACUNGCAP_DeleteByMANHACUNGCAP
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for deleting a specific row from NHACUNGCAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_DeleteByMANHACUNGCAP]
	(
	@MANHACUNGCAP int
	)
AS
	SET NOCOUNT ON

	DELETE FROM NHACUNGCAP WHERE [MANHACUNGCAP]=@MANHACUNGCAP

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_GetALL]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	NHACUNGCAP_GetALL
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting all rows from NHACUNGCAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_GetALL]
AS
	SET NOCOUNT ON

	SELECT *  FROM NHACUNGCAP
	ORDER BY TENNHACUNGCAP

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_GetByMANHACUNGCAP]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	NHACUNGCAP_GetByMANHACUNGCAP
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from NHACUNGCAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_GetByMANHACUNGCAP]
	(
	@MANHACUNGCAP int
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM NHACUNGCAP WHERE [MANHACUNGCAP]=@MANHACUNGCAP

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_Insert]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ==========================================================================================
-- Entity Name:	NHACUNGCAP_Insert
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for inserting values to NHACUNGCAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_Insert]
(
	
	@TENNHACUNGCAP nvarchar(50) = NULL,
	@DIACHI nvarchar(50) = NULL,
	@DIENTHOAI nvarchar(13) = NULL,
	@FAX nvarchar(13) = NULL,
	@EMAIL nvarchar(50)
)
AS
	SET NOCOUNT ON

	INSERT INTO NHACUNGCAP
			([TENNHACUNGCAP] ,[DIACHI] ,[DIENTHOAI] ,[FAX] ,[EMAIL] )
	VALUES	(@TENNHACUNGCAP ,@DIACHI ,@DIENTHOAI ,@FAX ,@EMAIL )
    

	SELECT  Scope_Identity() AS [MANHACUNGCAP];

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_SearchTENNHACUNGCAP]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	LOAIHANG_GetByMALOAIHANG
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for selecting a row by specified primary key from LOAIHANG table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_SearchTENNHACUNGCAP]
	(
	@TENNHACUNGCAP nvarchar(50)
	)
AS
	SET NOCOUNT ON

	SELECT *  FROM NHACUNGCAP WHERE [TENNHACUNGCAP] like N'%'+@TENNHACUNGCAP+'%'

GO
/****** Object:  StoredProcedure [dbo].[NHACUNGCAP_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ==========================================================================================
-- Entity Name:	NHACUNGCAP_Update
-- Generator:	Salar dotNET DbCodeGenerator
-- Create date:	8/17/2013 12:17:06 AM
-- Description:	This stored procedure is intended for updating 	NHACUNGCAP table
-- ==========================================================================================
CREATE PROCEDURE [dbo].[NHACUNGCAP_Update]
(
	
	@MANHACUNGCAP int,
	@TENNHACUNGCAP nvarchar(50) = NULL,
	@DIACHI nvarchar(50) = NULL,
	@DIENTHOAI nvarchar(13) = NULL,
	@FAX nvarchar(13) = NULL,
	@EMAIL nvarchar(50)
)
AS
	SET NOCOUNT ON

	UPDATE NHACUNGCAP SET 

		[TENNHACUNGCAP] = @TENNHACUNGCAP ,
		[DIACHI] = @DIACHI ,
		[DIENTHOAI] = @DIENTHOAI ,
		[FAX] = @FAX ,
		[EMAIL] = @EMAIL 
	WHERE [MANHACUNGCAP]=@MANHACUNGCAP

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Delete]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_Delete]
	(
	@ID bigint
	)
AS
	SET NOCOUNT ON

	DELETE NHANVIEN where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_GetAll]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_GetAll]
AS
	SET NOCOUNT ON
	SELECT *
	FROM NHANVIEN

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_GetByChucVu]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_GetByChucVu]
	(
	@CHUCVU int
	)
AS
	SET NOCOUNT ON

	SELECT * FROM NHANVIEN WHERE [CHUCVU] = @CHUCVU

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_GetByHOTEN]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_GetByHOTEN]
	(
	@HOTEN nvarchar(100)
	)
AS
	SET NOCOUNT ON

	SELECT * FROM NHANVIEN WHERE [HOTEN] like '%' + @HOTEN + '%'

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_GetByID]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_GetByID]
	(
	@ID bigint
	)
AS
	SET NOCOUNT ON

	SELECT * FROM NHANVIEN WHERE [ID] = @ID

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_GetByTenDN]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_GetByTenDN]
	(
	@TENDN nvarchar(100)
	)
AS
	SET NOCOUNT ON

	SELECT * FROM NHANVIEN WHERE [TENDN] like '%' + @TENDN + '%'

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_INSERT]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_INSERT]
(
	@TENDN nvarchar(100) = NULL,
	@MATKHAU nvarchar(1000) = NULL,
	@HOTEN nvarchar(100) = NULL,
	@DIENTHOAI nvarchar(15),
	@DIACHI nvarchar(500),
	@CHUCVU int = NULL,
	@TRANGTHAI int = NULL,
	@NGAYTAO datetime = NULL,
	@NGAYCAPNHAT datetime = NULL
)
AS
	SET NOCOUNT ON
	INSERT INTO NHANVIEN
			([TENDN] ,[MATKHAU],[HOTEN],[DIENTHOAI],[DIACHI],[CHUCVU],[TRANGTHAI],[NGAYTAO],[NGAYCAPNHAT])
	VALUES	(@TENDN ,@MATKHAU,@HOTEN,@DIENTHOAI,@DIACHI,@CHUCVU,@TRANGTHAI,@NGAYTAO,@NGAYCAPNHAT)

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Login]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_Login]
	(
	@TENDN nvarchar(100),
	@MATKHAU nvarchar(1000)
	)
AS
	SET NOCOUNT ON

	SELECT * FROM NHANVIEN WHERE [TENDN] = @TENDN and MATKHAU = @MATKHAU

GO
/****** Object:  StoredProcedure [dbo].[NHANVIEN_Update]    Script Date: 3/28/2018 2:31:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHANVIEN_Update]
(
	@ID bigint,
	@TENDN nvarchar(100) = NULL,
	@MATKHAU nvarchar(1000) = NULL,
	@HOTEN nvarchar(100) = NULL,
	@DIENTHOAI nvarchar(15),
	@DIACHI nvarchar(500),
	@CHUCVU int,
	@TRANGTHAI int,
	@NGAYCAPNHAT datetime = NULL
)
AS
	SET NOCOUNT ON

	UPDATE NHANVIEN SET 
		[TENDN] = @TENDN ,
		[MATKHAU] = @MATKHAU ,
		[HOTEN] = @HOTEN ,
		[DIENTHOAI] = @DIENTHOAI ,
		[DIACHI] = @DIACHI ,
		[CHUCVU] = @CHUCVU ,
		[TRANGTHAI] = @TRANGTHAI ,
		[NGAYCAPNHAT] = @NGAYCAPNHAT
	WHERE [ID]=@ID

GO

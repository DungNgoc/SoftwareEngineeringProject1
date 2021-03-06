/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLHS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLHS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLHS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLHS]
GO

USE [QLHS]
GO


/****** Object:  Table [dbo].[tblHocsinh]    Script Date: 04/17/2018 11:59:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocsinh](
	[Mahocsinh] [nvarchar](10) NOT NULL,
	[Hotenhocsinh] [nvarchar](40) NOT NULL,
	[Gioitinh] [nvarchar](20) NOT NULL,
	[Ngaysinh] [datetime2] (7) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Malop] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblHocsinh] PRIMARY KEY CLUSTERED

(
	[Mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLHS]
GO

/****** Object:  Table [dbo].[tblLop]    Script Date: 04/21/2018 02:26:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLop](
	[Malop] [nvarchar](10) NOT NULL,
	[Tenlop] [nvarchar](20) NULL,
	[Solop] [int] NULL,
	[Makhoi] [nvarchar](10),
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [QLHS]
GO

/****** Object:  Table [dbo].[tblKhoi]    Script Date: 04/21/2018 08:10:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhoi](
	[Makhoi] [nvarchar](10) NOT NULL,
	[Tenkhoi] [nvarchar](20) NULL,
	[Sokhoi] [int] NULL,
 CONSTRAINT [PK_tblKhoi] PRIMARY KEY CLUSTERED 
(
	[Makhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--alter table tblHocsinh add constraint FK_tblLop_tblHocsinh foreign key (Malop) references tblLop(Malop)

--alter table tblLop add constraint FK_tblKhoi_tblLop foreign key (Makhoi) references tblKhoi(Makhoi)

go
INSERT INTO[dbo].[tblKhoi]([Makhoi],[Tenkhoi],[Sokhoi])
VALUES('1810','10',3)
INSERT INTO[dbo].[tblKhoi]([Makhoi],[Tenkhoi],[Sokhoi])
VALUES('1811','11',3)
INSERT INTO[dbo].[tblKhoi]([Makhoi],[Tenkhoi],[Sokhoi])
VALUES('1812','12',3)

INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181001','10A1',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181002','10A2',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181003','10A3',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181004','10A4',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181005','10A5',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181006','10A6',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181007','10A7',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181008','10A8',20,'1810')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181101','11A1',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181102','11A2',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181103','11A3',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181104','11A4',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181105','11A5',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181106','11A6',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181107','11A7',20,'1811')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181201','12A1',20,'1812')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181202','12A2',20,'1812')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181203','12A3',20,'1812')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181204','12A4',20,'1812')
INSERT INTO[dbo].[tblLop]([Malop],[Tenlop],[Solop],[Makhoi])
VALUES('181205','12A5',20,'1812')



GO
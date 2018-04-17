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
	[Mahocsinh] [nchar](10) NOT NULL,
	[Tenhocsinh] [varchar](40) NOT NULL,
	[Gioitinh] [varchar](20) NOT NULL,
	[Ngaysinh] [smalldatetime] NOT NULL,
	[Diachi] [varchar](50) NOT NULL,
	[Dienthoai] [nchar](11) NOT NULL,
	[Lop] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblHocsinh] PRIMARY KEY CLUSTERED 
(
	[Mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

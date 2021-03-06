USE [master]
GO
/****** Object:  Database [TuDienAnhViet]    Script Date: 12/26/2018 11:29:18 AM ******/
CREATE DATABASE [TuDienAnhViet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TuDienAnhViet', FILENAME = N'E:\Data\TuDienAnhViet.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TuDienAnhViet_log', FILENAME = N'E:\Data\TuDienAnhViet_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TuDienAnhViet] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TuDienAnhViet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TuDienAnhViet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET ARITHABORT OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TuDienAnhViet] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TuDienAnhViet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TuDienAnhViet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TuDienAnhViet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TuDienAnhViet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TuDienAnhViet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TuDienAnhViet] SET  MULTI_USER 
GO
ALTER DATABASE [TuDienAnhViet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TuDienAnhViet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TuDienAnhViet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TuDienAnhViet] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TuDienAnhViet]
GO
/****** Object:  StoredProcedure [dbo].[TuVung_Chon]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_Chon]

AS

SELECT [Từ_Tiếng_Anh]      
      ,[Dịch_Nghĩa_Chi_Tiết]
      ,[Từ_Đồng_Nghĩa]
      ,[Từ_Trái_Nghĩa]
  FROM [dbo].[TuVung]
GO
/****** Object:  StoredProcedure [dbo].[TuVung_ChonTuListbox]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_ChonTuListbox]
	@Từ_Tiếng_Anh nvarchar(100)		
AS

SELECT [Từ_Tiếng_Anh]
      ,[Dịch_Nghĩa_Chi_Tiết]
      ,[Từ_Đồng_Nghĩa]
      ,[Từ_Trái_Nghĩa]
  FROM [dbo].[TuVung]

WHERE [Từ_Tiếng_Anh] = @Từ_Tiếng_Anh


GO
/****** Object:  StoredProcedure [dbo].[TuVung_Sua]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_Sua]	
			@Từ_Tiếng_Anh nvarchar(100)           
           ,@Dịch_Nghĩa_Chi_Tiết nvarchar(max)
           ,@Từ_Đồng_Nghĩa nvarchar(100)
           ,@Từ_Trái_Nghĩa nvarchar(100)

AS

UPDATE [dbo].[TuVung]
   SET [Từ_Tiếng_Anh] = @Từ_Tiếng_Anh      
      ,[Dịch_Nghĩa_Chi_Tiết] = @Dịch_Nghĩa_Chi_Tiết
      ,[Từ_Đồng_Nghĩa] = @Từ_Đồng_Nghĩa
      ,[Từ_Trái_Nghĩa] = @Từ_Trái_Nghĩa
 WHERE [Từ_Tiếng_Anh] = @Từ_Tiếng_Anh

GO
/****** Object:  StoredProcedure [dbo].[TuVung_Them]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_Them]
			@Từ_Tiếng_Anh nvarchar(100)           
           ,@Dịch_Nghĩa_Chi_Tiết nvarchar(max)
           ,@Từ_Đồng_Nghĩa nvarchar(100)
           ,@Từ_Trái_Nghĩa nvarchar(100)

AS

INSERT INTO [dbo].[TuVung]
           ([Từ_Tiếng_Anh]           
           ,[Dịch_Nghĩa_Chi_Tiết]
           ,[Từ_Đồng_Nghĩa]
           ,[Từ_Trái_Nghĩa])
     VALUES
           (@Từ_Tiếng_Anh          
           ,@Dịch_Nghĩa_Chi_Tiết
           ,@Từ_Đồng_Nghĩa
           ,@Từ_Trái_Nghĩa)
GO
/****** Object:  StoredProcedure [dbo].[TuVung_TraTu]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_TraTu]
	@Từ_Tiếng_Anh nvarchar(50)
AS

SELECT [Từ_Tiếng_Anh]      
      ,[Dịch_Nghĩa_Chi_Tiết]
      ,[Từ_Đồng_Nghĩa]
      ,[Từ_Trái_Nghĩa]
  FROM [dbo].[TuVung]
  WHERE [Từ_Tiếng_Anh] = @Từ_Tiếng_Anh
   
GO
/****** Object:  StoredProcedure [dbo].[TuVung_Xoa]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TuVung_Xoa]
@Từ_Tiếng_Anh nvarchar(100)

AS 

DELETE FROM [dbo].[TuVung]
      WHERE [Từ_Tiếng_Anh] = @Từ_Tiếng_Anh 
GO
/****** Object:  Table [dbo].[TuVung]    Script Date: 12/26/2018 11:29:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuVung](
	[Từ_Tiếng_Anh] [nvarchar](100) NOT NULL,
	[Dịch_Nghĩa_Chi_Tiết] [nvarchar](max) NULL,
	[Từ_Đồng_Nghĩa] [nvarchar](100) NULL,
	[Từ_Trái_Nghĩa] [nvarchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Hello', N'Chào, gọi (v)', N'Hi,  hey, greetings', N'Bye')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Love', N'Lòng yêu, tình thương (n)
- love of one''s country
  lòng yêu nước

Tình yêu, mối tình (n)
- first love
  mối tình đầu

Yêu,  thương  (v)
- to love one another
  yêu nhau, thương nhau', N'Like, crush, cherish', N'Dislike, hate')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Orange', N'Quả cam (n)

Màu cam (adj)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Student', N'Sinh viên, học sinh', N'Scholar, pupil', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Hate', N'Sự căm ghét (n)

Ghét, căm thù, không muốn (v)', N'Antipathy, detest, aversion', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Apple', N'Quả táo (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Banana', N'Quả chuối (n)
- A bunch of banana
  một buồng chuối', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Starfish', N'Sao biển (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Jellyfish', N'Con sứa (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Turtle', N'Con rùa (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Squid', N'Con mực (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Octopus', N'Con bạch tuộc (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Penguin', N'Chim cánh cụt (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Whale', N'Cá voi (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Bee', N'Con ong (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Butterfly', N'Con bướm (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Ant', N'Con kiến (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Lobster', N'Tôm hùm (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Bear', N'Con gấu (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Monkey', N'Con khỉ (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Elephant', N'Con voi (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Fox', N'Con cáo (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Dog', N'Con chó (n)', N'Puppy', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Tiger', N'Con hổ (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Lion', N'Sư tử (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Deer', N'Con hươu (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Bat', N'Con dơi (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Owl', N'Chim cú (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Chicken', N'Con gà (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Duck', N'Con vịt (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Parrot', N'Con vẹt (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Pigeon', N'Bồ câu (n)', N'Dove', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Sparrow', N'Chim sẻ (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Eagle', N'Đại bàng (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Grandmother', N'Bà nội, bà ngoại (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Grandfather', N'Ông nội, ông ngoại (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Father', N'Cha (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Mother', N'Mẹ (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Uncle', N'Cậu, chú, bác (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Aunt', N'Cô, dì, thím (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Sister', N'Chị, em gái (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Brother', N'Anh, em trai (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Siblings', N'Anh chị  em ruột (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Cousin', N'Anh chị em họ (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Niece', N'Cháu gái (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Nephew', N'Cháu trai', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Twin', N'Anh, chị em sinh đôi (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Infant', N'Trẻ sơ sinh (n)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Walk', N'Dáng đi, đường đi (n)
- To know someone by his walk.
   Nhận ra một người qua dáng đi.

- This is my favourite walk
  Đây là con đường đi dạo ưa thích của tôi

Đi bộ, tản bộ (v)', N'', N'')
INSERT [dbo].[TuVung] ([Từ_Tiếng_Anh], [Dịch_Nghĩa_Chi_Tiết], [Từ_Đồng_Nghĩa], [Từ_Trái_Nghĩa]) VALUES (N'Fish', N'Cá, món cá (n)

Đánh cá, câu cá (v)', N'', N'')
USE [master]
GO
ALTER DATABASE [TuDienAnhViet] SET  READ_WRITE 
GO

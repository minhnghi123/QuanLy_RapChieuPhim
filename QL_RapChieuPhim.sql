use master
go
IF EXISTS(SELECT 1 FROM sys.databases WHERE name ='QL_RapChieuPhim')
	DROP DATABASE [QL_RapChieuPhim]
GO
Create database [QL_RapChieuPhim]
GO

use [QL_RapChieuPhim]
GO

CREATE TABLE [USER](
	Id INT PRIMARY KEY IDENTITY(1, 1),
	UserName VARCHAR(20) NOT NULL,
	PassWord VARCHAR(20) NOT NULL,
	Email VARCHAR(30) NOT NULL,
	MaLoai INT NOT NULL
)

insert inot 
go
GO
create proc [dbo].[proc_login] @user nvarchar(50), @pass nvarchar(50)
as
begin
	select * from [USER] where UserName = @user and [PassWord] =@pass
end
GO
GO
INSERT INTO [USER] (UserName,PassWord,Email,MaLoai) VALUES ('user','123','2@gmail.com', 2)
INSERT INTO [USER] (UserName,PassWord,Email,MaLoai) VALUES ('admin','123','1@gmail.com', 1)
GO

CREATE TABLE Phim (
    MaPhim INT PRIMARY KEY IDENTITY(1, 1),
    TenPhim NVARCHAR(250) NOT NULL,
    DaoDien NVARCHAR(250),
    DienVien NVARCHAR(250),
    TheLoai NVARCHAR(250),
    ThoiLuong INT,
    MoTa NVARCHAR(MAX),
	Hinanh varbinary(max),
)

GO
INSERT INTO [Phim] (TenPhim, DaoDien, DienVien, TheLoai, ThoiLuong, MoTa)
VALUES (N'Bố Già', N'Trấn Thành', N'Trấn Thành, Tuấn Trần, Ngọc Giàu', N'Hài-Chính kịch', 128, 
N'Lấy bối cảnh tại Thành phố Hồ Chí Minh, nội dung phim xoay quanh mỗi quan hệ giữa ông Sang – một người luôn lo chuyện bao đồng và giúp đỡ người khác – và con trai ông là Quắn
– một cậu thanh niên kiếm tiền bằng Youtube rất yêu thương ba và em gái – cùng những rắc rối mà cả hai gặp phải với những người thân trong gia đình mình.'),

(N'Godzilla x Kong: Đế Chế Mới', N'Adam Wingard', N'Rebecca hall, Dan Stevens, Rachel House', N'Giả tưởng, hành động, phiêu lưu', 115, N'Bộ phim sẽ tiếp nối sau những cuộc đối đầu bùng nổ của "Godzilla đại chiến Kong",
một cuộc phiêu lưu hoàn toàn mới, đưa Kong và Godzilla cùng nhau chống lại một mối đe dọa khổng lồ chưa được khám phá,
ẩn sâu trong Trái Đất. Bộ phim sẽ đào sâu hơn vào phần lịch sử của những Titan, nguồn gốc cũng như những bí ẩn tại Đảo Đầu Lâu,
đồng thời khám phá trận chiến thần thoại đã tạo nên những sinh vật phi thường và sự gắn kết của chúng với loài người.'),

(N'HÀO QUANG ĐẪM MÁU', N'Yoo Young-su', N'Park Ji Yeon, Song Ji Eun, Kim Nu Ri', N'Hồi hộp', 98, N'Câu chuyện kể về Lee Soo-yeon (do Ji-yeon thủ vai) -
một nữ minh tinh màn bạc đang ở đỉnh cao sự nghiệp nhưng bất chợt tuột dốc không phanh vì tai nạn chết người do chính cô gây ra trong lúc say rượu.
Sau thời gian dài “ở ẩn” để trả giá cho sai lầm, Lee Soo-yeon bắt đầu nuôi mộng trở lại với khán giả nhưng bê bối từ quá khứ của cô luôn bị người đời đay nghiến, châm chọc.'),

(N'ĐIỀM BÁO CỦA QUỶ', N'Arkasha Stevenson', N'Nell Tiger Free, Tawfeek Barhom, Sonia Braga, Ralph Ineson, and Bill Nighy', N'Kinh Dị', 119, N'Khi một cô gái người Mỹ được đưa đến Rome để bắt đầu phụng sự Giáo Hội, 
cô đã phát hiện ra thế lực hắc ám khiến cô hoài nghi về đức tin của chính mình,
đồng thời hé lộ một âm mưu kinh hoàng nhằm tái sinh linh hồn ác quỷ đầu thai đến nhân thế.'),

(N'QUỶ CÁI', N'Artistaya & Theerakhaha Arriyawongsa', N'Artistaya & Theerakhaha Arriyawongsa', N'Kinh Dị', 90, N'Được sự chỉ định của giáo sư, 5 sinh viên đại học năm cuối được mời đến dinh thự cổ thuộc sở hữu của dòng tộc danh giá ML.Salukjit. Trước khi quyết định ra đi hay ở lại, 
Ml.Salukjit đã khiến họ khiếp sợ trước sức mạnh ma quỷ của mình.'),

(N'DUNE: HÀNH TINH CÁT - PHẦN HAI', N'Denis Villeneuve', N'Denis Villeneuve, Jon Spaihts, Frank Herbert', N'Hành Động, Phiêu Lưu, Tâm Lý', 166, N'“Dune: Hành Tinh Cát – Phần 2” sẽ tiếp tục khám phá hành trình đậm chất thần thoại của Paul Atreides 
khi anh đồng hành cùng Chani và những người Fremen trên chặng đường trả thù những kẻ đã hủy hoại gia đình mình. Đối mặt với những lựa chọn giữa tình yêu của cuộc đời mình và số phận của vũ trụ, Paul phải ngăn chặn viễn cảnh tương lai tồi tệ chỉ mình anh nhìn thấy.'),

(N'MAI', N'Trấn Thành', N'Phương Anh Đào, Tuấn Trần, Trấn Thành, Uyển Ân, Hồng Đào, NSND Việt Anh, NSND Ngọc Giàu', N'Tâm Lý, Tình cảm', 131, N'"Mai" xoay quanh cuộc đời của một người phụ nữ đẹp tên Mai (do Phương Anh Đào thủ vai) có số phận rất đặc biệt. Bởi làm nghề mát xa, 
Mai thường phải đối mặt với ánh nhìn soi mói, phán xét từ những người xung quanh. Và rồi Mai gặp Dương (Tuấn Trần) - chàng trai đào hoa lãng tử. Những tưởng bản thân không còn thiết tha yêu đương và mưu cầu hạnh phúc cho riêng mình thì khao khát được sống một cuộc đời mới trong Mai trỗi dậy khi Dương tấn công cô không khoan nhượng.
Họ cho mình những khoảnh khắc tự do, say đắm và tràn đầy tiếng cười. Liệu cặp đôi ấy có nắm giữ được niềm hạnh phúc đó dài lâu khi miệng đời lắm khi cay nghiệt, bất công? "Mai" - một câu chuyện tâm lý, tình cảm pha lẫn nhiều tràng cười vui nhộn với sự đầu tư mạnh tay nhất trong ba phim của Trấn Thành hứa hẹn sẽ đem đến cho khán giả những phút giây thật sự ý nghĩa trong mùa Tết năm nay.'),

(N'THANH XUÂN 18x2: LỮ TRÌNH HƯỚNG VỀ EM', N'Fujii Michihito', N'Greg Hsu, Kaya Kiyohara, Chang Chen, Kuroki Hitomi, Michieda Shunsuke', N'Tình cảm', 123, N'Ký ức tình đầu ùa về khi Jimmy nhận được tấm bưu thiếp từ Ami. Cậu quyết định một mình bước lên chuyến tàu đến Nhật Bản gặp lại người con gái cậu đã bỏ lỡ 18 năm trước. 
Mối tình day dứt thời thanh xuân, liệu sẽ có một kết cục nào tốt đẹp khi đoàn tụ?'),

(N'KUNG FU PANDA 4', N'Mike Mitchell', N'Jack Black, Dustin Hoffman, James Hong, Awkwafina', N'Hài, Hoạt Hình', 94, N'Sau khi Po được chọn trở thành Thủ lĩnh tinh thần của Thung lũng Bình Yên, Po cần tìm và huấn luyện một Chiến binh Rồng mới, 
trong khi đó một mụ phù thủy độc ác lên kế hoạch triệu hồi lại tất cả những kẻ phản diện mà Po đã đánh bại về cõi linh hồn.'),

(N'BIỆT ĐỘI SĂN MA: KỶ NGUYÊN BĂNG GIÁ', N'Gil Kenan', N'Mckenna Grace, Carrie Coon, Annie Potts', N'Hài, Phiêu Lưu, Thần thoại', 115, N'Sau các sự kiện của Ghostbusters: Afterlife, gia đình Spengler đang tìm kiếm cuộc sống mới ở Thành phố New York. 
Nhóm săn ma bao gồm Ray, Winston và Podcast sử dụng công nghệ mới để chống lại các mối đe dọa chết người cổ xưa đang ẩn náu trong các vật dụng hàng ngày. Thế nhưng, họ sẽ phải đối đầu với một thế lực đen tối hùng mạnh mới.'),

(N'ANH HÙNG BÀN PHÍM', N'Ahn Guk Jin', N'Son Sukku, Kim Sung-Cheol, Kim Dong-Hwi, Hong Kyung', N'Tội phạm', 106, N'Im Sang-jin - một phóng viên mảng xã hội đã bị đình chỉ công tác sau bài phóng sự điều tra sai lệch về những lùm xùm của tập đoàn Manjun. Tưởng rằng phải chịu nỗi oan ức suốt đời, Im Sang-jin bất ngờ nhận được thông tin ẩn danh khẳng định anh không sai,
mà mọi thứ đã bị thao túng bởi một “đội quân” trực tuyến: Chỉ cần có tiền, sự thật nào cũng hoá thành dối lừa, còn tin tức giả lại hoá thành sự thật. Quyết tâm dấn thân vào con đường điều tra “Team Aleph”, Im Sang-jin dần khám phá ra những bí mật động trời khi tiếp xúc với các thành viên chủ chốt của nhóm chuyên gieo rắc tin giả.
Thế lực đứng sau các thông tin sai lệch có sức mạnh khủng khiếp đến nhường nào? Liệu Im Sang-jin có thể lật tẩy tất cả và giành chiến thắng giữa ranh giới mong manh của sự thật và dối trá?'),

(N'TU VIỆN MÁU', N'Michael Mohan', N'Sydney Sweeney, Álvaro Morte, Simona Tabasco', N'Kinh Dị', 85, N'Với đức tin sâu sắc, Cecilia đến với một tu viện cổ kính, nằm giữa một vùng quê đẹp nên thơ tại nước Ý trong sự chào đón của mọi người. Thế nhưng, những sự kiện kỳ lạ liên tiếp xảy ra, một bước ngoặt đưa Cecilia đến một vị trí cô không thể ngờ tới.
Cùng với đó, những bí mật kinh hoàng đằng sau vẻ bình yên của tu viện này dần lộ diện.'),

(N'ĐÓA HOA MONG MANH', N'Mai Thu Huyền', N'Maya, Mai Thu Huyền, Đức Tiến, Quốc Cường, Trizzie Phương Trinh, Nhật Hạ, Nguyễn Anh Dũng', N'Tâm Lý', 95, N'Sau một đêm hát thay cho người chị họ Ellie, Thạch Thảo lọt vào mắt xanh của Sơn - một nhà sản xuất âm nhạc. Cô nhận được lời mời thu âm hấp dẫn từ vợ chồng Sơn và trở nên nổi tiếng.
Nàng càng lúc càng tỏa sáng như một đóa hoa, khiến đàn ông nào cũng muốn chở che, trong đó có cả Sơn. Vợ Sơn là một phụ nữ quyền lực, cô phát hiện ra chuyện này và tính toán âm mưu đối phó. Liệu đâu là ái tình phù phiếm, đâu là bến đỗ thật sự dành cho nàng? Và đóa hoa Thạch Thảo này có" sớm nở chóng tàn" hay còn sự thật nào ẩn chứa đằng sau? Tất cả sẽ được giải đáp trong " ĐÓA HOA MONG MANH"'),

(N'EXHUMA: QUẬT MỘ TRÙNG MA', N'Jang Jae Hyun', N'Choi Min Sik, Yoo Hai Jin, Kim Go Eun, Lee Do Hyun', N'Kinh Dị', 133, N'Hai pháp sư, một thầy phong thuỷ và một chuyên gia khâm liệm cùng hợp lực khai quật ngôi mộ bị nguyền rủa của một gia đình giàu có, nhằm cứu lấy sinh mạng hậu duệ cuối cùng trong dòng tộc. Bí mật hắc ám của tổ tiên được đánh thức.'),


(N'Cái Giá Của Hạnh Phúc', N'Nguyễn Ngọc Lâm', N'Thái Hòa, Uyển Ân, hữu Châu', N'Tâm lý, tình cảm, gia đình', 114, N'Bà Dương và ông Thoại luôn cố gắng để xây dựng một hình ảnh gia đình tài giỏi và danh giá trong mắt mọi người.
Tuy nhiên dưới lớp vỏ bọc hào nhoáng ấy là những biến cố và lục đục gia đình đầy sóng gió. Nhìn kĩ hơn một chút bức tranh gia đình hạnh phúc ấy, rất nhiều “khuyết điểm” sẽ lộ ra gây bất ngờ.
');

GO

CREATE TABLE RapChieu (
    MaRapChieu INT PRIMARY KEY IDENTITY(1, 1),
    TenRap NVARCHAR(250) NOT NULL,
    DiaChi NVARCHAR(250)
)
GO
INSERT INTO [RapChieu] (TenRap, DiaChi)
VALUES (N'CGV Bình Dương', N'Bình Dương')
INSERT INTO [RapChieu] (TenRap, DiaChi)
VALUES (N'BETA Cinemas Empire', N'Bình Dương')
GO

CREATE TABLE PhongChieu (
    MaPhongChieu INT PRIMARY KEY IDENTITY(1, 1),
    MaRapChieu INT NOT NULL,
    SoGhe INT,
    FOREIGN KEY (MaRapChieu) REFERENCES RapChieu(MaRapChieu)
)
GO
INSERT INTO PhongChieu (MaRapChieu, SoGhe) VALUES (1,120) 
INSERT INTO PhongChieu (MaRapChieu, SoGhe) VALUES (1,120) 
INSERT INTO PhongChieu (MaRapChieu, SoGhe) VALUES (2,120) 
INSERT INTO PhongChieu (MaRapChieu, SoGhe) VALUES (2,120) 
go

CREATE TABLE GheNgoi (
    MaGheNgoi varchar(10) ,
    MaPhongChieu INT NOT NULL,
    SoGhe INT NOT NULL,
    LoaiGhe NVARCHAR(255),
    TrangThai VARCHAR(255),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu),
	primary key(MaGheNgoi,MaPhongChieu)
)
go

go

select * from PhongChieu
GO
CREATE proc InsertGheNgoi (@maphong int)
AS
BEGIN
    DECLARE @RowInserted INT = 0;
    
    -- Variables for looping through rows
    DECLARE @i CHAR(1), @j INT;
    
    SET @i = 'A'; -- Starting row letter
    SET @j = 1;   -- Starting row number
    
    WHILE @i <= 'E'
    BEGIN
        WHILE @j <= 12
        BEGIN
            INSERT INTO GheNgoi (MaGheNgoi, MaPhongChieu, SoGhe, LoaiGhe, TrangThai) VALUES  (@i + CAST(@j AS VARCHAR(2)),@maphong, @j, N'Ghế thường', NULL); -- Change MaPhongChieu value accordingly
            SET @j = @j + 1;
        END;

        SET @i = CHAR(ASCII(@i) + 1); -- Move to the next letter
        SET @j = 1;  -- Reset row number for the next letter
    END;

    SET @RowInserted = @@ROWCOUNT; -- Get the number of rows inserted

    
END;
GO
CREATE proc InsertGheNgoiDoi (@maphong int)
AS
BEGIN
    DECLARE @RowInserted INT = 0;
    
    -- Variables for looping through rows
    DECLARE @i CHAR(1), @j INT;
    
    SET @i = 'F'; -- Starting row letter
    SET @j = 1;   -- Starting row number
    
    WHILE @i <= 'F'
    BEGIN
        WHILE @j <= 6
        BEGIN
            INSERT INTO GheNgoi (MaGheNgoi, MaPhongChieu, SoGhe, LoaiGhe, TrangThai) VALUES  (@i + CAST(@j AS VARCHAR(2)),@maphong, @j, N'Ghế đôi', NULL); -- Change MaPhongChieu value accordingly
            SET @j = @j + 1;
        END;

        SET @i = CHAR(ASCII(@i) + 1); -- Move to the next letter
        SET @j = 1;  -- Reset row number for the next letter
    END;

    SET @RowInserted = @@ROWCOUNT; -- Get the number of rows inserted

    
END;
GO
-- exec InsertGheNgoi
/*

*/
go
CREATE TABLE SuatChieu (
    MaSuatChieu INT PRIMARY KEY IDENTITY(1, 1),
    MaPhim INT NOT NULL,
    MaPhongChieu INT NOT NULL,
    ThoiGianChieu DATETIME NOT NULL,
    GiaVe DECIMAL(10,2),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
)
GO
select format(getdate(), 'yyyy-MM-dd HH:mm:ss.fff')

insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (1,1,'2024-05-04 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (2,1,'2024-05-04 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (3,1,'2024-05-04 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (4,1,'2024-05-04 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (5,1,'2024-05-04 23:00:00',10000)

insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (1,1,'2024-05-06 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (2,1,'2024-05-06 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (3,1,'2024-05-06 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (4,1,'2024-05-06 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (5,1,'2024-05-06 23:00:00',10000)

insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (5,1,'2024-05-06 23:30:00',10000)

insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (1,1,'2024-05-07 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (2,1,'2024-05-07 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (3,1,'2024-05-07 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (4,1,'2024-05-07 23:00:00',10000)
insert into suatchieu (MaPhim,MaPhongChieu,ThoiGianChieu,GiaVe) values (5,1,'2024-05-07 23:00:00',10000)
go
create view view_phimdangchieutrongngay 
as
select phim.*,SuatChieu.GiaVe,SuatChieu.MaPhongChieu,SuatChieu.MaSuatChieu,.SuatChieu.ThoiGianChieu
from
Phim INNER join SuatChieu on Phim.MaPhim = SuatChieu.MaPhim
where  convert(varchar(10), ThoiGianChieu, 102)  = convert(varchar(10), getdate(), 102) and ThoiGianChieu > GETDATE()

go
select * from view_phimdangchieutrongngay
go 


CREATE TABLE NguoiDung (
    MaNguoiDung INT PRIMARY KEY IDENTITY(1, 1),
    HoTen VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    SDT VARCHAR(255),
    DiaChi VARCHAR(255),
	hinhanh varbinary(max) null,


)
GO
GO
exec InsertGheNgoiDoi 1
exec InsertGheNgoiDoi 2
exec InsertGheNgoiDoi 3
exec InsertGheNgoiDoi 4
exec InsertGheNgoi 1
exec InsertGheNgoi 2
exec InsertGheNgoi 3
exec InsertGheNgoi 4
go
CREATE TABLE Ve (
    MaVe INT PRIMARY KEY IDENTITY(1, 1),
    MaSuatChieu INT NOT NULL,
    MaGheNgoi varchar(10) NOT NULL,
    MaNguoiDung INT ,
    GiaVe DECIMAL(10,2),
    MaGiamGia VARCHAR(255),
    PhuongThucThanhToan NVARCHAR(255),
    NgayDat DATETIME NOT NULL,
    TrangThai VARCHAR(255),
    FOREIGN KEY (MaSuatChieu) REFERENCES SuatChieu(MaSuatChieu),
    --FOREIGN KEY (MaGheNgoi) REFERENCES GheNgoi(MaGheNgoi),
    --FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
)

select* from view_phimdangchieutrongngay

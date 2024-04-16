create proc proc_login @user nvarchar(50), @pass nvarchar(50)
as
begin
	select * from cinema_TaiKhoan where TaiKhoan = @user and MatKhau =@pass
end
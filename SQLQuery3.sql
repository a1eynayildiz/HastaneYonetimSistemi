

CREATE PROCEDURE kayitOl
    @kulAdi varchar(50),
    @sifre varchar(50)
AS
BEGIN
    INSERT INTO tbl_Login (kulAdi, sifre)
    VALUES (@kulAdi, @sifre);
END

select * from tbl_Login